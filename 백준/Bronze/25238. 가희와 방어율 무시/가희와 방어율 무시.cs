namespace _25238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int totalDef = int.Parse(inputs[0]);
            int DefMinus = int.Parse(inputs[1]);

            double answer = totalDef * (100 - DefMinus) / 100.00;
            Console.WriteLine(answer >= 100 ? 0 : 1);
        }
    }
}