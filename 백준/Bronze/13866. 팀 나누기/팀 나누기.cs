namespace _13866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] players = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(players);

            int answer = players[0] - players[1] - players[2] + players[3];
            Console.WriteLine(Math.Abs(answer));
        }
    }
}