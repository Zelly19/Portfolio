#Assignment #4 -- Battleship---includes all points
#9/20/2019
#
game=input("Would you like to play Battleship? ")
while game[0]=="Y" or game[0]=="y":
    import random
    #This is where the user is asked to place the ship or have it be randomized.
    location=input("Would you like to place the Battleship? ")
    if location[0] == "Y" or location[0] =="y":
        row_input=int(input("enter the row number: "))
        col_input=int(input("enter the row number: "))
    else:
        row_input = random.randint(0,4)
        col_input = random.randint(1,9)
    print("")
    for row in range(5):
        for col in range(0,10):
            if row == row_input and col== col_input:
                print("X",end=" ")
            else:
                print("O",end=" ")
        print("")
    #This is the part where the user guesses where the ship is.
    row_guess= int(input("Please Guess a Row: "))
    col_guess= int(input("Please Guess a Column: "))
    attempt=1
    def board():
        for row in range(5):
            for col in range(0,10):
                if row == row_input and col== col_input:
                    if row_input == row_guess and col_input == col_guess:
                        print("!",end=" ")
                    else:
                        print("X",end=" ")
                elif row == row_guess and col == col_guess:
                    print("@", end=" ")
                else:
                    print("O",end=" ")
            print("")
    while (row_guess != row_input or col_guess != col_input) and attempt < 5:
        while attempt <5 and (row_guess != row_input or col_guess!= col_input):
            print("You Missed!")
            guess_collumn=abs(col_guess-col_input)
            guess_row=abs(row_guess-row_input)
            if guess_collumn >=  4 and guess_row > 1:
                print("Hint: You're cold!")
            elif guess_collumn <=  2 and guess_row < 1:
                print("Hint: You're getting warmer!")
            else:
                print("Hint: You're Freezing")
    #prints the map of where we hit the water or ship
            board()
            attempt +=1
            row_guess= int(input("Please Guess a Row: "))
            col_guess= int(input("Please Guess a Column: "))
    if col_input == col_guess and row_input== row_guess:
            board()
            print("Battleship has been sunk!")
            print("it took ",attempt," attempt(s) to sink the ship!")
    else:
            print("you missed the battleship!")
            col_input=col_guess
            row_input=row_guess
    print("Game Over! Would you like to play again?")
    game= input("Y/N: ")
print("Aye aye captain!")
print("Have a Great Day!")
