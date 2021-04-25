using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace AHC002
{
    class Program
    {
        static Random Rand;
        static HashSet<int> SeenTile;
        static List<char> History;
        static int[][] Tile;
        static int[][] Point;
        static int deb = 0;
        static void Main(string[] args)
        {
            var position = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Tile = new int[50][];
            for(int i=0; i<50; i++){
                Tile[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            Point = new int[50][];
            for(int i=0; i<50; i++){
                Point[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }

            var sw = new Stopwatch();
            sw.Start();

            Rand = new Random(0);
            History = new List<char>();
            SeenTile = new HashSet<int>();
            SeenTile.Add(Tile[position[0]][position[1]]);

            while(sw.ElapsedMilliseconds < 1700){
            // while(true){
                var swk = new Stopwatch();
                while(Rand.NextDouble() < 0.25 && History.Count > 0){
                    var prevpos = Dir2Pos(History[History.Count - 1], position, true);
                    SeenTile.Remove(Tile[position[0]][position[1]]);
                    position[0] = prevpos[0];
                    position[1] = prevpos[1];

                    // //debug
                    // Console.WriteLine(new string(History.ToArray()));
                    // Console.WriteLine("{0},{1}", pos[0], pos[1]);

                    History.RemoveAt(History.Count - 1);
                }

                //生成数
                int ct = 5;
                //何手先まで見るか
                int k = 50;

                var res = new SortedSet<TryalResult>();
                var trial = new Trial(position);
                for(int t=0; t<ct; t++){
                    res.Add(trial.TryMove(k));
                }

                var nres = res.First();
                SeenTile = new HashSet<int>(nres.SeenTile);
                History = new List<char>(nres.History);
                position[0] = nres.Position[0];
                position[1] = nres.Position[1];
                //debug
                // Console.WriteLine(new string(History.ToArray()));
                // Console.Write(swk.ElapsedMilliseconds);
                // Console.Write(" / ");
                // Console.WriteLine(sw.ElapsedMilliseconds);
            }
            Console.WriteLine(new string(History.ToArray()));
        }

        class TryalResult : IComparable<TryalResult> {
            public HashSet<int> SeenTile;
            public List<char> History;
            public int[] Position = new int[2];

            public TryalResult(HashSet<int> st, List<char> his, int[] pos){
                SeenTile = new HashSet<int>(st);
                History = new List<char>(his);
                pos.CopyTo(Position, 0);
            }

            public int CompareTo(TryalResult other){
                return -1 * this.History.Count.CompareTo(other.History.Count);
            }
        }

        class Trial{
            HashSet<int> InitSeenTile {get;}
            List<char> InitHistory {get;}
            int[] InitPosition {get;} = new int[2];

            HashSet<int> SeenTile;
            List<char> History;
            int[] Position = new int[2];

            public Trial(IReadOnlyList<int> initPos){
                InitPosition[0] = initPos[0];
                InitPosition[1] = initPos[1];
                InitSeenTile = new HashSet<int>(Program.SeenTile);
                InitHistory = new List<char>(Program.History);
            }

            public TryalResult TryMove(int t){
                History = new List<char>(InitHistory);
                SeenTile = new HashSet<int>(InitSeenTile);
                InitPosition.CopyTo(Position, 0);
                for(int i=0; i<t; i++){
                    this.Move(Position);
                }
                return new TryalResult(SeenTile, History, Position);
            }

            void Move(int[] pos){
                //次の位置のタイルが今いる場所と同じ場合の排除
                SeenTile.Add(Tile[pos[0]][pos[1]]);

                //一定の確率で一歩戻る
                if(Rand.NextDouble() < 0.1 && History.Count > 0){
                    var prevpos = Dir2Pos(History[History.Count - 1], pos, true);
                    SeenTile.Remove(Tile[pos[0]][pos[1]]);
                    pos[0] = prevpos[0];
                    pos[1] = prevpos[1];

                    // //debug
                    // Console.WriteLine(new string(History.ToArray()));
                    // Console.WriteLine("{0},{1}", pos[0], pos[1]);

                    History.RemoveAt(History.Count - 1);
                }

                var dir = NextDirection();
                // var dir = NextDirDBG();
                var nextpos = Dir2Pos(dir, pos);

                //次の位置が範囲外
                if(!IsRegalPosition(nextpos)) return;

                //次の位置のタイルを踏んでいない
                if(SeenTile.Add(Tile[nextpos[0]][nextpos[1]])){
                    pos[0] = nextpos[0];
                    pos[1] = nextpos[1];
                    History.Add(dir);

                    // //debug
                    // Console.WriteLine(new string(History.ToArray()));
                    // Console.WriteLine("{0},{1}", pos[0], pos[1]);

                    return;
                }
            }
        }

        static char NextDirection(){
            var r = Rand.NextDouble();
            if(r < 0.25) return 'U';
            if(r < 0.5) return 'D';
            if(r < 0.75) return 'R';
            return 'L';
        }

        static char NextDirDBG(){
            deb++;
            if(deb % 4 == 0) return 'U';
            if(deb % 4 == 1) return 'D';
            if(deb % 4 == 2) return 'R';
            return 'L';
        }

        static bool IsRegalPosition(IReadOnlyList<int> pos){
            if(pos[0] < 0 || pos[0] >= 50) return false;
            if(pos[1] < 0 || pos[1] >= 50) return false;
            return true;
        }

        static IReadOnlyList<int> Dir2Pos(char c, IReadOnlyList<int> pos, bool back = false){
            if(back){
                switch(c){
                    case 'U':
                    c = 'D';
                    break;
                    case 'D':
                    c = 'U';
                    break;
                    case 'L':
                    c = 'R';
                    break;
                    case 'R':
                    c = 'L';
                    break;
                }
            }
            switch(c){
                case 'U':
                return new int[] {pos[0] - 1, pos[1]};
                case 'D':
                return new int[] {pos[0] + 1, pos[1]};
                case 'L':
                return new int[] {pos[0], pos[1] - 1};
                case 'R':
                return new int[] {pos[0], pos[1] + 1};
            }
// #if DEBUG
//             throw new ArgumentException();
// #endif
            return pos;
        }
    }
}
