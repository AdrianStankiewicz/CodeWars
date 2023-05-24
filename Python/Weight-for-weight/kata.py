def order_weight(strng):
    numbers = strng.split()

    def weight_key(num):
        return sum(int(digit) for digit in num)

    def sorting_criteria(num):
        return (weight_key(num), num)

    return ' '.join(sorted(numbers, key=sorting_criteria))
