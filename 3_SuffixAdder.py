"""
Program: SuffixAdder.py
Author: Chris D
Adds the appropiate suffix to a numeral.
1. Inputs:
        numeral
        first_digit
        second_digit
        output
3. Computations:
        numeral.strip() ignores spaces
        numeral.isdigit() checks for numbers only
        length of numeral == 2
        determine last digit '1', '2', or '3' for appropiate suffix
4. Outputs:
        output = numeral + "suffix"
"""

# Intro
print("""*********************************************
*********************************************""")
print("""Welcome to a ordinal numerals application. \n
This app will translate your number as a
ordinal numeric. \n""")

# Input request
numeral = input("Enter your number here: ")

#Adjust errors
numeral = numeral.strip()
if numeral.isdigit() == False:
    print("\nOnly input numbers. No letters or symbols. Please Try Again. \n")
else:

    # Core variable
    first_digit = numeral[-1:]
    output = ""

    # Determine how many digits
    if len(numeral) >= 2:
        second_digit = numeral[-2:-1]
        # Determine 10s 
        if second_digit == '1':
            output = numeral + "th"
        # Determine suffix for last digit - tens or higher
        else:
            if first_digit == '1':
                output = numeral + "st"
            elif first_digit == '2':
                output = numeral + "nd"
            elif first_digit == '3':
                output = numeral + "rd"
            else:
                output = numeral + "th"
    # Determine suffix for last digit - 1 through 10
    else:
        if first_digit == '0':
            print("Does not compute: 0 by itself doesn't have a suffix.")
        elif first_digit == '1':
            output = numeral + "st"
        elif first_digit == '2':
            output = numeral + "nd"
        elif first_digit == '3':
            output = numeral + "rd"
        else:
            output = numeral + "th"
            
    # Output
    print("\nThe ordinal numeric for " + numeral + " is: " + output + "\n")
print("""*********************************************
""")


