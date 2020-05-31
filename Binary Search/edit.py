def binary_search(array, value, low, high):
    if high <= low:
        return -1
    else:
        mid = (low + high)//2
        if array[mid] > value:
            return binary_search(array, value, low, mid-1)
        elif array[mid] < value:
            return binary_search(array, value, mid+1, high)
        else:
            return mid
array = []
f = open("input.in","r")
outF = open("hasil.txt","w")
for i in range(10000):
    angka = f.readline()
    array.append(int(angka))
for i in range(10000):
    inputs = f.readline()
    answer = binary_search(array, int(inputs), 0, 9999)
    print("%d" % answer)
    outF.write(str(answer))
    outF.write("\n")
outF.close()
# for i in range(10):
#     value = int(input())
#     answer = binary_search(array, value, 0, 9999)
#     print("%d" % answer)
# for i in range(10000):
# f = open("input.in","r")
# while True:
#     input = f.readline()
#     answer = binary_search(array, int(input), 0, 9999)
#     outF = open("hasil.txt","w")
#     print("%d" % answer)
#     if not input:
#         break