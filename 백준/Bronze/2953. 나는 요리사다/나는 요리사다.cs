namespace _2953
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                arr[i] = int.Parse(inputs[0]) + int.Parse(inputs[1]) +
                         int.Parse(inputs[2]) + int.Parse(inputs[3]);
            }
            int rank = Array.IndexOf(arr, arr.Max()) + 1;
            Console.WriteLine($"{rank} {arr.Max()}");
        }
    }
}