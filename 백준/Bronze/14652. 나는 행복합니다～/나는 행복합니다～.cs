namespace _14652
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int K = int.Parse(inputs[2]);

            int x = K / M;
            int y = K % M;

            Console.WriteLine($"{x} {y}");
        }
    }
}