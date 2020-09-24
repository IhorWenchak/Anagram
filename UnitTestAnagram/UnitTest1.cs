using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace UnitTestAnagram
{
	[TestClass]
	public class UnitTest1
	{
		
		[TestMethod]
		public void Test_TurnOverWord()
		{
			string str = "f1gh";
			string expected = "h1gf";
			
			StringManager sm = new StringManager("f1gh dsa2");

			string result = sm.TurnOverWord(str);

			Assert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void Reverse_CharIsLetter_CharsSwapped()
		{
			StringManager sm = new StringManager("ab");
			Assert.AreEqual("ba", sm.ChooseWord());
		}

		[TestMethod]
		public void Reverse_CharIsNotLetter_CharsNotSwapped()
		{
			StringManager sm = new StringManager("#1");
			Assert.AreEqual("#1", sm.ChooseWord());
		}

		[TestMethod()]
		public void NullTest()
		{
			string input = null;
			string expected = null;
			
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();

			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void EmptyTest()
		{
			var input = string.Empty;
			var expected = string.Empty;
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void SpaceManyTest()
		{
			var input = "     ";
			var expected = "     ";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void ABCDTest()
		{
			var input = "abcd";
			var expected = "dcba";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}


		[TestMethod()]
		public void SpaceOneBeforeTest()
		{
			var input = " abc";
			var expected = " cba";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void SpaceManyBeforeTest()
		{
			var input = "    abc";
			var expected = "    cba";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void SpaceOneAfterBeforeTest()
		{
			var input = "abc ";
			var expected = "cba ";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void TwoWordsTest()
		{
			var input = "abc abcd";
			var expected = "cba dcba";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void TwoWordsWithManySpaceTest()
		{
			var input = "abc   abcd";
			var expected = "cba   dcba";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

		[TestMethod()]
		public void Test_SwapWords_Test1()
		{
			var input = "a1bcd efg!h";
			var expected = "d1cba hgf!e";
			StringManager sm = new StringManager(input);
			var actual = sm.ChooseWord();
			Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
		}

	}
}
