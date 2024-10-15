namespace _31746
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string init = "SciComLove";
            string reversed = "evoLmoCicS";

            if (N % 2 == 1)
            {
                Console.WriteLine(reversed);
            }
            else
            {
                Console.WriteLine(init);
            }
        }
    }
}