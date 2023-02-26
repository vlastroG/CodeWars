import itertools


def all_fibonacci_numbers():
    n = 0
    m = 1
    while True:
        yield m
        n, m = m, n + m


test = all_fibonacci_numbers()
print(list(itertools.islice(test, 10)))
