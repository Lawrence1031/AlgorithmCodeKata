namespace _2753
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            if (a % 4 == 0 && a % 100 != 0)
            {
                Console.WriteLine(1);
            }
            else if (a % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}