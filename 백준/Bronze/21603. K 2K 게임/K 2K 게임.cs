namespace _21603
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            int fK = K % 10;
            int f2K = (2 * K) % 10;

            List<int> result = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                int fX = i % 10;
                if (fX != fK && fX != f2K)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(result.Count);
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}