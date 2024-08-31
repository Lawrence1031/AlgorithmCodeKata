using System.Text;

namespace _26040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            char[] chars = B.Replace(" ", "").ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < A.Length; i++)
            {
                if (B.Contains(A[i]))
                {
                    sb.Append(Char.ToLower(A[i]));
                }
                else
                {
                    sb.Append(A[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}