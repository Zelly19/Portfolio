scores=[[1,2,3,4],[5,6,7,8],[9,10,11,12]]

for row in range(len(scores)):
   sum=0
   for col in range(len(scores[row])):
       sum+=scores[row][col]
   print("Sum of row",row,"is",sum)

board=[['X','O','X'],['O','O','X'],['X','X','O']]
for row in range(len(board)):
   for col in range(len(board[row])):
       if col < 2:
           print(board[row][col],end="|")
       else:
           print(board[row][col],end=" ")
   print()
def main():
    table=[[0]*8 for rows in range(10)]
    
    for row in range(10):
        for col in range(8):
            table[10][8]