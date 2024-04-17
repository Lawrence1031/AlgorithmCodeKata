namespace _10101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angleA = int.Parse(Console.ReadLine());
            int angleB = int.Parse(Console.ReadLine());
            int angleC = int.Parse(Console.ReadLine());
            int total = angleA + angleB + angleC;

            if (total != 180)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (angleA == angleB && angleB == angleC)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (angleA == angleB || angleA == angleC || angleB == angleC)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
        }
    }
}