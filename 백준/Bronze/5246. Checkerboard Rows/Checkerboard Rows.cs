namespace _5246
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                int pieceCount = int.Parse(data[0]);

                int[] rowCounts = new int[9];

                for (int j = 1; j < data.Length - 1; j += 2)
                {
                    int col = int.Parse(data[j]);
                    int row = int.Parse(data[j + 1]);
                    rowCounts[row]++;
                }

                int maxPiece = 0;

                for (int row = 1; row <= 8; row++)
                {
                    if (rowCounts[row] > maxPiece)
                    {
                        maxPiece = rowCounts[row];
                    }
                }

                Console.WriteLine(maxPiece);
            }
        }
    }
}