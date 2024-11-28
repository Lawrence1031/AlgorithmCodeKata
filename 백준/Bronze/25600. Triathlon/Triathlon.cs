namespace _25600
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int bestScore = 0;

            for (int i = 0; i < N; i++)
            {
                int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int a = scores[0];
                int d = scores[1];
                int g = scores[2];

                int score = a * (d + g);
                if (a == (d + g)) score *= 2;

                if (score > bestScore) bestScore = score;
            }

            Console.WriteLine(bestScore);
        }
    }
}