namespace _26307
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int hour = int.Parse(inputs[0]);
            int min = int.Parse(inputs[1]);

            Console.WriteLine((hour - 9) * 60 + min);
        }
    }
}