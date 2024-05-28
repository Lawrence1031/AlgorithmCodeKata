namespace _5666
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] inputs = input.Split(' ');
                int H = int.Parse(inputs[0]);
                int P = int.Parse(inputs[1]);

                Console.WriteLine(((double)H / P).ToString("F2"));
            }
        }
    }
}