namespace _1654
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int K = Convert.ToInt32(s.Split(' ')[0]);
            int N = Convert.ToInt32(s.Split(' ')[1]);
            int[] arr = new int[K];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            long left = 1;
            long right = arr.Max();

            while (left <= right)
            {
                long mid = (left + right) / 2;
                long cnt = arr.Sum(x => x / mid);

                if (cnt < N)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            Console.WriteLine(right);
        }
    }
}