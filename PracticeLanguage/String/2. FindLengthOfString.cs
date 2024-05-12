using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class FindLengthOfString
    {
        static void Main(string[] args)
        {
            string str;
            int count=0;
            Console.WriteLine("Input your String here!!");
            str = Console.ReadLine();

            foreach(char c in str)
            {
                count++;
            }

            Console.WriteLine($"Length of given string:{count}");
        }
    }
}
