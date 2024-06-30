namespace _10409
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int T = int.Parse(inputs[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int total = 0;
            int idx = 0;

            if (arr.Sum() <= T)
            {
                idx = n;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i];
                    idx = i;
                    if (total > T)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(idx);
        }
    }
}