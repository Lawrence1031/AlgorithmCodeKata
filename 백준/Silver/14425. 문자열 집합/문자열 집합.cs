namespace _14425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input.Split(' ')[0]);
            int M = int.Parse(input.Split(' ')[1]);
            string[] arrN = new string[N];
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                arrN[i] = Console.ReadLine();
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                if (arrN.Contains(input))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}