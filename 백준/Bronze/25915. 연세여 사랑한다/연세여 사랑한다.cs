namespace _25915
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Password = "ILOVEYONSEI";
            string input = Console.ReadLine();
            char now = input[0];
            int cnt = 0;

            for (int i = 0; i < Password.Length; i++)
            {
                cnt += Math.Abs(Password[i] - now);
                now = Password[i];
            }

            Console.WriteLine(cnt);
        }
    }
}