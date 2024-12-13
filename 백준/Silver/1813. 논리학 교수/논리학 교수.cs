namespace _1813
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxAnswer = -1;

            for (int i = 0; i <= inputs.Max(); i++)
            {
                int count = inputs.Count(x => x == i);
                if (count == i)
                {
                    maxAnswer = Math.Max(maxAnswer, i);
                }
            }

            Console.WriteLine(maxAnswer);
        }
    }
}