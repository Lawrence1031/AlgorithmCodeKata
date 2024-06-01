namespace _1063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string king = inputs[0];
            string stone = inputs[1];
            int N = int.Parse(inputs[2]);

            int[] kingPos = { king[0] - 'A', king[1] - '1' };
            int[] stonePos = { stone[0] - 'A', stone[1] - '1' };

            Dictionary<string, int[]> moves = new Dictionary<string, int[]>
            {
                {"R" , new int[] {  1,  0 } },
                {"L" , new int[] { -1,  0 } },
                {"B" , new int[] {  0, -1 } },
                {"T" , new int[] {  0,  1 } },
                {"RT", new int[] {  1,  1 } },
                {"LT", new int[] { -1,  1 } },
                {"RB", new int[] {  1, -1 } },
                {"LB", new int[] { -1, -1 } },
            };

            for (int i = 0; i < N; i++)
            {
                string move = Console.ReadLine();

                int[] moveVector = moves[move];
                int newKingX = kingPos[0] + moveVector[0];
                int newKingY = kingPos[1] + moveVector[1];

                if (InBoard(newKingX, newKingY))
                {
                    if (newKingX == stonePos[0] && newKingY == stonePos[1])
                    {
                        int newStoneX = stonePos[0] + moveVector[0];
                        int newStoneY = stonePos[1] + moveVector[1];
                        if (InBoard(newStoneX, newStoneY))
                        {
                            kingPos[0] = newKingX;
                            kingPos[1] = newKingY;
                            stonePos[0] = newStoneX;
                            stonePos[1] = newStoneY;
                        }
                    }
                    else
                    {
                        kingPos[0] = newKingX;
                        kingPos[1] = newKingY;
                    }
                }
            }

            Console.WriteLine($"{(char)(kingPos[0] + 'A')}{kingPos[1] + 1}");
            Console.WriteLine($"{(char)(stonePos[0] + 'A')}{stonePos[1] + 1}");
        }

        static bool InBoard(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }
    }
}