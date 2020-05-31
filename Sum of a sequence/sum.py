def sequence_sum(begin_number, end_number, step):
    count = 0
    for x in range(begin_number, end_number+1, step):
        count += x
    return count

print(sequence_sum(0,15,3))