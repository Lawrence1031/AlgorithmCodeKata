namespace _1606
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            long position = 1;

            for (long i = 0; i < x + y + (y == 0 ? 1 : 0); i++)
            {
                position += 6 * i;
            }

            Console.WriteLine(position + y);
        }
    }
}