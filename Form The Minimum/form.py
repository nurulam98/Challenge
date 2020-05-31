def min_value(digits):
    a = []
    for x in digits:
        if str(x) not in a:
            a.append(str(x))
    a.sort()
    return int("".join(a))

print(min_value([4, 7, 5, 7]))