using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;


namespace TDD.AssertStringAssert.Tests
{
    [TestClass]
    public class StringCheckTests
    {

        [TestMethod]
        public void CheckShortestWord_IfHaveShortestWord_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно!";
            // act
            // assert
            StringAssert.Contains("я", StringCheck.CheckShortestWord(input));
        }

        [TestMethod]
        public void CheckCountWords_IfHaveSomethingWord_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно!";
            // act
            // assert
            Assert.AreEqual(9, StringCheck.CheckCountWords(input));
        }

        [TestMethod]
        public void CheckCountChars_FindCountCharsInString_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно!";
            // act
            // assert
            Assert.AreEqual(52, StringCheck.CheckCountChars(input));
        }

        [TestMethod]
        public void CheckNineChar_FindNineCharInAString_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно!";
            // act
            // assert
            Assert.AreEqual('я', StringCheck.CheckNineChar(input));
        }

        [TestMethod]
        public void CheckCountDigits_CheckCountDigitsInAString_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно! 1174";
            // act
            // assert
            Assert.AreEqual(4, StringCheck.CheckCountDigits(input));
        }

        [TestMethod]
        public void CheckMaxDigitsInARow_MaxDigitsInAString_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно! 1174";
            // act
            // assert
            Assert.AreEqual(4, StringCheck.CheckMaxDigitsInARow(input));
        }

        [TestMethod]
        public void CheckCountAMCombinations_CountAMInAString_CorrectReturned()
        {
            // arrange
            string input = "Сегодня я вышел на прогулку, ведь это очень полезно! 1174 АМ АМ АМ";
            // act
            // assert
            Assert.AreEqual(3, StringCheck.CheckCountAMCombinations(input));
        }
    }
}
