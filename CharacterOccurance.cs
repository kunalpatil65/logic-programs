using System;

public class Program
{
	public static void Main()
	{
		string name = "Kunal Patil";
		Console.WriteLine("input string:" + name);
		name = name.Replace(" ", string.Empty);
		Console.WriteLine("input string after removing whitespace:" + name);
		
		while (name.Length > 0)
		{
			int counter = 0;
			Console.Write(name[0] + " : ");
			
			for(int i = 0; i < name.Length; i++)
			{
				if (name[0] == name[i])
				{
					counter++;
				}
			}
			
			name = name.Replace(name[0].ToString(), string.Empty);
			Console.WriteLine(counter);
		}
	}
}