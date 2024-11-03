namespace _4459
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            string[] quotes = new string[q];
            for (int i = 0; i < q; i++)
            {
                quotes[i] = Console.ReadLine();
            }

            int r = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n - 1 < q && n > 0)
                {
                    Console.WriteLine($"Rule {n}: {quotes[n - 1]}");
                }
                else
                {
                    Console.WriteLine($"Rule {n}: No such rule");
                }
            }
        }
    }
}