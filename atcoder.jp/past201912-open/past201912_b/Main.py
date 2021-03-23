n = int(input())
a = [int(input()) for _ in range(n)]

for i in range(n - 1):
    da = a[i + 1] - a[i]
    if da == 0:
        print("stay")
        continue

    s = None
    if da < 0:
        da *= -1
        s = "down"
    else:  
        s = "up"

    print(f"{s} {da}")
    

