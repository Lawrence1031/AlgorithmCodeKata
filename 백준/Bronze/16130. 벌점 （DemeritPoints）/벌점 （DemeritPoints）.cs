namespace _16130
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int totalScore = 0;
                int totalPeriod = 0;
                bool isFired = false;
                int currentPeriod = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    int score = 0;

                    if (input[j] >= '0' && input[j] <= '9')
                    {
                        score += (int)input[j] - 48;
                    }
                    else
                    {
                        score += (int)input[j] - 55;
                    }

                    totalScore += score;

                    int period = totalScore / 10;

                    if (period > currentPeriod)
                    {
                        currentPeriod = period;

                        if (currentPeriod > 4)
                        {
                            Console.WriteLine(totalPeriod + "(09)");
                            isFired = true;
                            break;
                        }
                        else if (currentPeriod == 4)
                        {
                            Console.WriteLine(totalPeriod + "(weapon)");
                            isFired = true;
                            break;
                        }

                        totalPeriod += currentPeriod;
                    }

                }

                if (!isFired)
                {
                    Console.WriteLine(totalPeriod);
                }
            }
        }
    }
}