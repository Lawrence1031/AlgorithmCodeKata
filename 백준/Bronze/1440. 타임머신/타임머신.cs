namespace _1440
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(":");
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            int cnt = 0;

            if (IsHour(A) && IsMinute(B) && IsSecond(C)) cnt++;
            if (IsHour(A) && IsMinute(C) && IsSecond(B)) cnt++;
            if (IsHour(B) && IsMinute(A) && IsSecond(C)) cnt++;
            if (IsHour(B) && IsMinute(C) && IsSecond(A)) cnt++;
            if (IsHour(C) && IsMinute(A) && IsSecond(B)) cnt++;
            if (IsHour(C) && IsMinute(B) && IsSecond(A)) cnt++;

            Console.WriteLine(cnt);
        }

        static bool IsHour(int num)
        {
            return num >= 1 && num <= 12;
        }
        static bool IsMinute(int num)
        {
            return num >= 0 && num <= 59;
        }
        static bool IsSecond(int num)
        {
            return num >= 0 && num <= 59;
        }
    }
}