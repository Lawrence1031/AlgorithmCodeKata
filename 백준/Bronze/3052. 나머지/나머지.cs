namespace _3052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> ints = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!ints.Contains(arr[i] % 42))
                {
                    ints.Add(arr[i] % 42);
                }
            }

            Console.WriteLine(ints.Count);
        }
    }
}