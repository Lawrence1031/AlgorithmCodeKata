using System.Text;

namespace _1213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> alp = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (alp.ContainsKey(input[i]))
                {
                    alp[input[i]]++;
                }
                else
                {
                    alp.Add(input[i], 1);
                }
            }

            int oddCnt = 0;
            char middleChar = '\0';
            List<char> halfPalin = new List<char>();

            foreach (var item in alp)
            {
                if (item.Value % 2 != 0)
                {
                    oddCnt++;
                    middleChar = item.Key;
                }

                for (int i = 0; i < item.Value / 2; i++)
                {
                    halfPalin.Add(item.Key);
                }
            }

            if (oddCnt > 1)
            {
                Console.WriteLine("I'm Sorry Hansoo");
                return;
            }

            halfPalin.Sort();
            string firstHalf = new string(halfPalin.ToArray());
            string secondHalf = new string(halfPalin.ToArray().Reverse().ToArray());

            string palin = oddCnt == 1 ? firstHalf + middleChar + secondHalf : firstHalf + secondHalf;
            Console.WriteLine(palin);
        }
    }
}