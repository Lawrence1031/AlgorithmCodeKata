namespace _2914
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int I = int.Parse(inputs[1]);

            Console.WriteLine(A * (I - 1) + 1);
        }
    }
}