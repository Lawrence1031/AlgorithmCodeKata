namespace _2744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    Console.Write((char)(s[i] - 32));
                }
                else
                {
                    Console.Write((char)(s[i] + 32));
                }
            }
        }
    }
}