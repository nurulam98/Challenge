def add_binary(a,b):
    c = a+b
    binary_string = ""
    while c > 1 :
        if c % 2 == 0:
            binary_string += "0"
        else:
            binary_string += "1"
        c = c // 2
    if c == 1:
        binary_string += "1"
    return binary_string[::-1]

print(add_binary(1,1))