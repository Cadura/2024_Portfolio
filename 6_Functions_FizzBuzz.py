"""
Program: FizzBuzz.py
Author: Chris D
Computes a user's number and outputs parts of 'FizzBuzz'
based on division.
1. Constants:
        None
2. Inputs:
        int number
3. Computations:
    function FizzBuzz(number)
        number % 5 and 3 = 'FizzBuzz'
        number % 5 = 'Fizz'
        number % 3 = 'Buzz'
        number !% 5 or 3 = number
4. Outputs:
        print 'FizzBuzz' 'Fizz' 'Buzz' or #
"""

def FizzBuzz(N):
    if (N % 3 == 0):
        if (N % 5 == 0):
            print("FizzBuzz", end=" ")
        else:
            print("Fizz", end=" ")
    elif (N % 5 == 0):
        print("Buzz", end=" ")
    else:
        print(i, end=" ")
    

print("Welcome to the FizzBuzz Determiner!")
print("""***********************************""")
print("We will count a number for you, and show which numbers will be 'Buzz', 'Fizz', and 'Fizzbuzz'.\n")
number = int(input("Enter a number between 10 and 100: "))
for i in range(1, number+1):
    FizzBuzz(i)