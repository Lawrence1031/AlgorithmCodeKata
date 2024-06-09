namespace _1788
{
    internal class Program
    {
        static Dictionary<int, long> positiveFibo = new Dictionary<int, long>();
        static Dictionary<int, long> negativeFibo = new Dictionary<int, long>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long answer = 0;
            if (n > 0)
            {
                answer = posiFibo(n);
                Console.WriteLine(1);
                Console.WriteLine(answer);
            }
            else if (n == 0)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                answer = negaFibo(n);
                Console.WriteLine(answer > 0 ? 1 : -1);
                Console.WriteLine(Math.Abs(answer));
            }
        }

        static long posiFibo(int n)
        {
            positiveFibo[0] = 0;
            positiveFibo[1] = 1;
            int cnt = 2;

            while (!positiveFibo.ContainsKey(n))
            {
                positiveFibo[cnt] = (positiveFibo[cnt - 1] + positiveFibo[cnt - 2]) % 1000000000;
                cnt++;
            }

            return positiveFibo[n];
        }

        static long negaFibo(int n)
        {
            negativeFibo[0] = 0;
            negativeFibo[1] = 1;
            int cnt = -1;

            while (!negativeFibo.ContainsKey(n))
            {
                negativeFibo[cnt] = (negativeFibo[cnt + 2] - negativeFibo[cnt + 1])% 1000000000;
                cnt--;
            }

            return negativeFibo[n];
        }
    }
}