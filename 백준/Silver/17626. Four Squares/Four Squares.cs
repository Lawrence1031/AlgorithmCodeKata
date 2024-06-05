namespace _17626
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (IsSquare(n))
            {
                Console.WriteLine(1);
                return;
            }

            for (int i = 1; i * i <= n; i++)
            {
                if (IsSquare(n - i * i))
                {
                    Console.WriteLine(2);
                    return;
                }
            }

            for (int i = 1; i * i <= n; i++)
            {
                for (int j = 1; j * j <= n - i * i; j++)
                {
                    if (IsSquare(n - i * i - j * j))
                    {
                        Console.WriteLine(3);
                        return;
                    }
                }
            }

            Console.WriteLine(4);
        }

        static bool IsSquare(int n)
        {
            int s = (int)Math.Sqrt(n);
            return s * s == n;
        }
    }
}