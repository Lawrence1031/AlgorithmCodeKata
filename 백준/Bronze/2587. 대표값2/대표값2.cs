namespace _2587
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] arr = new int[5];
            int aver = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                aver += arr[i];
            }

            Array.Sort(arr);

            Console.WriteLine(aver / 5);
            Console.WriteLine(arr[2]);
        }
    }
}