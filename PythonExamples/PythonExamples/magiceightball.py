#def eight_ball():
#    ball=open("answers.txt","r")
#    eight_answers=ball.read().splitlines()
#    print(eight_answers)
#    #gives a random answer from the list
#    import random
#    random_answer=random.choice(eight_answers)
#    print(random_answer)
#eight_ball()
def answer_list():
    dna=open("DNA.txt","r")
    dna_list=dna.read().splitlines()
    #print(dna_list)
    #gives a list through a for loop
    count=0
    a_count = 0
    t_count = 0
    g_count = 0
    c_count = 0
    for dna in dna_list:
        print(dna)
        if dna == 'A':
            a_count += 1
        elif dna == 'T':
            t_count += 1
        elif dna == 'G':
            g_count += 1
        else:
            c_count += 1
        count +=1
    print("There are",count,"total",'\n')
    avg_a= (a_count*100)/count
    avg_t= (t_count*100)/count
    avg_c= (c_count*100)/count
    avg_g= (g_count*100)/count
    print("The averages are A",format(avg_a,'.2f'),"T:",format(avg_t,'.2f'),"C",format(avg_c,'.2f'),"G",format(avg_g,'.2f'))
    outfile=open("DNNNNNNNNAA.txt",'w')
    print("The averages are A",format(avg_a,'.2f'),"%","T:",format(avg_t,'.2f'),"%","C",format(avg_c,'.2f'),"%","G",format(avg_g,'.2f'),"%",file=outfile)
    outfile.close()
    
    
answer_list()
