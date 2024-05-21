namespace _1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int cnt = 0;

            while (X > 0)
            {
                int stick = 64;
                while (stick > X)
                {
                    stick /= 2;
                }
                cnt++;
                X -= stick;
            }
            Console.WriteLine(cnt);
        }
    }
}