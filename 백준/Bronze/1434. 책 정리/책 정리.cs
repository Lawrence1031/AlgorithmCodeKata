namespace _1434
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] arr = new int[N];

            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < M; i++)
            {
                int bookSize = int.Parse(inputs[i]);

                for (int j = 0; j < arr.Length; j++)
                {
                    if (bookSize <= arr[j])
                    {
                        arr[j] -= bookSize;
                        break;
                    }
                }
            }

            int answer = arr.Sum();
            Console.WriteLine(answer);
        }
    }
}