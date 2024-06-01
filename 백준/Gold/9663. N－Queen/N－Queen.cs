namespace _1560
{
    internal class Program
    {
        static int[] board;
        static int answer;
        static int size;

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            answer = 0;
            size = N;
            board = new int[N];
            SolveNQueen(0);
            Console.WriteLine(answer);
        }

        static bool IsSafe(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                {
                    return false;
                }
            }
            return true;
        }

        static void SolveNQueen(int row)
        {
            if (row == size)
            {
                answer++;
                return;
            }

            for (int col = 0; col < size; col++)
            {
                if (IsSafe(row, col))
                {
                    board[row] = col;
                    SolveNQueen(row + 1);
                }
            }
        }
    }
}