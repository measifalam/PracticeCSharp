using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class CountNumberAlphabetsDigitSpecialChar
    {
        static void Main(string[] args)
        {
            int alpha = 0;
            int digit = 0;
            int spChar = 0;
            Console.WriteLine("Enter your string here!!");
            string str = Console.ReadLine();
            for (int i = 0;str.Length > i;i++)
            {
                if ((str[i]>='a' && str[i]<='z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alpha++;
                }

               else if (str[i]>'0' && str[i]<'9')
                {
                    digit++;
                }
                else
                {
                    spChar++;
                }
            }
            Console.WriteLine($"Special Char: {spChar} || AlphaCount : {alpha} || Digit :{digit}");
        }
    }
}
