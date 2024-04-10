namespace _2576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();

            for (int i = 0; i < 7; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 1)
                {
                    num.Add(input);
                }
            }

            if (num.Count > 0)
            {
                Console.WriteLine(num.Sum());
                Console.WriteLine(num.Min());
            }
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}