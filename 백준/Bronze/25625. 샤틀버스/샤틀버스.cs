namespace _25625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            if (x > y)
            {
                Console.WriteLine(x + y);
            }
            else
            {
                Console.WriteLine(y - x);
            }
        }
    }
}