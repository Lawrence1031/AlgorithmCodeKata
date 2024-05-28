namespace _5691
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);

                if (A == 0 && B == 0)
                {
                    return;
                }

                if (2 * A - B < A)
                {
                    Console.WriteLine(2 * A - B);
                }
                else if (2 * B - A > B)
                {
                    Console.WriteLine(2 * B - A);
                }
                else
                {
                    Console.WriteLine((A + B) / 2);
                }
            }
        }
    }
}