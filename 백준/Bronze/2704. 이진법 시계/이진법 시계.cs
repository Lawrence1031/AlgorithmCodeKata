using System.Text;

namespace _2704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(':');
                StringBuilder sb = new StringBuilder();
                int hour = int.Parse(inputs[0]);
                int minute = int.Parse(inputs[1]);
                int second = int.Parse(inputs[2]);

                string binaryHour = Convert.ToString(hour, 2).PadLeft(6, '0');
                string binaryMinute = Convert.ToString(minute, 2).PadLeft(6, '0');
                string binarySecond = Convert.ToString(second, 2).PadLeft(6, '0');

                for (int j = 0; j < binaryHour.Length; j++)
                {
                    sb.Append(binaryHour[j]);
                    sb.Append(binaryMinute[j]);
                    sb.Append(binarySecond[j]);
                }

                sb.Append(' ');
                sb.Append(binaryHour);
                sb.Append(binaryMinute);
                sb.Append(binarySecond);

                Console.WriteLine(sb.ToString());
            }
        }
    }
}