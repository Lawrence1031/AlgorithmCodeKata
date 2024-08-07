namespace _10480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even");
                }
                else
                {
                    Console.WriteLine($"{num} is odd");
                }
            }
        }
    }
}