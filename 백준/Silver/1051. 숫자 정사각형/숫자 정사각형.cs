namespace _1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            char[][] matrix = new char[N][];
            for (int i = 0; i < N; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int maxSize = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    char curChar = matrix[i][j];
                    for (int size = 1; size < Math.Min(N - i, M - j); size++)
                    {
                        if (matrix[i][j + size] == curChar &&
                            matrix[i + size][j] == curChar &&
                            matrix[i + size][j + size] == curChar)
                        {
                            int squareSize = (size + 1) * (size + 1);
                            if (squareSize > maxSize)
                            {
                                maxSize = squareSize;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(maxSize);
        }
    }
}