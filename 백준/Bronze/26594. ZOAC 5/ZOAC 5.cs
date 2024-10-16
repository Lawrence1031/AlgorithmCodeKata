namespace _26594
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 1;
            char key = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == key) cnt++;
                else break;
            }

            Console.WriteLine(cnt);
        }
    }
}