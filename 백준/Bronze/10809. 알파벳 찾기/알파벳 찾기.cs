namespace _10809
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 97; i <= 122; i++)
            {
                map.Add(Convert.ToChar(i), -1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]) && map[s[i]] == -1)
                {
                    map[s[i]] = i;
                }
            }

            foreach (int i in map.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
}