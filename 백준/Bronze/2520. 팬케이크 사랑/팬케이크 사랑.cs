namespace _2520
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.ReadLine();

                double[] baseIngre = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                int[] specialIngre = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                double basicCake = Math.Min(baseIngre[0] / 0.5, Math.Min(baseIngre[1] / 0.5,
                                   Math.Min(baseIngre[2] / 0.25, Math.Min(baseIngre[3] / 0.0625, baseIngre[4] / 0.5625))));

                int bananaCake = specialIngre[0];
                int strawberryCake = specialIngre[1] / 30;
                int chocoCake = specialIngre[2] / 25;
                int walnutCake = specialIngre[3] / 10;

                int totalCake = bananaCake + strawberryCake + chocoCake + walnutCake;

                Console.WriteLine(Math.Min((int)basicCake, totalCake));
            }
        }
    }
}