namespace _14215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            int[] arr = { a, b, c };
            Array.Sort(arr);
            int sum = arr[0] + arr[1];

            while (arr[2] >= sum)
            {
                arr[2]--;
            }

            Console.WriteLine(arr.Sum());
            
        }
    }
}