namespace _25377
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int minTime = 1001;

            for (int i = 0; i < N; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int A = inputs[0];
                int B = inputs[1];

                if (A <= B && minTime > B)
                {
                    minTime = B;
                }
            }

            Console.WriteLine(minTime < 1001 ? minTime : -1);
        }
    }
}