namespace _1251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string minLex = null;

            for (int i = 1; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    var part1 = new string(input.Substring(0, i).Reverse().ToArray());
                    var part2 = new string(input.Substring(i, j - i).Reverse().ToArray());
                    var part3 = new string(input.Substring(j).Reverse().ToArray());

                    var combined = part1 + part2 + part3;

                    if (minLex == null || String.Compare(combined, minLex) < 0)
                    {
                        minLex = combined;
                    }
                }
            }

            Console.WriteLine(minLex);
        }
    }
}