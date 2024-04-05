namespace _2231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int M = N - 9 * N.ToString().Length;
            int answer = 0;

            for (int i = M; i < N; i++)
            {
                int sum = 0;
                int num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (i + sum == N)
                {
                    answer = i;
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}