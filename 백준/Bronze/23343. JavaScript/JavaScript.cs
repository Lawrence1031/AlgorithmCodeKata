namespace _23343
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string a = inputs[0];
            string b = inputs[1];

            int aInt, bInt;

            if (int.TryParse(a, out aInt) && int.TryParse(b, out bInt))
            {
                Console.WriteLine(aInt - bInt);
            }
            else
            {
                Console.WriteLine("NaN");
            }
        }
    }
}