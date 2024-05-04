namespace _2875
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int K = int.Parse(inputs[2]);

            int maxTeams = 0;

            while (N >= 2 && M >= 1 && (N + M - K) >= 3)
            {
                N -= 2;
                M -= 1;
                maxTeams++;
            }

            Console.WriteLine(maxTeams);
        }
    }
}