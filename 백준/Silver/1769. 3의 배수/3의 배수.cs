namespace _1769
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 0;

            while (input.Length > 1)
            {
                int number = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    number += int.Parse(input[i].ToString());
                }

                input = number.ToString();
                cnt++;
            }

            Console.WriteLine(cnt);

            if (input == "3" || input == "6" || input == "9")
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}