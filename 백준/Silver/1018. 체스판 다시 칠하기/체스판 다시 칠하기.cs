namespace _1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = Convert.ToInt32(s.Split(' ')[0]);
            int M = Convert.ToInt32(s.Split(' ')[1]);
            string[] board = new string[N];

            for (int i = 0; i < N; i++)
            {
                board[i] = Console.ReadLine();
            }

            int minChangeCnt = int.MaxValue;

            for (int row = 0; row <= N - 8; row++)
            {
                for (int col = 0; col <= M - 8; col++)
                {
                    int changeCntW = 0;
                    int changeCntB = 0;

                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                if (board[row + i][col + j] != 'W')
                                {
                                    changeCntW++;
                                }
                                if (board[row + i][col + j] != 'B')
                                {
                                    changeCntB++;
                                }
                            }
                            else
                            {
                                if (board[row + i][col + j] != 'B')
                                {
                                    changeCntW++;
                                }
                                if (board[row + i][col + j] != 'W')
                                {
                                    changeCntB++;
                                }
                            }
                        }
                    }

                    int minChange = Math.Min(changeCntW, changeCntB);
                    minChangeCnt = Math.Min(minChangeCnt, minChange);
                }
            }

            Console.WriteLine(minChangeCnt);
        }
    }
}