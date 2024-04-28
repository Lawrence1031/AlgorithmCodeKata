namespace _2083
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "# 0 0")
                {
                    return;
                }

                string name = input.Split(' ')[0];
                int age = int.Parse(input.Split(' ')[1]);
                int weight = int.Parse(input.Split(' ')[2]);

                if (age > 17)
                {
                    Console.WriteLine(name + " Senior");
                }
                else if (weight >= 80)
                {
                    Console.WriteLine(name + " Senior");
                }
                else
                {
                    Console.WriteLine(name + " Junior");
                }
            }
        }
    }
}