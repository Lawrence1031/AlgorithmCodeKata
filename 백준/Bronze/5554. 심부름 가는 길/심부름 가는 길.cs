namespace _5554
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int t4 = int.Parse(Console.ReadLine());

            int seconds = t1 + t2 + t3 + t4;
            int minutes = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine(minutes);
            Console.WriteLine(seconds);
        }
    }
}