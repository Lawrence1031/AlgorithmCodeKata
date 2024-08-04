namespace _31822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());

            string check = input.Substring(0, 5);
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                string code = Console.ReadLine();
                string now = code.Substring(0, 5);

                if (check == now) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}