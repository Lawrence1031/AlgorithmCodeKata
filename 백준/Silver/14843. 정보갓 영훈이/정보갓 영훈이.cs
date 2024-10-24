using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double totalScore = 0;

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            double S = double.Parse(input[0]);
            int A = int.Parse(input[1]);
            int T = int.Parse(input[2]);
            int M = int.Parse(input[3]);

            double score = (S * (1 + (1.0 / A)) * (1 + ((double)M / T))) / 4;
            totalScore += score;
        }

        int P = int.Parse(Console.ReadLine());
        List<double> scores = new List<double>();

        for (int i = 0; i < P; i++)
        {
            double R = double.Parse(Console.ReadLine());
            scores.Add(R);
        }

        scores.Add(totalScore);
        scores = scores.OrderByDescending(x => x).ToList();
        int rank = scores.IndexOf(totalScore) + 1;
        double markPoint = (double)rank / scores.Count * 100;

        if (markPoint <= 15)
        {
            Console.WriteLine($"The total score of Younghoon \"The God\" is {totalScore:F2}.");
        }
        else
        {
            Console.WriteLine($"The total score of Younghoon is {totalScore:F2}.");
        }
    }
}
