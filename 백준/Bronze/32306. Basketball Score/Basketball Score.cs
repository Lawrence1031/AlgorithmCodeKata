namespace _32306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] team1Shoots = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] team2Shoots = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int team1 = team1Shoots[0] + 2 * team1Shoots[1] + 3 * team1Shoots[2];
            int team2 = team2Shoots[0] + 2 * team2Shoots[1] + 3 * team2Shoots[2];

            Console.WriteLine(team1 > team2 ? 1 : team1 == team2 ? 0 : 2);
        }
    }
}