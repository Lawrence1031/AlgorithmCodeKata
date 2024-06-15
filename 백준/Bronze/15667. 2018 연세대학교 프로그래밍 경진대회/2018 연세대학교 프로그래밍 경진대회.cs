namespace _15667
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = n;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long value = (long)mid * mid + mid + 1;

                if (value == n)
                {
                    result = mid;
                    break;
                }
                else if (value < n)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}