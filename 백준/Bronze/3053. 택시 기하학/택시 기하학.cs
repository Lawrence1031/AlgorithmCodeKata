namespace _3053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R = int.Parse(Console.ReadLine());
            double euclid = R * R * Math.PI;
            double taxi = R * R * 2;

            Console.WriteLine(euclid.ToString("F6"));
            Console.WriteLine(taxi.ToString("F6"));
        }
    }
}