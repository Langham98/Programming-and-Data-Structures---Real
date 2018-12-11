using System;

public class Welcome
{
	
	public static void Main(string[] args)
	{
		
		
		
	double num1, num2, num3, num4, min, mean;
	//set all the variables as double for accuracy with decimal numbers
	
	Console.WriteLine("Enter 4 numbers (Press Enter after each key stroke)");
		num1 = Double.Parse(Console.ReadLine());
		num2 = Double.Parse(Console.ReadLine());
		num3 = Double.Parse(Console.ReadLine());
		num4 = Double.Parse(Console.ReadLine());
		min = 0;
		//setting the string values as doubles for integrity
		if ((num1 <= num2) && (num1 <= num3) && (num1 <= num4))
		{
			min = num1;
			
		}
		if ((num2 <= num1) && (num2 <= num3) && (num2 <= num4))
		{
			min = num2;
			
		}
		if ((num3 <= num1) && (num3 <= num2) && (num3 <= num4))
		{
		    min = num3;
			
		}
		if ((num4 <= num1) && (num4 <= num2) && (num4 <= num3))
		{
			min = num4;
			
		}
		//conditional statement for the lowest number in the set of numbers
		
		double[] numArray = {num1, num2, num3, num4};
		//sets the array up using the inputted values
		Array.Sort(numArray);
		//built in function to sort the array
		double[] sortedArray = (double[])numArray.Clone();
		//creates a new array with the same values set up in the first using the inbuilt .Clone function
		int size = sortedArray.Length;
		//set the size as the arrays length or the number of values in the array
		int mid = size / 2;
		//sets mid to half of the number of values set in the array
		double median = (size % 2 != 0) ? (double)sortedArray[mid] : ((double)sortedArray[mid] + (double)sortedArray[mid - 1]) / 2;
		//size mod 2, inequal to 0, mid (array length / 2). returns either mid or (mid - 1) + (mid -1) / 2 
		
		
		mean = (num1 + num2 + num3 + num4) / 4;
		//calculates the mean by adding the numbers and taking away the size
		
			
		
		Console.Write("Numbers entered: ");
		Console.Write(string.Join(",", numArray));
		//this outputs the array in its sorted entirety 
		Console.WriteLine("\nMinimum value: " + min);
		//outputs the minimum value
		Console.WriteLine("Median Value : " + median);
		//outputs the median value
		Console.WriteLine("Mean value: " + mean);
		//outputs the mean value
		
		Console.ReadLine();
		//keeps the console window open to output the values
		
}

}