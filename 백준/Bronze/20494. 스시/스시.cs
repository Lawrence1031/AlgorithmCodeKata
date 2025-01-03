namespace _20494
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] wants = new string[N];
            int answer = 0;

            for (int i = 0; i < N; i++)
            {
                wants[i] = Console.ReadLine();
                answer += wants[i].Length;
            }

            Console.WriteLine(answer);
        }
    }
}