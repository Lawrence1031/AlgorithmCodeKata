namespace _5893
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string shifted = input + "0000";
            string result = AddBinary(input, shifted);

            Console.WriteLine(result);
        }

        static string AddBinary(string a, string b)
        {
            string result = "";
            int s = 0;

            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || s == 1)
            {
                s += (i >= 0) ? a[i] - '0' : 0;
                s += (j >= 0) ? b[j] - '0' : 0;

                result = (char)(s % 2 + '0') + result;

                s /= 2;

                i--;
                j--;
            }

            return result;
        }
    }
}