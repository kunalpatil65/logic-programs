using System;
					
public class Program
{
	public static void Main()
	{
		int number = 121;
		int reminder = 0;
		int sum = 0;
		int temp = number;
		
		while(number > 0)
		{
			reminder = number % 10;
			sum = (sum * 10) + reminder;
			number = number / 10;
		}
		
		if (temp == sum)
		{
			Console.WriteLine("given number {0} is palindrome", temp);
		}
		else
		{
			Console.WriteLine("given number {0} is not palindrome", temp);
		}
	}
}