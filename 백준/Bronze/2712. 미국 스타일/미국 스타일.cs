namespace _2712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                float value = float.Parse(inputs[0]);
                string output = "";

                if (inputs[1] == "kg")
                {
                    output = $"{value * 2.2046:F4} lb";
                }
                else if (inputs[1] == "lb")
                {
                    output = $"{value * 0.4536:F4} kg";
                }
                else if (inputs[1] == "l")
                {
                    output = $"{value * 0.2642:F4} g";
                }
                else
                {
                    output = $"{value * 3.7854:F4} l";
                }

                Console.WriteLine(output);
            }
        }
    }
}