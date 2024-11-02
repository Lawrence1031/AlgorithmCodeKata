namespace _15858
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] inputs = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal a = inputs[0];
            decimal b = inputs[1];
            decimal c = inputs[2];
            decimal answer = a * b / c;
            Console.WriteLine(answer.ToString("F6"));
        }
    }
}