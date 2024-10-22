using System.Text;

namespace _26264
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int bigCnt = 0;
            int secCnt = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            while (sb.Length > 0)
            {
                if (sb[0] == 'b')
                {
                    bigCnt++;
                    sb.Remove(0, 7);
                }
                else if (sb[0] == 's')
                {
                    secCnt++;
                    sb.Remove(0, 8);
                }
            }

            Console.WriteLine(secCnt > bigCnt ? "security!" : 
                              secCnt < bigCnt ? "bigdata?" : "bigdata? security!");
        }
    }
}