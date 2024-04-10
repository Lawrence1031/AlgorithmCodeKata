namespace _2578
{
    internal class Program
    {
        static int[,] bingo = new int[5, 5];
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    bingo[i, j] = int.Parse(input[j]);
                }
            }

            int cnt = 0;
            for (int i = 0; i < 5; i++)
            {
                string[] calls = Console.ReadLine().Split(' ');

                foreach (string call in calls)
                {
                    cnt++;
                    int number = int.Parse(call);
                    MarkNumber(number);

                    if (CheckLines() >= 3)
                    {
                        Console.WriteLine(cnt);
                        return;
                    }
                }
            }
        }
        static void MarkNumber(int number)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bingo[i, j] == number)
                    {
                        bingo[i, j] = 0;
                        return;
                    }
                }
            }
        }

        static int CheckLines()
        {
            int lineCnt = 0;

            for (int i = 0; i < 5; i++)
            {
                bool rowBingo = true;
                bool colBingo = true;

                for (int j = 0; j < 5; j++)
                {
                    if (bingo[i, j] != 0)
                    {
                        rowBingo = false;
                    }
                    if (bingo[j, i] != 0)
                    {
                        colBingo = false;
                    }
                }
                if (rowBingo)
                {
                    lineCnt++;
                }
                if (colBingo)
                {
                    lineCnt++;
                }
            }
            bool diag1Bing = true;
            bool diag2Bing = true;

            for (int i = 0; i < 5; i++)
            {
                if (bingo[i, i] != 0)
                {
                    diag1Bing = false;
                }
                if (bingo[i, 4 - i] != 0)
                {
                    diag2Bing= false;
                }
            }
            if (diag1Bing)
            {
                lineCnt++;
            }
            if (diag2Bing)
            {
                lineCnt++;
            }

            return lineCnt;
        }
    }
}