namespace _2975
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int bal = int.Parse(inputs[0]);
                string letter = inputs[1];
                int charge = int.Parse(inputs[2]);

                if (bal == 0 && letter == "W" && charge == 0)
                {
                    return;
                }

                if (letter == "D")
                {
                    Console.WriteLine(bal + charge);
                }
                else
                {
                    Console.WriteLine(bal - charge >= -200 ? bal - charge : "Not allowed");
                }
            }
        }
    }
}