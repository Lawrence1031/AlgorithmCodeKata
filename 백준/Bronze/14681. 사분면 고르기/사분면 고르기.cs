namespace _14681
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int aInt = Convert.ToInt32(a);
            int bInt = Convert.ToInt32(b);

            if (aInt > 0 && bInt > 0)
            {
                Console.WriteLine(1);
            }
            else if (aInt < 0 && bInt > 0)
            {
                Console.WriteLine(2);
            }
            else if (aInt < 0 && bInt < 0)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}