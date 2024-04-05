namespace _11050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = Convert.ToInt32(s.Split(' ')[0]);
            int K = Convert.ToInt32(s.Split(' ')[1]);
            int answer = Factorial(N) / Factorial(K) / Factorial(N - K);
            Console.WriteLine(answer);

        }

        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = n; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}