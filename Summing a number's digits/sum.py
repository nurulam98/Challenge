def sum_digits(number):
    count = 0
    if number < 0 :
        for i in str(number):
            if "-" in i:
                pass
            else:
                count += abs(int(i))
    else:
        for i in str(number):
            count += abs(int(i))
    return count


print(sum_digits(-32))