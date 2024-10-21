namespace _3733
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                int n = int.Parse(input.Split(' ')[0]);
                int s = int.Parse(input.Split(' ')[1]);

                Console.WriteLine(s / (n + 1));
            }
        }
    }
}