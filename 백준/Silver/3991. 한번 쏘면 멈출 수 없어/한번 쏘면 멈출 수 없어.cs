using System.Text;

namespace _3991
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int h = int.Parse(inputs[0]);
            int w = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);
            int[] marbles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            StringBuilder sb = new StringBuilder();

            int[,] board = new int[h, w];

            int color = 1;
            int idx = 0;

            for (int i = 0; i < h; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if (marbles[idx] > 0)
                        {
                            board[i, j] = color;
                            marbles[idx]--;
                        }
                        else
                        {
                            idx++;
                            color++;
                            board[i, j] = color;
                            marbles[idx]--;
                        }
                    }
                }
                else
                {
                    for (int j = w - 1; j >= 0; j--)
                    {
                        if (marbles[idx] > 0)
                        {
                            board[i, j] = color;
                            marbles[idx]--;
                        }
                        else
                        {
                            idx++;
                            color++;
                            board[i, j] = color;
                            marbles[idx]--;
                        }
                    }
                }
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sb.Append(board[i, j]);
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}