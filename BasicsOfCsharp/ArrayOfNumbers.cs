using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp
{
	class ArrayOfNumbers
	{
		//Array is collection of same data Type.

		int[] array = { 20, 56, 90, 32, 43, 89, 112 };
		public void Do()
		{
			// can't traverse in reverse order.
			//foreach (dataType item in array) {}
			foreach (int num in array)
			{
				Console.Write(num);
				Console.Write(" ");
			}
		}

	}
}

