namespace _20436
{
    internal class Program
    {
        static Dictionary<char, (int, int)> keyboard = new Dictionary<char, (int, int)>
        {
            {'q', (0, 0)}, {'w', (0, 1)}, {'e', (0, 2)}, {'r', (0, 3)}, {'t', (0, 4)}, {'y', (0, 5)}, {'u', (0, 6)}, {'i', (0, 7)}, {'o', (0, 8)}, {'p', (0, 9)},
            {'a', (1, 0)}, {'s', (1, 1)}, {'d', (1, 2)}, {'f', (1, 3)}, {'g', (1, 4)}, {'h', (1, 5)}, {'j', (1, 6)}, {'k', (1, 7)}, {'l', (1, 8)},
            {'z', (2, 0)}, {'x', (2, 1)}, {'c', (2, 2)}, {'v', (2, 3)}, {'b', (2, 4)}, {'n', (2, 5)}, {'m', (2, 6)}
        };

        static HashSet<char> leftKeys = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'a', 's', 'd', 'f', 'g', 'z', 'x', 'c', 'v' };

        static void Main(string[] args)
        {
            string[] startPos = Console.ReadLine().Split(' ');
            string input = Console.ReadLine();

            char leftPos = startPos[0][0];
            char rightPos = startPos[1][0];

            int time = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (leftKeys.Contains(input[i]))
                {
                    time += MovePos(ref leftPos, input[i]);
                }
                else
                {
                    time += MovePos(ref rightPos, input[i]);
                }
            }

            Console.WriteLine(time);
        }

        private static int MovePos(ref char pos, char target)
        {
            var (curX, curY) = keyboard[pos];
            var (targetX, targetY) = keyboard[target];

            int distance = Math.Abs(curX - targetX) + Math.Abs(curY - targetY) + 1;

            pos = target;
            return distance;
        }
    }
}