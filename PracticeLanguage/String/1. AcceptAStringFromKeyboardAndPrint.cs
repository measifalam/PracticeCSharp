using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class AcceptAStringFromKeyboardAndPrint
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Input your String Here");
            str = Console.ReadLine();
            if (str == null)
            {
                Console.WriteLine($"Input : {str}");
            }
        }
    }
}
