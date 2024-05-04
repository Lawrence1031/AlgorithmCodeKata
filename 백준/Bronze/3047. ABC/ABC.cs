using System.Text;

namespace _3047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(inputs[i]);
            }
            Array.Sort(numbers);

            string order = Console.ReadLine();

            foreach (char ch in order)
            {
                if (ch == 'A')
                    sb.Append(numbers[0] + " ");
                else if (ch == 'B')
                    sb.Append(numbers[1] + " ");
                else
                    sb.Append(numbers[2] + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}