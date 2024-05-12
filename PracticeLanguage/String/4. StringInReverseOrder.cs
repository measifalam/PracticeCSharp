using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class StringInReverseOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input String Please");
            string str = Console.ReadLine();
            for(int i = str.Length-1;i>=0;i--)
            {
                Console.Write(str[i]);
            }
            
        }
    }
}
