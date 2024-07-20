namespace _17496
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int T = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);
            int P = int.Parse(inputs[3]);

            int fruits = (N - 1) / T * C * P;
            Console.WriteLine(fruits);
        }
    }
}