using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Checking Prime Number......");
		int number = 12;
		bool isPrime = true;
		
		for(int i = 2; i < number/2; i++)
		{
			if(number % i == 0)
			{
				isPrime = false;
			}
		}
		
		if (isPrime)
		{
			Console.WriteLine("Given number {0} is prime", number);
		}
		else
		{
			Console.WriteLine("Given number {0} is not prime", number);
		}
	}
}