namespace _15429
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] groups = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 2; j < groups.Length - 1; j++)
                {
                    if (groups[j] != groups[j - 1] + 1)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}