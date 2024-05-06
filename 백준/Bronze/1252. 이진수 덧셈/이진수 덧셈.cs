using System.Numerics;

namespace _1252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string input1 = inputs[0];
            string input2 = inputs[1];

            string result = AddBinary(input1, input2);
            Console.WriteLine(result);
        }

        static string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            string result = "";

            while (i >= 0 || j >= 0 || carry != 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                carry = sum >> 1;
                result = (sum & 1) + result;
            }

            result = result.TrimStart('0');

            if (string.IsNullOrEmpty(result))
            {
                result = "0";
            }

            return result;
        }
    }
}