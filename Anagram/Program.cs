using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Anagram
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            Console.WriteLine(ReverseString(inputStr));
        }

        public static string ReverseString(string inputStr)
        {
            string[] splitedWords = inputStr.Split(" ");
            List<string> reversedWords = new List<string>();

            for (int i = 0; i < splitedWords.Length; i++)
            {
                char[] charsArray = splitedWords[i].ToCharArray();

                int r = charsArray.Length - 1;
                int l = 0;
                while (l < r)
                {
                    if (!char.IsLetter(charsArray[l]))
                        l++;
                    else if (!char.IsLetter(charsArray[r]))
                        r--;
                    else
                    {
                        char tmp = charsArray[l];
                        charsArray[l] = charsArray[r];
                        charsArray[r] = tmp;
                        l++;
                        r--;
                    }
                }
                reversedWords.Add(new string(charsArray));
            }
            var reversedString = string.Join(" ", reversedWords);

            return reversedString;
        }
    }
}