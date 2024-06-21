namespace _2553
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long number = 1;
            for (int i = 1; i <= n; i++)
            {
                number *= i;

                while (number % 10 == 0)
                {
                    number /= 10;
                }

                number %= 100000000;
            }

            int answer =  (int)number % 10;


            Console.WriteLine(answer);
        }
    }
}