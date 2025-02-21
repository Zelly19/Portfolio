
public class TwoDimArray {

	public static void main(String[] args) {
		char[][] array= new char[12][20];
		for (int i = 0;i<12;i++) {
			for (int j=0;j<20;j=j+2) {
				if (i%2==0) {
					array[i][j]='x';
					System.out.print("x");
					array[i][j+1]='O';
					System.out.print("O");
					}
				else {
					array[i][j]='O';
					System.out.print("O");
					array[i][j+1]='x';
					System.out.print("x");
					}	
			}
			System.out.println();
		}
	}
		// TODO Auto-generated method stub

}


