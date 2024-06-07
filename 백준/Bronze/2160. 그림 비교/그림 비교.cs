namespace _2160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[,] pictures = new string[N, 5];

            for (int i = 0; i < N * 5; i++)
            {
                int pictureIdx = i / 5;
                int lineIdx = i % 5;
                pictures[pictureIdx, lineIdx] = Console.ReadLine();
            }

            int minDiff = int.MaxValue;
            int picture1 = 0;
            int picture2 = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    int diff = ComparePictures(pictures, i, j);
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        picture1 = i + 1;
                        picture2 = j + 1;
                    }
                }
            }

            Console.WriteLine($"{picture1} {picture2}");
        }

        static int ComparePictures(string[,] pictures, int i, int j)
        {
            int diff = 0;
            for (int line = 0; line < 5; line++)
            {
                string picture1Line = pictures[i, line];
                string picture2Line = pictures[j, line];
                for (int k = 0; k < 7; k++)
                {
                    if (picture1Line[k] != picture2Line[k])
                    {
                        diff++;
                    }
                }
            }

            return diff;
        }
    }
}