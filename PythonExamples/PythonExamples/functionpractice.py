
##10/1/2019
##dice roll for function
#
#import random
#def dice(num_sides):
#    result=random.randint(1,num_sides)
#    return result #back to the calling variable
#
#die1=dice(6)
#die2=dice(6)
#two_dice= (die1+die2)
#print(two_dice)
#
#
#sum = 0
#for i in range(1000):
#    val=dice(20)
#    sum += val
#    print(val)
#avg=sum/1000
#print(avg," is the average")

#ans=int(input("Enter a number: "))
#if ans % 2 == 0:
#    print("The number is Even")
#else:
#    print("The number is Odd")
#def even_odd_detector(ans):
#    if ans % 2 == 0:
#        print("The number is Even")
#    else:
#        print("The number is Odd")
#def main():
#    even_odd_detector(2)
#    even_odd_detector(5)
#    even_odd_detector(19)
#    even_odd_detector(30)
#    
#main()

#def is_even(num):
#    if num % 2 == 0:
#        return True
#    else:
#        return False
#        
#def main():
#    for i in range(5):
#        num=int(input("Enter a integer: "))
#        if is_even(num) == True:
#            print("Number is even")
#        else:
#            print("Number is odd")
#main()
#
#outfile=open("Numbers.txt",'w')
#
#print("23",file=outfile)
#print("5",file=outfile)
#print("78",file=outfile)
#print("1",file=outfile)
#print("34",file=outfile)
#print("5",file=outfile)
#
#outfile.close()
def is_even(num):
    if num % 2 == 0:
        return True
    else:
        return False
def main():
    infile=open("Numbers.txt",'r')
    my_list=infile.read().splitlines()
    #Converts elements in list to intedgers
    my_list = [int(val) for val in my_list]

    outfile1=open("Even.txt",'w')
    outfile2=open("Odd.txt",'w')
    for num in my_list:
        if is_even(num) == True:
            print(num, file=outfile1)
        else:
            print(num, file=outfile2)
    outfile1.close()
    outfile2.close()
    infile.close()
main()
        
    
    

