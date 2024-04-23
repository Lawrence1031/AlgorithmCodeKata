namespace _4779
{
    public class CantorSet
    {
        public static string CreatCantorSet(int n)
        {
            int len = (int)Math.Pow(3, n);
            char[] cantorSet = new char[len];
            for (int i = 0; i < len; i++)
            {
                cantorSet[i] = '-';
            }

            void RemoveMiddle(int start, int end)
            {
                if (end - start < 2) return;

                int third = (end - start + 1) / 3;
                for (int i = start + third; i < start + 2 * third; i++)
                {
                    cantorSet[i] = ' ';
                }

                RemoveMiddle(start, start + third - 1);
                RemoveMiddle(start + 2 * third, end);
            }

            RemoveMiddle(0, len - 1);
            return new string(cantorSet);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "1";

            while ((input = Console.ReadLine()) != null)
            {
                if (int.TryParse(input, out int n))
                {
                    string result = CantorSet.CreatCantorSet(n);
                    Console.WriteLine(result);
                }
            }
        }
    }
}