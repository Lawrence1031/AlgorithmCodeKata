namespace _1302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> soldBooks = new Dictionary<string, int>();

            for (int i = 0; i < N; i++)
            {
                string book = Console.ReadLine();

                if (soldBooks.ContainsKey(book))
                {
                    soldBooks[book]++;
                }
                else
                {
                    soldBooks[book] = 1;
                }
            }

            var sortedBooks = soldBooks.OrderBy(x => x.Key);
            string bestSeller = sortedBooks.First(x => x.Value == soldBooks.Values.Max()).Key;

            Console.WriteLine(bestSeller);
        }
    }
}