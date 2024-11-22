namespace _13416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 0; test < t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                int total = 0;

                for (int i = 0; i < n; i++)
                {
                    int[] interests = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    if (interests.Max() > 0)
                    {
                        total += interests.Max();
                    }
                }

                Console.WriteLine(total);
            }
        }
    }
}