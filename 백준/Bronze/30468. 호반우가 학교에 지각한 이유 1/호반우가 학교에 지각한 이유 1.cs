namespace _30468
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int STR = int.Parse(inputs[0]);
            int DEX = int.Parse(inputs[1]);
            int INT = int.Parse(inputs[2]);
            int LUK = int.Parse(inputs[3]);
            int N = int.Parse(inputs[4]);
            int SUM = STR + DEX + INT + LUK;

            if (SUM > N * 4)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(N * 4 - SUM);
            }
        }
    }
}