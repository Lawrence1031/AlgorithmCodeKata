namespace _2948
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int day = int.Parse(inputs[0]);
            int month = int.Parse(inputs[1]);

            int totalDay = Days(month, day);
            int today = totalDay % 7;

            string[] names = { "Wednesday", "Thursday", "Friday", "Saturday", 
                               "Sunday", "Monday", "Tuesday", };

            Console.WriteLine(names[today]);
        }

        static int Days(int month, int day)
        {
            int totalDay = day;
            int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < month; i++)
            {
                totalDay += monthDays[i];
            }

            return totalDay;
        }
    }
}