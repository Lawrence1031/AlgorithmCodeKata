namespace _1712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long A = long.Parse(inputs[0]);
            long B = long.Parse(inputs[1]);
            long C = long.Parse(inputs[2]);

            if (B >= C)
            {
                Console.WriteLine(-1);
                return;
            }
            else
            {
                Console.WriteLine(A / (C - B) + 1);
            }
        }
    }
}