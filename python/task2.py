import functools
import random

lst = [random.randint(-20, 20) for i in range(10)]
print(lst)
sum = functools.reduce(lambda a, b: a + b, lst)
print("sum is: " + str(sum))
if sum > 0:
    lst = list(map(lambda a: a + 5, lst))
    max = max(lst)
    if not all(lst):
        lst = list(filter(lambda a: a > 0 and a < max, lst))
        print(lst)
    else:
        min = min(lst)
        list = list(filter(lambda a: a > min+5 and a < max, lst))
        print(list)
else:
    lst = list(map(lambda a: a * (-1), lst))
    print(lst)
    max = max(lst)
    min = min(lst)
    lst = list(filter(lambda a: a > min+5 and a < max, lst))
    print(lst)

