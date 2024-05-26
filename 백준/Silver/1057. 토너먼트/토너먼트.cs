namespace _1057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int A = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);

            int round = 0;

            while (A != B)
            {
                A = (A + 1) >> 1;
                B = (B + 1) >> 1;
                round++;
            }

            Console.WriteLine(round);
        }
    }
}