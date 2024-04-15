namespace _2525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int A = int.Parse(input.Split(' ')[0]);
            int B = int.Parse(input.Split(' ')[1]);
            int C = int.Parse(Console.ReadLine());

            int min = (B + C) % 60;
            int hour = (A + (B + C) / 60) % 24;

            Console.WriteLine(hour + " " + min);
        }
    }
}