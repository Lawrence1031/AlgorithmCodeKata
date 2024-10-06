namespace _16462
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] scores = new int[N];
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                string scoreText = "";
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '0' || input[j] == '6')
                    {
                        scoreText += '9';
                    }
                    else
                    {
                        scoreText += input[j];
                    }
                }

                int score = int.Parse(scoreText) > 100 ? 100 : int.Parse(scoreText);
                scores[i] = score;
            }

            double average = (double)scores.Sum() / N;
            average = Math.Round(average, MidpointRounding.AwayFromZero);
            Console.WriteLine(average);
        }
    }
}