namespace _21866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] maxScores = { 100, 100, 200, 200, 300, 300, 400, 400, 500 };

            bool isHacker = false;
            int totalScore = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > maxScores[i])
                {
                    isHacker = true;
                }

                totalScore += scores[i];
            }

            if (isHacker)
            {
                Console.WriteLine("hacker");
            }
            else if (totalScore >= 100)
            {
                Console.WriteLine("draw");
            }
            else
            {
                Console.WriteLine("none");
            }
        }
    }
}