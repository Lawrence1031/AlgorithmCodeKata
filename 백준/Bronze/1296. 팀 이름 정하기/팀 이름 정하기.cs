namespace _1296
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());

            int maxProbability = -1;
            string answer = "";

            for (int i = 0; i < N; i++)
            {
                string teamName = Console.ReadLine();

                int teamL = CountLetter(name, teamName, 'L');
                int teamO = CountLetter(name, teamName, 'O');
                int teamV = CountLetter(name, teamName, 'V');
                int teamE = CountLetter(name, teamName, 'E');
                int teamScore = LoveScore(teamL, teamO, teamV, teamE);

                if ((teamScore > maxProbability) || (teamScore == maxProbability && string.Compare(teamName, answer) < 0))
                {
                    maxProbability = teamScore;
                    answer = teamName;
                }
            }

            Console.WriteLine(answer);
        }

        static int LoveScore(int L, int O, int V, int E)
        {
            int score = ((L + O) * (L + V) * (L + E) * (O + V) * (O + E) * (V + E)) % 100;

            return score;
        }

        static int CountLetter(string name, string teamName, char letter)
        {
            return name.Count(c => c == letter) + teamName.Count(c => c == letter); 
        }
    }
}