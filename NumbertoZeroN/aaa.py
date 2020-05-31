import math
def solution(input1, input2):
    a = '0'*input1
    angka_nol = list(a)
    
    if(isinstance(input2,float)):
        input2_str = str(input2)
        input2_str = input2_str.replace(".","")
        posisi = (math.floor(input1/2)) -1
    else:
        input2_str = str(input2)
        posisi = round(input1/2)

    data = list(str(input2_str))
    iter = 0
    for x in range(posisi,len(a)):
        if(len(input2_str) == 1):
            angka_nol[x] = data[0]
            break

        elif(isinstance(input2,float)):
            if(iter == len(data)):
                pass
            else:
                angka_nol[x] = data[iter]
                iter += 1

        else:
            if(iter == len(data)):
                pass
            else:
                angka_nol[x] = data[iter]
                iter += 1

    angka_nol = "".join(angka_nol)

    return angka_nol


print(solution(10,350))