namespace _14843
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double totalScore = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                double S = double.Parse(inputs[0]);
                double A = double.Parse(inputs[1]);
                double T = double.Parse(inputs[2]);
                double M = double.Parse(inputs[3]);

                totalScore += CalculScore(S, A, T, M);
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

        static double CalculScore(double S, double A, double T, double M)
        {
            return S * (1 + (1 / A)) * (1 + (M / T)) / 4;
        }
    }
}