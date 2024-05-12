using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class CompareTwoString
    {
        static void Main(string[] args)
        {
            bool result = true;
            Console.WriteLine("input String1");
            string str1 = Console.ReadLine();
            Console.WriteLine("input String2");
            string str2 = Console.ReadLine();
            if(str1.Length!=str2.Length)
            {
                result = false;
            }
            else
            {
                for(int i=0; i<str1.Length; i++)
                {
                    if (str1[i] != str2[i]) 
                    { 
                        result = false;
                    }
                }
            }

            if(result)
            {
                Console.WriteLine("Equal String");
            }
            else
            { Console.WriteLine("Unequal String"); }


        }
    }
}
