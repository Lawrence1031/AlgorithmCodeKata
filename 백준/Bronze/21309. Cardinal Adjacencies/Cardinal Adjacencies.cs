namespace _21309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);

            int[,] grid = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = int.Parse(row[j]);
                }
            }

            int fourDirectionCnt = 0;
            int eightDirectionCnt = 0;

            int[] dRow = { -1, 1, 0, 0, -1, -1, 1, 1 };
            int[] dCol = { 0, 0, -1, 1, -1, 1, -1, 1 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            int newRow = i + dRow[k];
                            int newCol = j + dCol[k];

                            if (newRow >= 0 && newRow < rows && 
                                newCol >= 0 && newCol < cols && 
                                grid[newRow, newCol] == 1)
                            {
                                if (k < 4)
                                {
                                    fourDirectionCnt++;
                                }
                                eightDirectionCnt++;
                            }
                        }
                    }
                }
            }

            fourDirectionCnt /= 2;
            eightDirectionCnt /= 2;

            Console.WriteLine($"{fourDirectionCnt} {eightDirectionCnt}");
        }
    }
}