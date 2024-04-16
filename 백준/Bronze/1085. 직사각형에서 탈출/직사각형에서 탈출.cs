namespace _1085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int w = int.Parse(inputs[2]);
            int h = int.Parse(inputs[3]);

            int min_x = Math.Min(x, w - x);
            int min_y = Math.Min(y, h - y);
            int min = Math.Min(min_x, min_y);

            Console.WriteLine(min);
        }
    }
}