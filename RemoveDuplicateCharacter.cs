using System;
					
public class Program
{
	public static void Main()
	{
		string inputString = "google";
		string resultString = string.Empty;
		
		for(int i = 0; i < inputString.Length; i++)
		{
			if(!resultString.Contains(inputString[i].ToString()))
			{
				resultString += inputString[i];
			}
		}
		
		Console.WriteLine("String after removing duplicate characters:" + resultString);
	}
}