namespace _5217
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                List<string> pairs = new List<string>();

                for (int j = 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (j + k == n)
                        {
                            pairs.Add($"{j} {k}");
                        }
                    }
                }

                Console.Write($"Pairs for {n}: ");
                Console.WriteLine(string.Join(", ", pairs));
            }
        }
    }
}