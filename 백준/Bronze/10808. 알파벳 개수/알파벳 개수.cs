namespace _10808
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] alp = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                alp[input[i] - 'a']++;
            }

            Console.WriteLine(string.Join(" ", alp));
        }
    }
}