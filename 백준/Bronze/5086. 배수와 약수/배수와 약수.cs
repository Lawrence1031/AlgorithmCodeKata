namespace _5086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int A = int.Parse(input.Split(' ')[0]);
                int B = int.Parse(input.Split(' ')[1]);

                if (A == 0 && B == 0)
                {
                    break;
                }
                else if (A % B == 0)
                {
                    Console.WriteLine("multiple");
                }
                else if (B % A == 0)
                {
                    Console.WriteLine("factor");
                }
                else
                {
                    Console.WriteLine("neither");
                }
            }            
        }
    }
}