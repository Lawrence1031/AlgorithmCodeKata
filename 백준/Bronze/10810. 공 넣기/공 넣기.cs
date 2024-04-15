namespace _10810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] arr = new int[N];

            for (int x = 0; x < M; x++)
            {
                inputs = Console.ReadLine().Split(' ');
                int i = int.Parse(inputs[0]);
                int j = int.Parse(inputs[1]);
                int k = int.Parse(inputs[2]);

                for (int y = i; y <= j; y++)
                {
                    arr[y - 1] = k;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}