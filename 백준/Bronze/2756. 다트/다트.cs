using System.Numerics;

namespace _2756
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double[] xPoints = new double[6];
                double[] yPoints = new double[6];

                for (int j = 0; j < 6; j++)
                {
                    xPoints[j] = double.Parse(inputs[2 * j]);
                    yPoints[j] = double.Parse(inputs[2 * j + 1]);
                }

                double[] distance = new double[6];

                for (int j = 0; j < 6; j++)
                {
                    distance[j] = Math.Sqrt(xPoints[j] * xPoints[j] + yPoints[j] * yPoints[j]);
                }

                int AScore = 0;
                int BScore = 0;

                for (int j = 0; j < 3; j++)
                {
                    AScore += CheckScore(distance[j]);
                    BScore += CheckScore(distance[j + 3]);
                }

                string result = "TIE.";

                if (AScore > BScore)
                {
                    result = "PLAYER 1 WINS.";
                }
                else if (AScore < BScore)
                {
                    result = "PLAYER 2 WINS.";
                }

                Console.Write($"SCORE: {AScore} to {BScore}, ");
                Console.WriteLine(result);
            }
        }

        static int CheckScore(double distance)
        {
            if (distance <= 3)
            {
                return 100;
            }
            else if (distance <= 6)
            {
                return 80;
            }
            else if (distance <= 9)
            {
                return 60;
            }
            else if (distance <= 12)
            {
                return 40;
            }
            else if (distance <= 15)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }
    }
}