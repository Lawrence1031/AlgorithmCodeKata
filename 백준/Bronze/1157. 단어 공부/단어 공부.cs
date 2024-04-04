using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();

            Dictionary<char, int> map = new Dictionary<char, int>();

            s = s.ToUpper();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map.Add(s[i], 1);
                }
            }

            int maxCnt = 0;
            char maxKey = ' ';
            bool isDuplicate = false;

            foreach (var item in map)
            {
                if (item.Value > maxCnt)
                {
                    maxCnt = item.Value;
                    maxKey = item.Key;
                    isDuplicate = false;
                }
                else if (item.Value == maxCnt)
                {
                    isDuplicate = true;
                }
            }

            if (isDuplicate)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(maxKey);
            }
        }
    }
}