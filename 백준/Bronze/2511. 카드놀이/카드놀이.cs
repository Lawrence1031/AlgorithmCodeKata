namespace _2511
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ACards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] BCards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int AScore = 0;
            int BScore = 0;
            char lastWinner = 'D';

            for (int i = 0; i < ACards.Length; i++)
            {
                if (ACards[i] > BCards[i])
                {
                    AScore += 3;
                    lastWinner = 'A';
                }
                else if (ACards[i] == BCards[i])
                {
                    AScore++;
                    BScore++;
                }
                else
                {
                    BScore += 3;
                    lastWinner = 'B';
                }
            }

            if (AScore > BScore)
            {
                lastWinner = 'A';
            }
            else if (AScore < BScore)
            {
                lastWinner = 'B';
            }

            Console.WriteLine($"{AScore} {BScore}");
            Console.WriteLine(lastWinner);
        }
    }
}