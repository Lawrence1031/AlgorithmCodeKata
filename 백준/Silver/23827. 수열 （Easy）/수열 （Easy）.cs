namespace _23827
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int[] arr = new int[N];
            long sum = 0;
            long answer = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
                sum += arr[i];
                sum %= 1000000007;
            }

            for (int i = 0; i < N; i++)
            {
                sum -= arr[i];
                if (sum < 0)
                {
                    sum += 1000000007;
                }
                answer += arr[i] * sum;
                answer %= 1000000007;
            }

            Console.WriteLine(answer);
        }
    }
}