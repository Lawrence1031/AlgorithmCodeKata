namespace _1205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int score = int.Parse(inputs[1]);
            int P = int.Parse(inputs[2]);

            if (N == 0)
            {
                Console.WriteLine("1");
                return;
            }

            inputs = Console.ReadLine().Split(' ');
            int[] rank = new int[N];
            for (int i = 0; i < N; i++)
            {
                rank[i] = int.Parse(inputs[i]);
            }

            if (N == P && score <= rank[N - 1])
            {
                Console.WriteLine("-1");
                return;
            }

            int position = 1;
            for (int i = 0; i < N; i++)
            {
                if (score > rank[i])
                {
                    break;
                }

                if (score < rank[i])
                {
                    position++;
                }
            }

            Console.WriteLine(position);
        }
    }
}