namespace _9498
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            if (100 >= a && a >= 90)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80)
            {
                Console.WriteLine("B");
            }
            else if (a >= 70)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}