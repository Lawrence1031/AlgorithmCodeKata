namespace _17210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            int order = int.Parse(Console.ReadLine());

            if (N > 5)
            {
                Console.WriteLine("Love is open door");
            }
            else
            {
                for (int i = 2; i <= N; i++)
                {
                    order++;
                    Console.WriteLine(order % 2);
                }
            }
        }
    }
}