namespace _1418
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            bool[] isPrime = new bool[N + 1];
            for (int i = 2; i <= N; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= N; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= N; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int cnt = 0;

            for (int i = 1; i <= N; i++)
            {
                int maxPrimeFactor = 1;
                int number = i;

                for (int j = 2; j * j <= number; j++)
                {
                    if (isPrime[j] && number % j == 0)
                    {
                        maxPrimeFactor = j;
                        while (number % j == 0)
                        {
                            number /= j;
                        }
                    }
                }

                if (number > 1)
                {
                    maxPrimeFactor = number;
                }

                if (maxPrimeFactor <= K)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}