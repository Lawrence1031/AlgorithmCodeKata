using System.Text;

namespace _25024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                bool time = IsChangeTime(a, b);
                bool date = IsChangeDate(a, b);
                string timeStr = time ? "Yes" : "No";
                string dateStr = date ? "Yes" : "No";

                sb.AppendLine($"{timeStr} {dateStr}");
            }

            Console.WriteLine(sb.ToString());
        }

        static bool IsChangeTime(int a, int b)
        {
            if (a < 24 && b < 60)
            {
                return true;
            }

            return false;
        }

        static bool IsChangeDate(int a, int b)
        {
            int[] days = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (a >= 1 && a <= 12 && b >= 1 && days[a] >= b)
            {
                return true;
            }

            return false;
        }
    }
}