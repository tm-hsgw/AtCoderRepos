s = input()

dic = []
i0 = 0
st = False
for i in range(len(s)):
    if s[i].islower():
        continue
    if st:
        dic.append(s[i0 : i + 1])
        st = False
    else:
        i0 = i
        st = True

dic = [w.lower() for w in dic]

dic.sort()

for w in dic:
    w_ls = list(w)
    w_ls[0] = w_ls[0].upper()
    w_ls[len(w_ls) - 1] = w_ls[len(w_ls) - 1].upper()
    print("".join(w_ls), end="")
print()