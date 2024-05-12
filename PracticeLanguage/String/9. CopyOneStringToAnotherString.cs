using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class CopyOneStringToAnotherString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string myStr="";
            for (int i = 0;i< str.Length;i++)
            {
                myStr += str[i];
            }

            Console.WriteLine($"Copied String: {myStr}");
        }
    }
}
