namespace _23348
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = int.Parse(Console.ReadLine());
            int[] ratings = new int[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int[] nowScores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    ratings[i] += scores[0] * nowScores[0] + scores[1] * nowScores[1]
                                  + scores[2] * nowScores[2];
                }
            }

            Console.WriteLine(ratings.Max());
        }
    }
}