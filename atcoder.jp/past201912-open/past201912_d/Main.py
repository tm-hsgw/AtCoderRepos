import random
from collections import deque

n = int(input())
a = [int(input()) for _ in range(n)]

a.sort()
x = 0
y = 0
for i in range(n):
    if i >= 1 and a[i] == a[i - 1]:
        y = a[i]
        
if x == y:
    print("Correct")
else:
    s = [i + 1 for i in range(n)]
    s1 = set(s)
    s2 = set(a)
    x = list(s1 - s2)
    x = x[0]
    print(f"{y} {x}")