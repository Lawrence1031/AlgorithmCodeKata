namespace _25305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);
            int[] arr = new int[N];

            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine(arr[k - 1]);
        }
    }
}