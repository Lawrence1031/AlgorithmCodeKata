namespace _31090
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if ((input + 1) % (input % 100) == 0)
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Bye");
                }
            }
        }
    }
}