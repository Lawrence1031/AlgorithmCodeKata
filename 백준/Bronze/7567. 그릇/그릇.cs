namespace _7567
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int len = 10;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    len += 5;
                }
                else
                {
                    len += 10;
                }
            }

            Console.WriteLine(len);
        }
    }
}