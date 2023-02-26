def even_digit_squares(a, b):
    current_num = 2
    current_square = current_num ** 2
    result = []
    while current_square <= b:
        if (a <= current_square <= b) and ((current_square % 2) == 0) and (is_digits_even(current_square)):
            result.append(current_square)
        current_num += 1
        current_square = current_num ** 2
    return result


def is_digits_even(number):
    result = True
    for digit in str(number):
        result *= ((int(digit) % 2) == 0)
    return bool(result)
