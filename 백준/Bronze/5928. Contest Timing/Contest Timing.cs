namespace _5928
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int day = inputs[0];
            int hour = inputs[1];
            int minute = inputs[2];

            int startMinutes = (11 * 24 * 60) + (11 * 60) + 11;
            int endMinutes = (day * 24 * 60) + (hour * 60) + minute;
            int totalTime = endMinutes - startMinutes;

            Console.WriteLine(totalTime >= 0 ? totalTime : -1);
        }
    }
}