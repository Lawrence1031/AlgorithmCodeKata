namespace _2852
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int team1Score = 0;
            int team2Score = 0;
            int leadTeam = 0;
            int team1Time = 0;
            int team2Time = 0;
            int lastMin = 0;
            int lastSec = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int team = int.Parse(inputs[0]);
                string[] times = inputs[1].Split(":");
                int curMin = int.Parse(times[0]);
                int curSec = int.Parse(times[1]);

                int elapsedTime = (curMin -lastMin) * 60 + (curSec - lastSec);

                if (leadTeam == 1)
                {
                    team1Time += elapsedTime;
                }
                else if (leadTeam == 2)
                {
                    team2Time += elapsedTime;
                }

                if (team == 1) team1Score++;
                else team2Score++;

                if (team1Score > team2Score) leadTeam = 1;
                else if (team1Score == team2Score) leadTeam = 0;
                else leadTeam = 2;

                lastMin = curMin;
                lastSec = curSec;
            }

            int finalTime = (48 - lastMin) * 60 - lastSec;
            if (leadTeam == 1)
            {
                team1Time += finalTime;
            }
            else if (leadTeam == 2)
            {
                team2Time += finalTime;
            }

            Console.WriteLine($"{(team1Time / 60).ToString("D2")}:{(team1Time % 60).ToString("D2")}");
            Console.WriteLine($"{(team2Time / 60).ToString("D2")}:{(team2Time % 60).ToString("D2")}");
        }
    }
}