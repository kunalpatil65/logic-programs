using System;
					
public class Program
{
	public static void Main()
	{
		int num1 = 0;
		int num2 = 1;
		int numX;
		Console.WriteLine("Enter the number of elements to be print");
		int numberOfElements = Convert.ToInt32(Console.ReadLine());
		
		Console.Write(num1 + " " + num2 + " ");
		
		for(int i = 2; i <= numberOfElements; i++)
		{
			numX = num1 + num2;
			
			Console.Write(numX + " ");
			
			num1 = num2;
			num2 = numX;
		}
	}
}