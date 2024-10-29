namespace _15238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] counts = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                int alp = input[i] - 'a';
                counts[alp]++;
            }

            int cnt = counts.Max();
            int idx = Array.IndexOf(counts, cnt);

            Console.WriteLine($"{(char)(idx + 'a')} {cnt}");
        }
    }
}