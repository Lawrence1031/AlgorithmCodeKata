namespace _24075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int plus = A + B;
            int minus = A - B;

            Console.WriteLine(Math.Max(plus, minus));
            Console.WriteLine(Math.Min(plus, minus));

        }
    }
}