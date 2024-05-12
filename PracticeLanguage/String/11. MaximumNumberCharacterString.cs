using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLanguage.String
{
    internal class MaximumNumberCharacterString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string count = "";            

            Dictionary<char, int> myDict = new Dictionary<char, int>();
            foreach(char ch in str)
            {
                if(myDict.ContainsKey(ch))
                {
                    myDict[ch] = myDict[ch] + 1;
                }
                else
                {
                    myDict[ch] = 1;
                }
            }
            // Print each key-value pair separately
            foreach (var kvp in myDict)
            {
                Console.WriteLine($"{kvp.Key} :: {kvp.Value}");
            }
        }
    }
}
