namespace _1668
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            int left = 0;
            int leftMax = 0;
            int right = 0;
            int rightMax = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > leftMax)
                {
                    left++;
                    leftMax = arr[i];
                }
            }

            for (int i = N - 1; i >= 0; i--)
            {
                if (arr[i] > rightMax)
                {
                    right++;
                    rightMax = arr[i];
                }
            }

            Console.WriteLine(left);
            Console.WriteLine(right);
        }
    }
}