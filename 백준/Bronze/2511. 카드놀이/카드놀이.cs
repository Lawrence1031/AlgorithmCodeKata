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

            for (int i = 0; i < ACards.Length; i++)
            {
                if (ACards[i] > BCards[i])
                {
                    AScore += 3;
                }
                else if (ACards[i] == BCards[i])
                {
                    AScore++;
                    BScore++;
                }
                else
                {
                    BScore += 3;
                }
            }

            string winner = "";

            if (AScore > BScore)
            {
                winner = "A";
            }
            else if (AScore < BScore)
            {
                winner = "B";
            }
            else
            {
                if (AScore == 10)
                {
                    winner = "D";
                }
                else
                {
                    for (int i = ACards.Length - 1; i >= 0; i--)
                    {
                        if (ACards[i] != BCards[i])
                        {
                            if (ACards[i] > BCards[i]) winner = "A";
                            else winner = "B";

                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"{AScore} {BScore}");
            Console.WriteLine(winner);
        }
    }
}