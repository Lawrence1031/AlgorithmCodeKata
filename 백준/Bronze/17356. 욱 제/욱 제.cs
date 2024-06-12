namespace _17356
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            double A = double.Parse(inputs[0]);
            double B = double.Parse(inputs[1]);
            double M = (B - A) / 400;
            double answer = 1 / (1 + Math.Pow(10, M));
            Console.WriteLine(answer);
        }
    }
}