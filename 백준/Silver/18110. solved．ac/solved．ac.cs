namespace _18110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int percent = (int)Math.Round(n * 0.15, MidpointRounding.AwayFromZero);
            double total = 0.0;

            for (int i = percent; i < n - percent; i++)
            {
                total += arr[i];
            }

            Console.WriteLine((int)Math.Round(total / (n - 2 * percent), MidpointRounding.AwayFromZero));
        }
    }
}