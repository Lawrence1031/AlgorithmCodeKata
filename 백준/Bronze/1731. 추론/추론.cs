namespace _1731
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            if (arr[1] - arr[0] == arr[2] - arr[1])
            {
                Console.WriteLine(arr[N - 1] + arr[1] - arr[0]);
            }
            else
            {
                Console.WriteLine(arr[N - 1] * (arr[1] / arr[0]));
            }
        }
    }
}