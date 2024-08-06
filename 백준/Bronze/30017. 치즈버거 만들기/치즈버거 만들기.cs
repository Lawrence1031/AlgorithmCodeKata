namespace _30017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            if (B >= A - 1)
            {
                Console.WriteLine(2 * A - 1);
            }
            else
            {
                Console.WriteLine(2 * B + 1);
            }
        }
    }
}