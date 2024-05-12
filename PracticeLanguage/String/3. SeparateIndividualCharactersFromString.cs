using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class SeparateIndividualCharactersFromString
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Give your inputs here!!");
            str = Console.ReadLine();
            char[] chArray = new char[str.Length*2];

            for (int i = 0; i < str.Length; i++)
            {
                chArray[i*2]= str[i];
                chArray[i*2+1] = ' ';
            }
            Console.WriteLine(chArray);
        }
    }
}
