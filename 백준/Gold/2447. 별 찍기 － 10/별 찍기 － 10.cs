using System.Text;

namespace _2447
{
    public class StarPattern
    {
        static StringBuilder sb = new StringBuilder();
        public static void CreateStarPattern(char[,] pattern, int size, int x, int y)
        {
            if (size == 1)
            {
                pattern[x, y] = '*';
                return;
            }

            int subSize = size / 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        FillSpace(pattern, subSize, x + i * subSize, y + j * subSize);
                    }
                    else
                    {
                        CreateStarPattern(pattern, subSize, x + i * subSize, y + j * subSize);
                    }
                }
            }
        }

        public static void FillSpace(char[,] pattern, int size, int StartX, int StartY)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pattern[StartX + i, StartY + j] = ' ';
                }
            }
        }

        public static void PrintPattern(char[,] pattern, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sb.Append(pattern[i, j]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] pattern = new char[N, N];

            StarPattern.CreateStarPattern(pattern, N, 0, 0);
            StarPattern.PrintPattern(pattern, N);
        }
    }
}