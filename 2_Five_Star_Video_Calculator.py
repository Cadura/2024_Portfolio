"""
Program: FiveStarVideoCalculator.py
Author: Chris D
Computes the total of customer's video selections.
1. Constants:
        oldies_video_price = $2.00
        new_video_price = $3.00
2. Inputs:
        new_selections
        old_selections
        new_video_price
        old_video_price
3. Computations:
        new subtotal = newvideoprice * new selections
        old subtotal = oldvideoprice * old selections
        total = new subtotal + old subtotal
4. Outputs:
        total
"""

#Initializing constants
OLDIES_VIDEO_PRICE = 2.00
NEW_VIDEO_PRICE = 3.00


#Intro
print("""***************************************************************************
***************************************************************************""")
print("Welcome to thte Five Star Retro Video Store \n")

#Input Requests
new_selections = float(input("Enter the customer\'s number of new videos: "))
old_selections = float(input("Enter the customer\'s number of oldies videos: "))

# Compute the total price
total = NEW_VIDEO_PRICE * new_selections
total += OLDIES_VIDEO_PRICE * old_selections

# Display the total price
for i in range(10):
    print("*")

print("The total price: $%0.2f" % total + "\n")
print("""***************************************************************************
***************************************************************************""")
