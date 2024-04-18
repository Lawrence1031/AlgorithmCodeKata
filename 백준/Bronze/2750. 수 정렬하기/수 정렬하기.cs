namespace _2750
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0 ; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}