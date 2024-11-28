namespace _25991
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] lengths = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double totalVolume = 0;
            for (int i = 0; i < n; i++)
            {
                totalVolume += Math.Pow(lengths[i], 3);
            }

            double finalLength = Math.Pow(totalVolume, 1.0 / 3);
            Console.WriteLine(finalLength);
        }
    }
}