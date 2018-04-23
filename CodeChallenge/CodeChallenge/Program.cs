using System;

namespace CodeChallenge
{
	class Program
	{
		static void Main(string[] args)
		{
			string a, backwards = "";
			Console.WriteLine(" Enter string");
			a = Console.ReadLine();

			// create the string backwards
			for (int i = a.Length - 1; i >= 0; i--) 
			{
				backwards += a[i].ToString();
			}
			// check to see if its a palindrome
			if (backwards == a) 
			{
				Console.WriteLine("String is Palindrome \n Entered String Was {0} and backward string is {1}", a, backwards);
			}
			else
			{
				Console.WriteLine("String is not Palindrome \n Entered String Was {0} and backward string is {1}", a, backwards);
			}
			Console.ReadKey();
		}
	}
}