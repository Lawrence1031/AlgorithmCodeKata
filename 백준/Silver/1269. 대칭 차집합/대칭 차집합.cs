using System.Linq;

namespace _1269
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();
            int cnt = 0;

            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < A; i++)
            {
                setA.Add(int.Parse(inputs[i]));
            }

            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < B; i++)
            {
                if (setA.Contains(int.Parse(inputs[i])))
                {
                    cnt++;
                }
            }

            int answer = A + B - (2 * cnt);
            Console.WriteLine(answer);
        }
    }
}