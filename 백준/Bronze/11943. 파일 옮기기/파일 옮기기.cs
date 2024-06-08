namespace _11943
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            inputs = Console.ReadLine().Split(' ');
            int C = int.Parse(inputs[0]);
            int D = int.Parse(inputs[1]);

            int case1 = A + D;
            int case2 = B + C;

            Console.WriteLine(Math.Min(case1, case2));
        }
    }
}