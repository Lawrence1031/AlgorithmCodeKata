namespace _1259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            while ((s = Console.ReadLine()) != "0")
            {
                bool isPalin = true;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        isPalin = false;
                    }
                }

                if (isPalin)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}