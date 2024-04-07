using System.Collections.Generic;
using System.Text;

namespace _10816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nArr = Console.ReadLine().Split(' ');
            Dictionary<string, int> nDict = new Dictionary<string, int>();

            foreach (var num in nArr)
            {
                if (nDict.ContainsKey(num))
                {
                    nDict[num]++;
                }
                else
                {
                    nDict[num] = 1;
                }
            }

            int M = int.Parse(Console.ReadLine());
            string[] mArr = Console.ReadLine().Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (var item in mArr)
            {
                if (nDict.ContainsKey(item))
                {
                    sb.Append(nDict[item] + " ");
                }
                else
                {
                    sb.Append("0 ");
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}