namespace _2857
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool FBIPresent = false;
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();

                if (input.Contains("FBI"))
                {
                    Console.WriteLine(i + 1);
                    FBIPresent = true;
                }
            }

            if (!FBIPresent)
            {
                Console.WriteLine("HE GOT AWAY!");
            }
        }
    }
}