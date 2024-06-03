namespace _3622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int a = int.Parse(inputs[1]);
            int B = int.Parse(inputs[2]);
            int b = int.Parse(inputs[3]);
            int P = int.Parse(inputs[4]);

            if (A > P || B > P)
            {
                Console.WriteLine("No");
            }
            else if (A + B <= P)
            {
                Console.WriteLine("Yes");
            }
            else if (a >= B)
            {
                Console.WriteLine("Yes");
            }
            else if (b >= A)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}