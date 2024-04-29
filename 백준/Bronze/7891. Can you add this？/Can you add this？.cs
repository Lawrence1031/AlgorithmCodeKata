namespace _7891
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                long a = long.Parse(inputs[0]);
                long b = long.Parse(inputs[1]);

                Console.WriteLine(a + b);
            }
        }
    }
}