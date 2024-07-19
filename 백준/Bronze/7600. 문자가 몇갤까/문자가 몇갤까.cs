namespace _7600
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

                input = input.ToLower();
                bool[] alp = new bool[26];
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] >= 'a' && input[i] <= 'z')
                    {
                        alp[input[i] - 'a'] = true;
                    }
                }

                int cnt = 0;
                for (int i = 0; i < alp.Length; i++)
                {
                    if (alp[i]) cnt++;
                }

                Console.WriteLine(cnt);
            }
        }
    }
}