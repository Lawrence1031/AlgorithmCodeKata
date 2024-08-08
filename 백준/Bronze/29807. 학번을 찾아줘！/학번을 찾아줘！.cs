namespace _29807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] scores = new int[5];
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < inputs.Length; i++)
            {
                scores[i] = int.Parse(inputs[i]);
            }

            int number = 0;

            if (scores[0] > scores[2])
            {
                number += 508 * (scores[0] - scores[2]);
            }
            else
            {
                number += 108 * (scores[2] - scores[0]);
            }

            if (scores[1] > scores[3])
            {
                number += 212 * (scores[1] - scores[3]);
            }
            else
            {
                number += 305 * (scores[3] - scores[1]);
            }

            number += 707 * scores[4];
            number *= 4763;

            Console.WriteLine(number);
        }
    }
}