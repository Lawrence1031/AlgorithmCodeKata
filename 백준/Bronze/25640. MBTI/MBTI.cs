namespace _25640
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jinho = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (jinho == input) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}