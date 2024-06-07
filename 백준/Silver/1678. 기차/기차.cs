namespace _1678
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int T = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int N = int.Parse(inputs[2]);

            List<(string trainNumber, int departureTime)> allTrains = new List<(string trainNumber, int departureTime)>();
            for (int i = 0; i < T; i++)
            {
                string[] trainInfo = Console.ReadLine().Split(' ');
                string trainNumber = trainInfo[0];
                for (int j = 1; j < trainInfo.Length - 1; j++)
                {
                    int departureTime = int.Parse(trainInfo[j]);
                    allTrains.Add((trainNumber, departureTime));
                }
            }

            allTrains.Sort((a, b) => a.departureTime.CompareTo(b.departureTime));

            int startIdx = -1;
            for (int i = 0; i < allTrains.Count; i++)
            {
                if (allTrains[i].departureTime >= M)
                {
                    startIdx = i;
                    break;
                }
            }

            if (startIdx == -1)
            {
                startIdx = 0;
            }

            int lastIdx = (startIdx + N - 1) % allTrains.Count;
            string lastTrain = allTrains[lastIdx].trainNumber;

            Console.WriteLine(lastTrain);
        }
    }
}