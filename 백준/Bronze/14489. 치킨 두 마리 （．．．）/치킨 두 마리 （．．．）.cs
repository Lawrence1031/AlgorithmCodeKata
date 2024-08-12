namespace _14489
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(Console.ReadLine());

            if (A + B >= 2 * C)
            {
                Console.WriteLine(A + B - (2 * C));
            }
            else
            {
                Console.WriteLine(A + B);
            }
        }
    }
}