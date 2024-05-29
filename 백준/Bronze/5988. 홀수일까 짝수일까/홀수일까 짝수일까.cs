namespace _5988
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int len = input.Length - 1;

                if (input[len] == '0' || input[len] == '2' || input[len] == '4' ||
                    input[len] == '6' || input[len] == '8')
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
        }
    }
}