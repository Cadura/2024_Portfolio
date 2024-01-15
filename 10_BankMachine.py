#global variables - used across program.
quitFlag = False
starting_balance = 0.00
new_balance = 0.00
amount_given = 0.00
previous_balance = 0.00

def move_money(adj_acc):
    new_money = 50
    amount_used = 50
    b_balance = adj_acc - amount_used 
    
    print("This is account 2: You're money here is $%0.2f" % new_money)
    print("Your other account is now: $%0.2f" % b_balance)


#deposit
def DepositMoney(strBal, preBal):
    amount_input = float(input("How much would you like to add to your balance? \n "))
    if previous_balance == 0:
        total_balance = strBal + amount_input
    else:
        total_balance = preBal + amount_input
    return total_balance

#withdrawal
def WithdrawMoney(strBal, preBal):
    amount_input = float(input("How much would you like to add to your balance? \n "))
    if previous_balance == 0:
        total_balance = strBal - amount_input
    else:
        total_balance = preBal - amount_input
    return total_balance

#starting variables for user accounts
def createAccount():
    
    name = "Chris"
    acc_type = "checking"
    new_account = 5.00
    print("Hello " + name)
    print("Here is your account " + name + ", with a balance of $%0.2f" % new_account)
    return new_account

#displays options for program.
def printMenu():
    i = 0
    displayMenuArray = ["Display Balance[b]", "Withdraw  Money[w]", "Deposit   Money[d]", "Quit    Program[q]"]
    for i in range(4):
        print(
f"""===========================
|                          |
|   {displayMenuArray[i]}     |
|                          |
===========================""")

def DisplayAccount(current_balance):
    print(
f"""=====================================
|            Current Balance:         |
|                 $%0.2f""" % current_balance + """              |
|                                    |
=====================================""")

# collect previous Transactions for each account.
def previousTransact():
    print("Hello")















#display intro.
print("""
==============================================
==============================================
            Welcome to our ATM!
        What can I do for you today?

Your options are right below! Press the letter
        below for the option you want!
==============================================
==============================================

""")

starting_balance = createAccount()



while quitFlag == False:
    DisplayAccount(new_balance)
    printMenu()
    #option giving
    option = input("What would you like to do today?  ")
    if option == 'q':
        quitFlag = True
        print("You decided to quit program! Goodbye!")
    elif option == 'w':
        new_balance = WithdrawMoney(starting_balance, previous_balance)
    elif option == 'd':
        if previous_balance == 0:
            new_balance = DepositMoney(starting_balance, previous_balance)
            previous_balance = starting_balance

        else:
            previous_balance = new_balance
            new_balance = DepositMoney(starting_balance, previous_balance)

    else:
        print("Sorry. I couldn't catch that input. Please try to use the options: [b], [w], [d], or [q]")

