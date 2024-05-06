namespace _1333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int L = int.Parse(inputs[1]);
            int D = int.Parse(inputs[2]);

            int totalTime = N * L + (N - 1) * 5;

            for (int t = 0; t <= totalTime; t += D)
            {
                bool canHear = true;

                for (int i = 0; i < N; i++)
                {
                    int startSong = i * (L + 5);
                    int endSong = startSong + L - 1;

                    if (t >= startSong && t <= endSong)
                    {
                        canHear = false;
                        break;
                    }
                }

                if (canHear)
                {
                    Console.WriteLine(t);
                    return;
                }
            }
            Console.WriteLine((totalTime / D + 1) * D);
        }
    }
}