namespace _2562
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            int idx = 0;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    idx = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(idx + 1);
        }
    }
}