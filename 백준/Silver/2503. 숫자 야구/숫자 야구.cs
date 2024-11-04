namespace _2503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queries = new List<(int number, int strikes, int balls)>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int number = int.Parse(inputs[0]);
                int strike = int.Parse(inputs[1]);
                int ball = int.Parse(inputs[2]);
                queries.Add((number, strike, ball));
            }

            int possibleCount = 0;

            for (int candidate = 123; candidate <= 987; candidate++)
            {
                string candidateStr = candidate.ToString();

                if (candidateStr.Distinct().Count() != 3 || candidateStr.Contains('0'))
                {
                    continue;
                }

                bool isValid = true;

                foreach (var (number, strikes, balls) in queries)
                {
                    string numberStr = number.ToString();
                    int currentStrike = 0;
                    int currentBall = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        if (candidateStr[j] == numberStr[j])
                        {
                            currentStrike++;
                        }
                        else if (numberStr.Contains(candidateStr[j]))
                        {
                            currentBall++;
                        }
                    }

                    if (currentStrike != strikes || currentBall != balls)
                    {
                        isValid = false;    
                        break;
                    }
                }

                if (isValid)
                {
                    possibleCount++;
                }
            }

            Console.WriteLine(possibleCount);
        }
    }
}