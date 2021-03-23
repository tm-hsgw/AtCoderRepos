import numpy as np

line = list(map(int, input().split()))
n = line[0]
q = line[1]

ff = np.zeros((n, n))

for _ in range(q):
    s = list(map(int, input().split()))
    if s[0] == 1:
        a = s[1] - 1
        b = s[2] - 1
        ff[a][b] = 1

    elif s[0] == 2:
        a = s[1] - 1
        for i in range(n):
            if ff[i][a]:
                ff[a][i] = 1

    elif s[0] == 3:
        a = s[1] - 1
        following = []
        for i in range(n):
            if ff[a][i]:
                following.append(i)

        for i in following:
            for j in range(n):
                if ff[i][j]:
                    ff[a][j] = 1

for i in range(n):
    s = ""
    for j in range(n):
        if i == j:
            s += "N"
        else:
            s += "Y" if ff[i][j] else "N"
    print(s)


