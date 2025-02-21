/* Homework Assignment #2
 * Payton Zellmer
 * 100342335
 * 2/3/20
 * this program calculates the avg of 5 numbers and displays it on a file
 */
import java.util.Scanner;
import java.io.*;

public class Average {

	public static void main(String[] args) throws IOException {
		/* starting out the program by defining the variables that
		 * are to be used and opening system operations
		 * like keyboard scanners and file writers */
		int num1,num2,num3,num4,num5;
		double sum,avg;
		String name;
		Scanner keyboard = new Scanner(System.in);
		
		/* asking the user for their name */
		System.out.println("What is your name");
		name = keyboard.nextLine();
		
		/* Asks for the first number that are to be averaged and placed into the file. */
		System.out.println(name + ", Please enter number 1 of 5: ");
		num1 = keyboard.nextInt();
		
		/* Asks for the 2nd number that are to be averaged and placed into the file. */
		System.out.println(name + ", Please enter number 2 of 5: ");
		num2 = keyboard.nextInt();
		
		/* Asks for the 3rd number that are to be averaged and placed into the file. */
		System.out.println(name + ", Please enter number 3 of 5: ");
		num3 = keyboard.nextInt();
		
		/* Asks for the 4th number that are to be averaged and placed into the file. */
		System.out.println(name + ", Please enter number 4 of 5: ");
		num4 = keyboard.nextInt();
		
		/* Asks for the last number that are to be averaged and placed into the file. */
		System.out.println(name + ", Please enter number 5 of 5: ");
		num5 = keyboard.nextInt();
		
		/* Calculates the total avg of the 5 numbers that the user has entered. */
		sum = num1 + num2 + num3 + num4 + num5;
		avg = sum/5;
		
		/* Outputs the information to a file */ 
		PrintWriter outputFile = new PrintWriter("Average.txt"); 
		outputFile.println("The five numbers were these: " + num1+","+ num2+","+ num3+","+ num4+","+ num5); 
		outputFile.print("The Sum of the numbers was " + sum); 
		outputFile.println(", So the average was " + avg);
		outputFile.print("Thank you for your time! " + name);
		outputFile.close(); 
		
		/* once systems program had ran. Sytem files and operations shall close */
		System.out.println(avg);
		System.out.println("Done!");
		keyboard.close();
		
		// TODO Auto-generated method stub
	}
}
