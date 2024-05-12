using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class SortStringArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of stringArray");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine($"length:{len}");
            string[] StrArray = new string[len];
            
            
            Console.WriteLine("Input your strings nows!!");
            for (int i = 0; i < len; i++)
            {
                StrArray[i] = Console.ReadLine();
            }

            foreach(string str in StrArray)
            {
                Console.WriteLine(str);
            }
            
        }
    }
}
