namespace _24860
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long V1 = long.Parse(inputs[0]);
            long J1 = long.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');
            long V2 = long.Parse(inputs[0]);
            long J2 = long.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');
            long V3 = long.Parse(inputs[0]);
            long D3 = long.Parse(inputs[1]);
            long J3 = long.Parse(inputs[2]);

            long mutation1 = V1 * J1 * V3 * D3 * J3;
            long mutation2 = V2 * J2 * V3 * D3 * J3;

            Console.WriteLine(mutation1 + mutation2);
        }
    }
}