namespace _2501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = N % (i + 1);
            }

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                if (arr[i] == 0)
                {
                    cnt++;
                }

                if (cnt == K)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(0);
        }
    }
}