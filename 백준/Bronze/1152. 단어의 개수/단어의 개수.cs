using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int length = ss.Length;
            foreach (string s2 in ss)
            {
                if (s2 == "")
                {
                    length--;
                }
            }
            Console.WriteLine(length);
        }
    }
}