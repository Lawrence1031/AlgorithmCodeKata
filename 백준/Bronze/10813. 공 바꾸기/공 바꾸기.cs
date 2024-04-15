namespace _10813
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]) - 1;
                int b = int.Parse(inputs[1]) - 1;

                int tmp = arr[a];
                arr[a] = arr[b];
                arr[b] = tmp;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}