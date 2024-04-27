using System.Text;

namespace _11729
{
    internal class Program
    {
        static StringBuilder moves = new StringBuilder();
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int totalMoves = CalculateMoves(N);
            Console.WriteLine(totalMoves);

            Move(N, 1, 3, 2);

            Console.WriteLine(moves.ToString());
        }

        static int CalculateMoves(int n)
        {
            if (n == 1) 
                return 1;
            else
                return 2 * CalculateMoves(n - 1) + 1;
        }

        static void Move(int n, int from, int to, int via)
        {
            if (n == 1)
            {
                moves.AppendLine($"{from} {to}");
            }
            else
            {
                Move(n - 1, from, via, to);

                moves.AppendLine($"{from} {to}");

                Move(n - 1, via, to, from);
            }
        }
    }
}