namespace _1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            string s = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(s.Split(' ')[i]);
            }

            int max = arr.Max();
            double tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                tmp += arr[i];
            }

            tmp = tmp * 100 / N / max;
            Console.WriteLine(tmp);
        }
    }
}