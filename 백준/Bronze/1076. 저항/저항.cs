namespace _1076
{
    internal class Program
    {
        enum color
        {
            black, brown, red, orange, yellow, 
            green, blue, violet, grey, white
        }
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            color color1 = (color)Enum.Parse(typeof(color), input1);
            color color2 = (color)Enum.Parse(typeof(color), input2);
            color color3 = (color)Enum.Parse(typeof(color), input3);

            long number = (long)((int)color1 * 10 + (int)color2);
            long deca = (long)Math.Pow(10, (int)color3);

            long result = number * deca;

            Console.WriteLine(result);
        }
    }
}