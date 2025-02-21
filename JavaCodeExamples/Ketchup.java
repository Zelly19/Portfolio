/*
Name: Payton Zellmer
Date: 2-____-20
Description: Opens and reads a file that calculates the total bought ketchup from each brand as 
well as the total income that each brought in. 
Sources Cited: Textbook,Professor,Slides
*/

import java.io.*;
import java.util.Iterator;
import java.util.Scanner;

public class Ketchup 
{
	public static void main(String[] args) throws IOException
	{
		/* File is opened and set for scanning. Along with starting up some useful variables. */
		File inputFile = new File("ketchupData.txt");
		Scanner inFile = new Scanner(inputFile);
		String ketchupChoice;
		int heinzCount=0,huntsCount=0,delmonteCount=0,stbCount=0;
		double heinzPrice,huntsPrice,delmontePrice,stbPrice;
		double heinzTotal=0,huntsTotal=0,delmonteTotal=0,stbTotal=0;
		/* The while loop reads the system lines and runs a line */
		while (inFile.hasNextLine())
		{
			ketchupChoice=inFile.next();
			if (ketchupChoice.equals("heinz")) 
			{
				heinzCount += 1;
				heinzPrice = inFile.nextDouble();
				heinzTotal = heinzTotal + heinzPrice;
				String.format("$%,.2f", heinzTotal);
				
			}
			else if (ketchupChoice.equals("hunts")) 
			{
				huntsCount += 1;
				heinzPrice = inFile.nextDouble();
				huntsPrice = inFile.nextDouble();
				huntsTotal += huntsPrice;
				String.format("$%,.2f", huntsTotal);
			}
			else if (ketchupChoice.equals("delmonte")) 
			{
				delmonteCount += 1;
				heinzPrice = inFile.nextDouble();
				huntsPrice = inFile.nextDouble();
				delmontePrice = inFile.nextDouble();
				delmonteTotal += delmontePrice;
				String.format("$%,.2f", delmonteTotal);
			}
			else if (ketchupChoice.equals("stb")) 
			{
				stbCount += 1;
				heinzPrice = inFile.nextDouble();
				huntsPrice = inFile.nextDouble();
				delmontePrice = inFile.nextDouble();
				stbPrice = inFile.nextDouble();
				stbTotal += stbPrice;
				String.format("$%,.2f", stbTotal);
			}
			
		}
		/* This is where the total bought and made items are outputed to the console */
		System.out.println("The total bottles bought of Heinz: " + heinzCount);
		System.out.println();
		System.out.println("The total bottles bought of Hunts: " + huntsCount);
		System.out.println();
		System.out.println("The total bottles bought of Delmonte: " + delmonteCount);
		System.out.println();
		System.out.println("The total bottles bought of Store Brand: " + stbCount);
		System.out.println();
		System.out.println("The total dollars Heinz earned: ");
		System.out.format("$%.2f %n", heinzTotal);
		System.out.println("The total dollars Hunts earned: ");
		System.out.format("$%.2f %n", huntsTotal);
		System.out.println("The total  dollars delmonte earned: ");
		System.out.format("$%.2f %n", delmonteTotal);
		System.out.println("The total dollars Store Brand earned: ");
		System.out.format("$%.2f %n", stbTotal);
		inFile.close();
		// TODO Auto-generated method stub

	}

}
