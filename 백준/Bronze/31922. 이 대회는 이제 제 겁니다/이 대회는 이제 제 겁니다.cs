namespace _31922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int P = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            Console.WriteLine(Math.Max(A + C, P));
        }
    }
}