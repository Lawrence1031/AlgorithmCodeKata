namespace _15351
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                string result = LifeScore(input);
                Console.WriteLine(result);
            }
        }

        static string LifeScore(string input)
        {
            int score = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    score += input[i] - 'A' + 1;
                }
            }

            if (score == 100)
            {
                return "PERFECT LIFE";
            }
            else
            {
                return score.ToString();
            }
        }
    }
}