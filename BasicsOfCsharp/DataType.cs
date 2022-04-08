using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCsharp
{
	class DataTypes
	{
		public void Do()
		{
			//Numerical
			//32Byte
			//struct,not a class
			int num1 = 100;
			Console.WriteLine(num1);

			//64 byte or 8 byte
			long num2 = 67943875;
			Console.WriteLine(num2);

			//precision based values -32 bytes or 4 byte

			float num3 = 100.01F;
			Console.WriteLine(num3);

			//64 bytes or 8 byte
			double num4 = 3456784567.56;
			Console.WriteLine(num4);

			//128 bytes or 16 byte
			//decklaring a variable 
			//datatype nameOfvariable = valueOfvariable

			decimal num5 = 34567834345.78M;

			//calling a static method
			//Classname.Methodname(<params>);
			Console.WriteLine(num5);

			//Alphanumeric
			char ch = 'C';
			Console.WriteLine(ch);

			//string is a class/reference type . String is immutable.
			string str = "My name";
			Console.WriteLine(str);

			//boolean values (true, false)
			bool isTrue = true;
			Console.WriteLine(isTrue);

		}
	}

}

