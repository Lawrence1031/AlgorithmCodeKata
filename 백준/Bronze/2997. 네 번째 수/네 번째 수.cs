namespace _2997
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            Array.Sort(arr);

            if (arr[1] - arr[0] == arr[2] - arr[1])
            {
                Console.WriteLine(2 * arr[2] - arr[1]);
            }
            else if (arr[1] - arr[0] == 2 * (arr[2] - arr[1]))
            {
                Console.WriteLine(arr[0] + (arr[2] - arr[1]));
            }
            else if (2 * (arr[1] - arr[0]) == arr[2] - arr[1])
            {
                Console.WriteLine(arr[1] + (arr[1] - arr[0]));
            }
        }
    }
}