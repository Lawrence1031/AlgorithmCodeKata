namespace _32684
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 13, 7, 5, 3, 3, 2 };
            int[] cocjr0208 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] ekwoo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double cocjrScore = 0;
            double ekwooScore = 1.5;

            for (int i = 0; i < 6; i++)
            {
                cocjrScore += scores[i] * cocjr0208[i];
                ekwooScore += scores[i] * ekwoo[i];
            }

            Console.WriteLine(cocjrScore > ekwooScore ? "cocjr0208" : "ekwoo");
        }
    }
}