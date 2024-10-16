namespace _18238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char startPos = 'A';
            int time = 0;

            for (int i = 0; i < input.Length; i++)
            {
                time += MovePos(ref startPos, input[i]);
            }

            Console.WriteLine(time);
        }

        static int MovePos(ref char Pos, char target)
        {
            int movement = Math.Abs(Pos - target);
            int moveTime = movement < 13 ? movement : 26 - movement;

            Pos = target;
            return moveTime;
        }
    }
}