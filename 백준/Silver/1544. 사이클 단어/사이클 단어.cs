namespace _1544
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> Words = new HashSet<string>();

            for (int i = 0; i < N; i++)
            {
                string word = Console.ReadLine();
                bool isNewWord = true;

                for (int j = 0; j < word.Length; j++)
                {
                    string rotatedWord = word.Substring(j) + word.Substring(0, j);

                    if (Words.Contains(rotatedWord))
                    {
                        isNewWord = false;
                        break;
                    }
                }

                if (isNewWord)
                {
                    Words.Add(word);
                }
            }

            Console.WriteLine(Words.Count);
        }
    }
}