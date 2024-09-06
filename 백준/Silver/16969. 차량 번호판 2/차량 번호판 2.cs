namespace _16969
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long result = 1;
            char prev = ' ';

            foreach (char c in input)
            {
                if (c == 'c')
                {
                    if (prev == 'c')
                    {
                        result *= 25;
                    }
                    else
                    {
                        result *= 26;
                    }
                    result %= 1000000009;
                    prev = c;
                }
                else if (c == 'd')
                {
                    if (prev == 'd')
                    {
                        result *= 9;
                    }
                    else
                    {
                        result *= 10;
                    }
                    result %= 1000000009;
                    prev = 'd';
                }
            }

            Console.WriteLine(result);
        }
    }
}