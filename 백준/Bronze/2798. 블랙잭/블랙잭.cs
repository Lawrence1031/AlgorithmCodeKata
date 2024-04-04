namespace _2798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = Convert.ToInt32(s.Split(' ')[0]);
            int M = Convert.ToInt32(s.Split(' ')[1]);
            string s1 = Console.ReadLine();
            string[] ss1 = s1.Split(' ');
            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(ss1[i]);
            }

            int answer = blackJack(arr, N, M);
            Console.WriteLine(answer);

        }

        static int blackJack(int[] arr, int N, int M)
        {
            int closestSum = 0;

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        int sum = arr[i] + arr[j] + arr[k];
                        if (sum <= M && sum > closestSum)
                        {
                            closestSum = sum;
                        }
                        if (closestSum == M)
                        {
                            return closestSum;
                        }
                    }
                }
            }

            return closestSum;
        }
    }
}