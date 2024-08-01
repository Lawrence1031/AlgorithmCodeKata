namespace _30999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                int agreeCnt = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'O')
                    {
                        agreeCnt++;
                    }
                }

                if (agreeCnt > M / 2)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}