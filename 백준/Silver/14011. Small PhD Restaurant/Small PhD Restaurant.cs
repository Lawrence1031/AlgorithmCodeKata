namespace _14011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[] A = new int[N];
            string[] AInputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(AInputs[i]);
            }

            int[] B = new int[N];
            string[] BInputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(BInputs[i]);
            }

            List<(int cost, int reward)> challenges = new List<(int, int)>();
            for (int i = 0; i < N; i++)
            {
                challenges.Add((A[i], B[i]));
            }

            challenges.Sort((x, y) => x.cost.CompareTo(y.cost));

            int currentMoney = M;

            foreach (var challenge in challenges)
            {
                if (currentMoney >= challenge.cost && challenge.reward > challenge.cost)
                {
                    currentMoney += challenge.reward - challenge.cost;
                }
            }

            Console.WriteLine(currentMoney);
        }
    }
}