using System.Text;

namespace _2864
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string AStr = inputs[0];
            string BStr = inputs[1];
            StringBuilder AsbMin = new StringBuilder();
            StringBuilder AsbMax = new StringBuilder();
            StringBuilder BsbMin = new StringBuilder();
            StringBuilder BsbMax = new StringBuilder();

            for (int i = 0; i < AStr.Length; i++)
            {
                if (AStr[i] == '5')
                {
                    AsbMin.Append('5');
                    AsbMax.Append('6');
                }
                else if (AStr[i] == '6')
                {
                    AsbMin.Append('5');
                    AsbMax.Append('6');
                }
                else
                {
                    AsbMin.Append(AStr[i]);
                    AsbMax.Append(AStr[i]);
                }
            }

            for (int i = 0; i < BStr.Length; i++)
            {
                if (BStr[i] == '5')
                {
                    BsbMin.Append('5');
                    BsbMax.Append('6');
                }
                else if (BStr[i] == '6')
                {
                    BsbMin.Append('5');
                    BsbMax.Append('6');
                }
                else
                {
                    BsbMin.Append(BStr[i]);
                    BsbMax.Append(BStr[i]);
                }
            }

            int AMax = int.Parse(AsbMax.ToString());
            int AMin = int.Parse(AsbMin.ToString());
            int BMax = int.Parse(BsbMax.ToString());
            int BMin = int.Parse(BsbMin.ToString());

            Console.WriteLine($"{AMin + BMin} {AMax + BMax}");
        }
    }
}