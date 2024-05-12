using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class NumberOfWordsInString
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Input String here!!");
            string str = Console.ReadLine();
            for (int i = 0;i<str.Length;i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

    }
}
