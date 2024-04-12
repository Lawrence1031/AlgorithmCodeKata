namespace _18111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);

            int[,] heights = new int[N, M];
            int[] heightCnt = new int[257];

            for (int i = 0; i < N; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    heights[i, j] = int.Parse(inputs[j]);
                    heightCnt[heights[i, j]]++;
                }
            }

            int minTime = int.MaxValue;
            int bestHeight = 0;

            for (int h = 0; h <= 256; h++)
            {
                int removeBlocks = 0;
                int addBlocks = 0;
                for (int i = 0; i <= 256; i++)
                {
                    if (i < h)
                    {
                        addBlocks += (h - i) * heightCnt[i];
                    }
                    else if (i > h)
                    {
                        removeBlocks += (i - h) * heightCnt[i];
                    }
                }

                if (removeBlocks + B >= addBlocks)
                {
                    int curTime = addBlocks + 2 * removeBlocks;
                    if (curTime < minTime || (curTime == minTime && h > bestHeight))
                    {
                        minTime = curTime;
                        bestHeight = h;
                    }
                }
            }

            Console.WriteLine($"{minTime} {bestHeight}");
        }
    }
}