using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.AssertStringAssert
{
    public class StringCheck
    {
        public static string CheckShortestWord(string input)
        {
            return input.Split(' ').OrderBy(word => word.Length).First();
        }

        public static int CheckCountWords(string input)
        {
            return input.Split(' ').Length;
        }

        public static int CheckCountChars(string input)
        {
            return input.Length;
        }

        public static char CheckNineChar(string input)
        {
            return input[8];
        }

        public static int CheckCountDigits(string input)
        {
            return input.Count(char.IsDigit);
        }

        public static int CheckMaxDigitsInARow(string input)
        {
            int maxCount = 0, currentCount = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        public static int CheckCountAMCombinations(string input)
        {
            return (input.Length - input.Replace("АМ", "").Length) / 2;
        }
    }
}
