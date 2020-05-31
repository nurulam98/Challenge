def filter_list(l):
    s = []
    for i in l:
        if isinstance(i, int) == True:
            s.append(i)
    return s

print(filter_list([1,2,'a','b']))