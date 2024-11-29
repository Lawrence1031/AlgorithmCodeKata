namespace _32642
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long totalAnger = 0;
            long nowAnger = 0;

            for (int i = 0; i < n; i++)
            {
                if (inputs[i] == 0)
                {
                    nowAnger--;
                    totalAnger += nowAnger;
                }
                else
                {
                    nowAnger++;
                    totalAnger += nowAnger;
                }
            }

            Console.WriteLine(totalAnger);
        }
    }
}