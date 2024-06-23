using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter Number");
		int number = Convert.ToInt32(Console.ReadLine());
		int factorial = 1;
		
		for(int i = 1; i <= number; i++)
		{
			factorial = factorial * i;
		}
		
		Console.WriteLine("Factorial of Number {0} is {1}", number, factorial);
	}
}