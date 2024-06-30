namespace _10707
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            if (P > C)
            {
                int XPrice = A * P;
                int YPrice = (P - C) * D + B;
                Console.WriteLine(Math.Min(XPrice, YPrice));
            }
            else
            {
                int XPrice = A * P;
                int YPrice = B;
                Console.WriteLine(Math.Min(XPrice, YPrice));
            }
        }
    }
}