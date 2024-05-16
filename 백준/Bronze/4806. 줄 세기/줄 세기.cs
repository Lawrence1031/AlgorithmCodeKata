namespace _4806
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                list.Add(input);
            }

            Console.WriteLine(list.Count);
        }
    }
}