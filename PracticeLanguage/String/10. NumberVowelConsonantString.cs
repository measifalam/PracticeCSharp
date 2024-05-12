using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class NumberVowelConsonantString
    {
        static void Main(string[] args)
        {
            int Vowelcount = 0;
            int ConsoCount = 0;
            string str = Console.ReadLine();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'E'|| str[i] == 'I' || str[i] == 'O'|| str[i] == 'U'|| str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') 
                {
                    Vowelcount++;
                
                }
                else
                {
                    ConsoCount++;
                }
            }

            Console.WriteLine($"VowelCount:{Vowelcount}");
            Console.WriteLine($"ConsonentCount:{ConsoCount}");

        }
    }
}
