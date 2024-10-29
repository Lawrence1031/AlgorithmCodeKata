namespace _15236
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double answer = 0;

            for (int i = 0; i <= n; i++)
            {
                answer += i * (n + 1 - i);
            }

            for (int i = n; i > 0; i--)
            {
                answer += i * (i + 1);
            }

            Console.WriteLine(answer);
        }
    }
}