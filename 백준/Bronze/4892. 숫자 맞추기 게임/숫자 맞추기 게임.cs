namespace _4892
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n1 = 3 * n0
            // n2 = n1 / 2 (홀수라면 n2 = (n1 + 1) / 2)
            // n3 = 3 * n3
            // n4 = n3 / 9
            // n1이 짝수 -> n0 = 2 * n4
            // n1이 홀수 -> n0 = 2 * n4 + 1

            int cnt = 1;

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int answer = 0;

                if (n == 0)
                {
                    return;
                }

                if (n % 2 == 1)
                {
                    answer = (3 * n + 1) / 6;
                    Console.WriteLine($"{cnt}. odd {answer}");
                }
                else
                {
                    answer = n / 2;
                    Console.WriteLine($"{cnt}. even {answer}");
                }

                cnt++;
            }
        }
    }
}