using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
	public class StringManager
	{
		private string inputString = String.Empty;
		private StringBuilder outputString = new StringBuilder();
		private List<string> invertedWordList = new List<string>();		

		public StringManager(string inputValue)
		{
			inputString = inputValue;
		}

		public string ChooseWord()
		{
			int i = 0;

			if ((String.IsNullOrEmpty(inputString))||(inputString.Replace(" ", "").Length == 0))
				return inputString;

			for (int j = 0; j < InputMassSplitString.Length; j++)
			{		
				if (InputMassSplitString[j].Length > 0)
				{
					string invertedWord = TurnOverWord(InputMassSplitString[j]);
					invertedWordList.Add(invertedWord);
				}
			}

			while (i < inputString.Length)
			{
				if (inputString[i] == ' ')
				{
					outputString.Append(' ');
					i++;
				}
				else
				{			
					outputString.Append(invertedWordList[0]);
					i += invertedWordList[0].Length;
					invertedWordList.RemoveAt(0);
				}
			}
			return outputString.ToString();
		}

		
		public string TurnOverWord(string rawWord)
		{		
			StringBuilder rawInverted = new StringBuilder();
			StringBuilder rawInvertedNew = new StringBuilder();

			for (int i = 0; i < rawWord.Length; i++)
			{
				rawInverted.Append(rawWord[rawWord.Length - 1 - i]);
			}

			for (int i = 0; i < rawWord.Length; i++)
			{

				if (!char.IsLetter(rawWord[i]))
				{
					rawInverted.Replace(rawWord[i].ToString(), "");
				}

			}

			for (int i = 0; i < rawWord.Length; i++)
			{

				if (!char.IsLetter(rawWord[i]))
				{
					rawInvertedNew.Append(rawWord[i]);
				}
				else
				{
					rawInvertedNew.Append(rawInverted[0]);
					rawInverted = rawInverted.Remove(0, 1);
				}
				
			}
				return rawInvertedNew.ToString();
		}
	public string[] InputMassSplitString 
		{
			get 
			{
				return inputString.Split(' ');
			}
		}		
	}
}
