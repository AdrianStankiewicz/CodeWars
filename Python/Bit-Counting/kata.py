def count_bits(n):
    output = 0
    
    for e in bin(n)[2:]:
        print(e)
        if e == '1':
            output += 1
    
    return output