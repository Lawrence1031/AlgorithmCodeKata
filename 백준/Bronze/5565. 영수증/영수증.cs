namespace _5565
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                total -= int.Parse(Console.ReadLine());
            }

            Console.WriteLine(total);
        }
    }
}