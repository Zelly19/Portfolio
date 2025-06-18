#Function practice


#Excersise #1
#def greeting():
#    name= input("What is your name? ")
#    print("Hello",name)
#greeting()


#Excersise #2
#def get_name():
#    name=input("What is your name? ")
#    return name
#
#val=get_name()
#print("Hello!",val)

#Excersise #3
#def coin_flip():
#    import random
#    random=random.randint(1,2)
#    if random == 1:
#        print("Heads")
#    else:
#        print("Tails")
#
#for i in range(10):
#    coin_flip()
    
##exercise #4
#def grid_map(num_rows, num_cols):
#    for row in range(num_rows):
#        for col in range(num_cols):
#            print("X",end=' ')
#        print("")
#num_rows=int(input("Enter number of rows "))
#num_cols=int(input("Enter number of columns "))        
#grid_map(num_rows,num_cols)

#Exercise #5
def dice():
    result=random.randint(1,6)
    return result

die1=dice()
die2=dice()
two_dice= (die1+die2)
print(two_dice)

#exercise #6

