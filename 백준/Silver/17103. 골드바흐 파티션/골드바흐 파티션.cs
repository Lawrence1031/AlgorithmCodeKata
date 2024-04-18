namespace _17103
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int maxValue = 1000000;
            bool[] isPrime = new bool[maxValue + 1];
            for (int i = 2; i <= maxValue; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= maxValue; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= maxValue; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int cnt = 0;

                for (int j = 2; j <= n / 2; j++)
                {
                    if (isPrime[j] && isPrime[n - j])
                    {
                        cnt++;
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}