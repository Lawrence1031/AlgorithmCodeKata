namespace _2490
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int cnt = 0;

                for (int j = 0; j < inputs.Length; j++)
                {
                    if (inputs[j] == "0")
                    {
                        cnt++;
                    }
                }

                if (cnt == 1) Console.WriteLine("A");
                else if (cnt == 2) Console.WriteLine("B");
                else if (cnt == 3) Console.WriteLine("C");
                else if (cnt == 4) Console.WriteLine("D");
                else Console.WriteLine("E");
            }
        }
    }
}