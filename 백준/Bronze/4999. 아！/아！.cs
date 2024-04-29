namespace _4999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string say = Console.ReadLine();
            string doctor = Console.ReadLine();

            if (say.Contains(doctor))
            {
                Console.WriteLine("go");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}