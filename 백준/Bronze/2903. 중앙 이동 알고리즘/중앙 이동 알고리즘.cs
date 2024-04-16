namespace _2903
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double answer = Math.Pow((Math.Pow(2, N)) + 1, 2);

            Console.WriteLine(answer);
        }
    }
}