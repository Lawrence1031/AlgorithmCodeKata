namespace _2563
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] paper = new int[100, 100];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                int x = int.Parse(input.Split(' ')[0]);
                int y = int.Parse(input.Split(' ')[1]);

                for (int j = x; j < x + 10; j++)
                {
                    for (int k = y; k < y + 10; k++)
                    {
                        paper[j, k] = 1;
                    }
                }
            }

            int area = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (paper[i, j] == 1)
                    {
                        area++;
                    }
                }
            }

            Console.WriteLine(area);
        }
    }
}