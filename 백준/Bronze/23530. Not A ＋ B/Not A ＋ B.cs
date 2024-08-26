namespace _23530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 0; test < t; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int sum = a + b;
                int c = (sum == 1) ? 2 : 1;
                Console.WriteLine(c);
            }
        }
    }
}