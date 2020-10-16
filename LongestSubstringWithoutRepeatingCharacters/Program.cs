using System;
using System.Collections;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] myStringArray = {
                "abcabcbb",
                "bbbbb",
                "pwwkew",
                "",
                " " };
            foreach (var s in myStringArray)
            {
                Console.WriteLine(LengthOfLongestSubstring(s));
            }
            Console.WriteLine("3,1,3,0,1");
        }
        public static int LengthOfLongestSubstring(string s)
        {
            List<char> res = new List<char>();
            int result = 0;
            foreach(char currenrChar in s)
            {
                    if (res.Contains(currenrChar))
                    {
                        res.RemoveRange(0,res.IndexOf(currenrChar) +1);
                    }
                res.Add(currenrChar);
                if (result < res.Count)
                {
                    result = res.Count;
                }
            }
            return result;
        }
    }
}
