namespace _10102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int voteA = 0;
            int voteB = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A') voteA++;
                else voteB++;
            }

            Console.WriteLine(voteA == voteB ? "Tie" : voteA > voteB ? "A" : "B");
        }
    }
}
