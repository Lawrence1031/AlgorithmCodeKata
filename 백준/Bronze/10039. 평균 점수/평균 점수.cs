namespace _10039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                int score = int.Parse(Console.ReadLine());

                if (score <= 40) score = 40;
                sum += score;
            }

            Console.WriteLine(sum / 5);
        }
    }
}