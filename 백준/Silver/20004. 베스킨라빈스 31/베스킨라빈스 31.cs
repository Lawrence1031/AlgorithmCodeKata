namespace _20004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            for (int i = 1; i <= A; i++)
            {
                if ((31 % (i + 1)) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}