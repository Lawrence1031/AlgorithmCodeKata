namespace _16503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n1 = int.Parse(inputs[0]);
            int n2 = int.Parse(inputs[2]);
            int n3 = int.Parse(inputs[4]);
            string c1 = inputs[1];
            string c2 = inputs[3];

            int answer1 = Calcul(n1, n2, c1);
            answer1 = Calcul(answer1, n3, c2);
            int answer2 = Calcul(n2, n3, c2);
            answer2 = Calcul(n1, answer2, c1);

            Console.WriteLine(Math.Min(answer1, answer2));
            Console.WriteLine(Math.Max(answer1, answer2));
        }

        static int Calcul(int n1, int n2, string c1)
        {
            if (c1 == "+")
            {
                return n1 + n2;
            }
            else if (c1 == "-")
            {
                return n1 - n2;
            }
            else if (c1 == "*")
            {
                return n1 * n2;
            }
            else
            {
                return n1 / n2;
            }
        }
    }
}