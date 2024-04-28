namespace _1264
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "#")
                {
                    return;
                }

                char[] arr = input.ToCharArray();
                int cnt = 0;

                foreach (char c in arr)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        cnt++;
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}