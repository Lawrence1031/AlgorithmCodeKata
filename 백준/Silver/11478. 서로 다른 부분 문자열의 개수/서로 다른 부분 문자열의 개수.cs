namespace _11478
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 1; i + j <= S.Length; j++)
                {
                    string substring = S.Substring(i, j);
                    set.Add(substring);
                }
            }

            Console.WriteLine(set.Count);
        }
    }
}