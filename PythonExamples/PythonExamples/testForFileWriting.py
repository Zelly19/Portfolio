def file():
    outfile=open('testfiles.txt','w')
    outfile.write("Test1"'\n')
    outfile.write("Test2"'\n')
    outfile.write("Test3")
    outfile.close()

file()