/* 
 * Name: Payton Zellmer
 * ID: 100342335
 * Date: 2/7/20
 * Description: To create a program that reads files and writes to new ones
 * based off of info from first file.
 * Cited Sources: PPT, Textbook, Notes
 */

/*Importing necessary tools for file reading to work */
import java.io.*;
import java.util.Scanner;
public class ReadingWritingData {
	public static void main(String[] args) throws IOException {
		/* opening the file that is to be read */
		File myFile= new File("data.txt");
		Scanner inputFile=new Scanner(myFile);
		int max,min;
		max=inputFile.nextInt();
		min=max;
		/* Here is where the file is read and placed into variables */
		while (inputFile.hasNext())
		{
			int num1 = inputFile.nextInt();
			if (num1>max) {
				max=num1;}
				else if (num1<min){
					min=num1;}
		}
		/* This is where the maximum and minimum numbers are written to the output file results.txt */
		FileWriter fwriter = new FileWriter("results.txt");
		PrintWriter outputFile = new PrintWriter(fwriter);
		outputFile.println("The maximum number from data.txt is: "+ max);
		outputFile.print("The minimum number from data.txt is: "+ min);
		outputFile.close();
		System.out.print("Done");
		
		// TODO Auto-generated method stub

	}

}
