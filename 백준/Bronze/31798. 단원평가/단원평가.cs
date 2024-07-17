namespace _31798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            if (a == 0 || b == 0)
            {
                Console.WriteLine(Math.Pow(c, 2) - a - b);
            }
            else
            {
                Console.WriteLine(Math.Sqrt(a + b));
            }
        }
    }
}