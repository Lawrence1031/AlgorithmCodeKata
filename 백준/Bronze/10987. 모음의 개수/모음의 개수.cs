namespace _10987
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' ||
                    input[i] == 'o' || input[i] == 'u')
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}