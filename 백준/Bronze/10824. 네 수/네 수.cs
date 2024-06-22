namespace _10824
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long number1 = long.Parse(inputs[0] + inputs[1]);
            long number2 = long.Parse(inputs[2] + inputs[3]);
            Console.WriteLine(number1 + number2);
        }
    }
}