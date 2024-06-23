using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string originalString = "Welcome to the United States";
		Stack<char> charStack = new Stack<char>();
		
		for(int i = 0; i < originalString.Length; i++)
		{
			if(originalString[i].ToString() != " ")
			{
				charStack.Push(originalString[i]);
			}
			else
			{
				while(charStack.Count > 0)
				{
					Console.Write(charStack.Pop());
				}
				Console.Write(" ");
			}
		}
		
        //Included below logic as there will not be space after last word
		while(charStack.Count > 0)
		{
			Console.Write(charStack.Pop());
		}
	}
}