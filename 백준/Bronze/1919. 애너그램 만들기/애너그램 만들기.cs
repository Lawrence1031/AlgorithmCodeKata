namespace _1919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int answer = ToAnagrams(first, second);

            Console.WriteLine(answer);
        }

        static int ToAnagrams(string first, string second)
        {
            int[] charCnt1 = new int[26];
            int[] charCnt2 = new int[26];

            foreach (char c in first)
            {
                charCnt1[c - 'a']++;
            }

            foreach (char c in second)
            {
                charCnt2[c - 'a']++;
            }

            int result = 0;
            for (int i = 0; i < 26; i++)
            {
                result += Math.Abs(charCnt1[i] - charCnt2[i]);
            }

            return result;
        }
    }
}