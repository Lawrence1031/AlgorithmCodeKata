namespace _1783
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);  // 세로
            int M = int.Parse(inputs[1]);  // 가로

            int maxMoves = 0;

            if (N == 1)
            {
                maxMoves = 1;
            }
            else if (N == 2)
            {
                maxMoves = Math.Min(4, (M + 1) / 2);
            }
            else
            {
                if (M < 7)
                {
                    maxMoves = Math.Min(4, M);
                }
                else
                {
                    maxMoves = M - 2;
                }
            }

            Console.WriteLine(maxMoves);
        }
    }
}