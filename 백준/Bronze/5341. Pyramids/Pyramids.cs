namespace _5341
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }

                Console.WriteLine(n * (n + 1) / 2);
            }
        }
    }
}