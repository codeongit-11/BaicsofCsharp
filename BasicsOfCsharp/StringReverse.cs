using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp
{
	class StringReverse
	{
		public void Do()
		{
			Console.WriteLine("Please enter a string to reverse");
			string input = Console.ReadLine();

			//string is collection of characters


			//for (initialization; execution; increment/decrement)
			//Mumbai => iabmuM =>
			//sart reading from index/char
			//store/append it in a seperate string
			//decrement index position

			string result = string.Empty;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				result = result + input[i];// i , ia ,iab, iabm , iabmu, iabmuM
			}
			Console.WriteLine(result);

		}
	}
}

