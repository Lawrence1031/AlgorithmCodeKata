namespace _17509
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int D, int V)> problems = new List<(int D, int V)> ();

            for (int i = 0; i < 11; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int D = int.Parse(inputs[0]);
                int V = int.Parse(inputs[1]);
                problems.Add((D, V));
            }

            problems.Sort((a, b) =>
            {
                if (a.D != b.D)
                {
                    return a.D.CompareTo(b.D);
                }
                return a.V.CompareTo(b.V);
            });

            int totalPenalty = 0;
            int currentTime = 0;

            foreach (var problem in problems)
            {
                currentTime += problem.D;
                totalPenalty += currentTime + problem.V * 20;
            }

            Console.WriteLine(totalPenalty);
        }
    }
}