using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
	class Program
	{
		private static string inputString;
		private static string resultString;

		static void Main(string[] args)
		{
			Console.Write("Enter the string: ");
			inputString = Console.ReadLine();

			StringManager stringManager = new StringManager(inputString);

			resultString = stringManager.ChooseWord();

			Console.WriteLine(String.Format("Your result: {0}",resultString));

			Console.ReadKey();

		}
	}
}
