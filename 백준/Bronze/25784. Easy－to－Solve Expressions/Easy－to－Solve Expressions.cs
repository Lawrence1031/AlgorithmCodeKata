namespace _25784
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = inputs[0];
            int b = inputs[1];
            int c = inputs[2];

            Console.WriteLine(IsSum(a, b, c) ? 1 : IsMultiple(a, b, c) ? 2 : 3);
        }

        static bool IsSum(int a, int b, int c)
        {
            if (a == b + c) return true;
            if (a + b == c) return true;
            if (a + c == b) return true;

            return false;
        }

        static bool IsMultiple(int a, int b, int c)
        {
            if (a == b * c) return true;
            if (a * b == c) return true;
            if (a * c == b) return true;

            return false;
        }
    }
}