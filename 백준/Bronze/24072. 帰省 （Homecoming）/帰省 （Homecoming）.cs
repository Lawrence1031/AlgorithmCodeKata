namespace _24072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            if (C >= A && B > C)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}