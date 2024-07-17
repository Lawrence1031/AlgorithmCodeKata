namespace _3602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int b = int.Parse(inputs[0]);
            int w = int.Parse(inputs[1]);

            int low = 0;
            int high = (int)Math.Sqrt(b + w) + 1;

            while (low < high)
            {
                int mid = (low + high + 1) / 2;
                if (CanMakeBoard(mid, b, w) || CanMakeBoard2(mid, b, w))
                {
                    low = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }

            if (low == 0)
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                Console.WriteLine(low);
            }
        }

        static bool CanMakeBoard(int n, int b, int w)
        {
            int totalTiles = n * n;
            int blackNeeded = (totalTiles + 1) / 2;
            int whiteNeeded = totalTiles / 2;

            return b >= blackNeeded && w >= whiteNeeded;
        }
        static bool CanMakeBoard2(int n, int b, int w)
        {
            int totalTiles = n * n;
            int whiteNeeded = (totalTiles + 1) / 2;
            int blackNeeded = totalTiles / 2;

            return b >= blackNeeded && w >= whiteNeeded;
        }
    }
}