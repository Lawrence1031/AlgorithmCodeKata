namespace _1431
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<string> guitars = new List<string>();

            for (int i = 0; i < N; i++)
            {
                guitars.Add(Console.ReadLine());
            }

            var sortedList = guitars.OrderBy(x => x.Length)
                                    .ThenBy(x => guitarLength(x))
                                    .ThenBy(x => x);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        static int guitarLength(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0';
                }
            }

            return sum;
        }
    }
}