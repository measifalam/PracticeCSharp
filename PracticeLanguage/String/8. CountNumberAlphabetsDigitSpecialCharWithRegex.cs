using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class CountNumberAlphabetsDigitSpecialCharWithRegex
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            int alphCount = Regex.Matches(str,"[a-zA-z]").Count();
            int digitCount =Regex.Matches(str, "\\d").Count();
            int spChar = str.Length-alphCount-digitCount;

            Console.WriteLine($"No of Alphabets:{alphCount},No of Digits:{digitCount},No of SpecialChar:{spChar}");
        }
    }
}
