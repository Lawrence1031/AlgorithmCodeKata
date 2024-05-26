using System.Collections.Immutable;

namespace _1059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            int[] S = new int[L];

            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < L; i++)
            {
                S[i] = int.Parse(inputs[i]);
            }

            int n = int.Parse(Console.ReadLine());

            if (S.Contains(n))
            {
                Console.WriteLine(0);
                return;
            }

            Array.Sort(S);

            int lowerlawer = 0;
            int upperlawer = 1001;

            foreach (int number in S)
            {
                if (number < n)
                {
                    lowerlawer = number;
                }
                else if (number > n)
                {
                    upperlawer = number;
                    break;
                }
            }

            int cnt = 0;
            for (int A = lowerlawer + 1; A <= n; A++)
            {
                for (int B = n; B < upperlawer; B++)
                {
                    if (A < B)
                    {
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}