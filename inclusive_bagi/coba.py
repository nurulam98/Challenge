def inclusive_case(a,b,k):
    count = 0
    while a <= b:
        if a % k == 0:
            count += 1
        else:
            pass
        a += 1
    return count
f = open("aselole.txt","r")
count = 0
while True:
    a = f.readline()
    b = f.readline()
    c = f.readline()
    x = inclusive_case(int(a),int(b),int(c))
    print("Case {}: {}".format(count+1,x))
    count += 1
    if not c:
        break