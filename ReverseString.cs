using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter string");
		string message = Console.ReadLine();
		string reverseStr = string.Empty;
		
		for(int i = message.Length - 1; i >= 0; i--)
		{
			reverseStr += message[i];
		}
		
		Console.WriteLine("Reversed String is:" + reverseStr);
	}
}