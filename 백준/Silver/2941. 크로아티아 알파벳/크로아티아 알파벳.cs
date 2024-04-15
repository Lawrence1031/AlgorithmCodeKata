using System.Text;

namespace _2941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 0;

            for (int i = 0; i < input.Length;)
            {
                if (i < input.Length - 1 && IsCro(input.Substring(i, 2)))
                {
                    cnt++;
                    i += 2;
                }
                else if (i < input.Length - 2 && IsCro(input.Substring(i, 3)))
                {
                    cnt++;
                    i += 3;
                }
                else
                {
                    cnt++;
                    i++;
                }
            }

            Console.WriteLine(cnt);
        }

        static bool IsCro(string input)
        {
            string[] cro = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            foreach (var item in cro)
            {
                if (input.StartsWith(item))
                { 
                    return true;
                }
            }
            return false;
        }
    }
}