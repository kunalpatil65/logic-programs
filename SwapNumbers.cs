using System;
					
public class Program
{
	public static void Main()
	{
		int a = 10;
		int b = 20;
		
		Console.WriteLine("Numbers before swapping a: {0} and b: {1}", a, b);
		
		a = a + b;
		b = a - b;
		a = a - b;
		
		Console.WriteLine("Numbers after swapping a: {0} and b: {1}", a, b);
	}
}