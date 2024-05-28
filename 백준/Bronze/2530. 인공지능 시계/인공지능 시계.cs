namespace _2530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int hour = int.Parse(inputs[0]);
            int min = int.Parse(inputs[1]);
            int sec = int.Parse(inputs[2]);
            int requiredSec = int.Parse(Console.ReadLine());

            min += requiredSec / 60;
            sec += requiredSec % 60;

            if (sec / 60 >= 1)
            {
                min += sec / 60;
                sec %= 60;
            }

            if (min / 60 >= 1)
            {
                hour += min / 60;
                min %= 60;
            }

            if (hour / 24 >= 1)
            {
                hour %= 24;
            }

            Console.WriteLine($"{hour} {min} {sec}");
        }
    }
}