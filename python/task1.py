from task1_enum import Region
from typing import Callable

EU_AGE = 65
NA_AGE = 62

EU_ALLOW_AGE = 18
NA_ALLOW_AGE = 21


def main():
    surnames_list = ["Komisarenko", "Vovk", "Zelenchuk", "Po"]
    names_list = ["Mark", "Bohdan", "Andrew", "Svitlana"]
    age_list = [67, 11, 19, 21]
    taskFunc(loudGreeting, retireAge, surnames_list[0], names_list[0], age_list[0], Region.EUROPE)
    taskFunc(loudGreeting, letGo, surnames_list[1], names_list[1], age_list[1], Region.EUROPE)
    taskFunc(quietGreeting, retireAge, surnames_list[2], names_list[2], age_list[2], Region.NORTH_AMERICA)
    taskFunc(quietGreeting, letGo, surnames_list[3], names_list[3], age_list[3], Region.NORTH_AMERICA)
    print("--------------Currying--------------")
    print(curr(sum)(1)(2))

def taskFunc(greeing, ageFunc, name, surname, age, region):
    greeing(name, surname)
    print("---------")
    ageFunc(age, region)
    print("-|-|-|-|-|-|-|-|-|")


def loudGreeting(name: str, surname: str):
    print(f"Hello, {surname} {name}!")


def quietGreeting(name: str, surname: str):
    print(f"Hi, {surname} {name}!")


def retireAge(age: int, region: Region):
    retire_age = EU_AGE if region == Region.EUROPE else NA_AGE
    diff = age - retire_age
    if diff < 0:
        print(f"To {diff * (-1)} years left to retierment !")
    else:
        print("You are already retired !")



def curr(func: Callable) -> Callable:
    def arg1(a: int) -> Callable:
        def arg2(b: int) -> int:
            return func(a, b)

        return arg2

    return arg1


sum = lambda a, b: a + b
sub = lambda a, b: a - b


def letGo(age: int, region: Region):
    required_age = EU_ALLOW_AGE if region == Region.EUROPE else NA_ALLOW_AGE
    if age >= required_age:
        print("You are wellcome!")
    else:
        print("You are too young!")


if __name__ == "__main__":
    main()
