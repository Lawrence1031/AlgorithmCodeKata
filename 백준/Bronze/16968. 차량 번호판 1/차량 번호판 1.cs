namespace _16968
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 1;
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
                    prev = 'd';
                }
            }

            Console.WriteLine(result);
        }
    }
}