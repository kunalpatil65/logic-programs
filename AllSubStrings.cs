using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		string originalString = "ABCD";
		
		Console.WriteLine("All substrings for given string");
		
		for(int i = 0; i < originalString.Length; i++)
		{
			StringBuilder sb = new StringBuilder();
			
			for (int j = i; j < originalString.Length; j++)
			{
				sb.Append(originalString[j]);
				Console.WriteLine(sb);
			}
		}
	}
}