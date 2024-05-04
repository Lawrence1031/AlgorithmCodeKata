namespace _2959
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);
            int D = int.Parse(inputs[3]);

            int[] arr = { A, B, C, D };
            Array.Sort(arr);

            Console.WriteLine(arr[0] * arr[2]);
        }
    }
}