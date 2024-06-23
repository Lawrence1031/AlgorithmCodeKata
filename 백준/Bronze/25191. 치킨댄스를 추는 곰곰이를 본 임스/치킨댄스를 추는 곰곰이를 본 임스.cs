namespace _25191
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            int maxDrink = A / 2 + B;
            Console.WriteLine(Math.Min(N, maxDrink));
        }
    }
}