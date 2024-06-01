namespace _1449
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int L = int.Parse(inputs[1]);

            int[] positions = new int[N];
            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                positions[i] = int.Parse(inputs[i]);
            }

            Array.Sort(positions);
            int cnt = 1;
            double now = positions[0] + L - 0.5;

            for (int i = 1; i < N; i++)
            {
                if (now < positions[i])
                {
                    now = positions[i] + L - 0.5;
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}