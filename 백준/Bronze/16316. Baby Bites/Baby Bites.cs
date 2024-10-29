namespace _16316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                if (int.TryParse(inputs[i], out int now))
                {
                    if (i + 1 != now)
                    {
                        Console.WriteLine("something is fishy");
                        return;
                    }
                }
            }

            Console.WriteLine("makes sense");
        }
    }
}