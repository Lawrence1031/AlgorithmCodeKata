namespace _5555
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                input = input + input;
                if (input.Contains(target)) cnt++;  
            }

            Console.WriteLine(cnt);
        }
    }
}