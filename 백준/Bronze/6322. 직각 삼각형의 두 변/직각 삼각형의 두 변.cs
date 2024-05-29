namespace _6322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input[0] == '0')
                {
                    return;
                }

                int a = int.Parse(input.Split(' ')[0]);
                int b = int.Parse(input.Split(' ')[1]);
                int c = int.Parse(input.Split(' ')[2]);
                string answer = "";

                Console.WriteLine($"Triangle #{cnt}");                
                if (a == -1)
                {
                    if (c * c - b * b > 0)
                    {
                        double result = (Math.Sqrt(c * c - b * b));
                        answer = result.ToString("F3");
                        Console.WriteLine($"a = {answer}");
                    }
                    else
                    {
                        Console.WriteLine("Impossible.");
                    }
                }
                else if (b == -1)
                {
                    if (c * c - a * a > 0)
                    {
                        double result = (Math.Sqrt(c * c - a * a));
                        answer = result.ToString("F3");
                        Console.WriteLine($"b = {answer}");
                    }
                    else
                    {
                        Console.WriteLine("Impossible.");
                    }
                }
                else
                {
                    double result = (Math.Sqrt(a * a + b * b));
                    answer = result.ToString("F3");
                    Console.WriteLine($"c = {answer}");
                }
                Console.WriteLine();

                cnt++;
            }
        }
    }
}