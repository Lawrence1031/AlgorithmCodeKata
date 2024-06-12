namespace _17362
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int answer = 0;
            int cnt = n % 8;

            if (cnt == 1) answer = 1;
            else if (cnt == 0 || cnt == 2) answer = 2;
            else if (cnt == 3 || cnt == 7) answer = 3;
            else if (cnt == 4 || cnt == 6) answer = 4;
            else if (cnt == 5) answer = 5;

            Console.WriteLine(answer);
        }
    }
}