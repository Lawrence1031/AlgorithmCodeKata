namespace _14470
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            int time = 0;
            if (A < 0)
            {
                time += C * -A;
                time += D;
                time += B * E;
            }
            else
            {
                time += (B - A) * E;
            }

            Console.WriteLine(time);
        }
    }
}