namespace _30402
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (inputs[i] == "w")
                    {
                        Console.WriteLine("chunbae");
                        return;
                    }
                    else if (inputs[i] == "b")
                    {
                        Console.WriteLine("nabi");
                        return;
                    }
                    else if (inputs[i] == "g")
                    {
                        Console.WriteLine("yeongcheol");
                        return;
                    }
                }
            }
        }
    }
}