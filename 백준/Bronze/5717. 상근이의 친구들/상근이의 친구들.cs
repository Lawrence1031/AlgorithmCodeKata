namespace _5717
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int male = int.Parse(inputs[0]);
                int female = int.Parse(inputs[1]);

                if (male == 0 && female == 0)
                {
                    return;
                }

                Console.WriteLine(male + female);
            }
        }
    }
}