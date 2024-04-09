namespace _1541
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parts = input.Split('-');

            int result = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                var sum = parts[i].Split("+").Select(int.Parse).Sum();

                if (i == 0)
                {
                    result += sum;
                }
                else
                {
                    result -= sum;
                }
            }

            Console.WriteLine(result);
        }
    }
}