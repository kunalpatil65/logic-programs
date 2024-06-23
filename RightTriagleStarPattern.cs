/*
Enter number of rows to be printed
5

*
**
***
****
*****
******
*/

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter number of rows to be printed");
		int rows = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 0; i <= rows; i++)
		{
			for(int j = 0; j <= i; j++)
			{
				Console.Write("*");
			}
			
			Console.WriteLine("");
		}
	}
}