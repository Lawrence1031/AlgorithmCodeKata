namespace _9094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int n = int.Parse(inputs[0]);
                int m = int.Parse(inputs[1]);

                int cnt = 0;

                for (int a = 1; a < n; a++)
                {
                    for (int b = a + 1; b < n; b++)
                    {
                        if ((a * a + b * b + m) % (a * b) == 0)
                        {
                            cnt++;
                        }
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}