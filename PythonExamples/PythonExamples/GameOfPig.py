#10/24/2019
#Assignment #5
#game of Pig
#Roll a dice and make it to a value of 50 with the least amount of turns. But dont roll a 1!
#This assignment is around 15/15.

import random
import time
#The function that keeps it all under one roof. Allows the game to end and repeat.
def main():
    total= 0
    num_turns=0
    ns  = sides()
    while total < 50:
        total += take_player_turn(ns)
        num_turns +=1
        print('\n'"Stopped on",num_turns,"turns. The player Banked",total,"Points")
        print("")
        #This is where the game will open the text file with the high score and check to see if it was not broken. If it is then will replace with new.
        infile=open('highscore.txt','r')
        infile_num=int(infile.read())
        if total >= 50:
            if num_turns < infile_num:
                outfile=open('highscore.txt','w')
                print(num_turns,file=outfile)
                outfile.close()
                print("NEW HIGH SCORE")
            else:
                ans=infile_num
                print(ans,"is still the hish score!")
        infile.close()
#Prints out the definition and rules of the game of Pig
def print_rules():
    print("Pig is a dice game with simple rules:The goal is to reach a certain number of points (e.g. 50  points) in the fewest number of turns.")
    print("A player repeatedly rolls a die until either a 1 ('pig') is rolled or the player holds and scores the sum ofthe rolls (i.e. the turn total). At any time during a player's turn, the player is faced with two decisions:")
    print("• roll -If the player rolls a 1: the player scores nothing; the turn total is set to 0; and the number of turns is increased 2-6: the number is added to the player's turn total.")
    print("• hold -The turn total is added to the player's score and the number of turns is")
    print("")
    print_menu()
#Rolls the dice with the given number of sides
def roll_die(num_sides):
    time.sleep(.5)
    result=random.randint(1,num_sides)
    return result
#Supposed to ask the player to say how many sides there are on the dice.
def sides():
    val=int(input("How many sides? "))
    return val
    
    
#During each turn the player takes. This is where the code says what to do for each input.
def take_player_turn(num_sides):
    print_menu()
    keep_looping= True
    turn_total = 0
    while keep_looping == True:
        key = input()
        if key.lower() == 'h':
            keep_looping = False
        elif key.lower() == 'm':
            print_menu()
        elif key.lower() == 'd':
            print_rules()
        elif key.lower() == 'r':
            roll=roll_die(num_sides)
            if roll == 1:
                print("Busted"'\n')
                turn_total = 0
                keep_looping= False
            else:
                print("You rolled a",roll)
                turn_total += roll
                print("Total for this turn so far:",turn_total)
        else:
            print("Please enter a letter listed above")
    return turn_total
#Give the player a description of what to enter
def print_menu():
    """
    print the menu options for the user
    """
    print('\n'"Continue:")
    print("Press 'h' to Hold")
    print("Press 'r' to Roll")
    print("Press 'm' to see Menu")
    print("Press 'd' to see Rules")
#printing to outfile and checking if it is highest.
def file_check():
    outfile=open("highscore.txt",'w')
    print(num_turns,'w')
    outfile.close()
main()
#highscore.txt
    
#computer rolls  when player holds.   Computer rolls 3 times per turn. then holds.
