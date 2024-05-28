namespace _4589
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Gnomes:");
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int first = int.Parse(inputs[0]);
                int second = int.Parse(inputs[1]);
                int third = int.Parse(inputs[2]);

                if ((first > second && second > third) || (first < second && second < third))
                {
                    Console.WriteLine("Ordered");
                }
                else
                {
                    Console.WriteLine("Unordered");
                }
            }
        }
    }
}