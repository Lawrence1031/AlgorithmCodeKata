namespace _1357
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string X = inputs[0];
            string Y = inputs[1];

            int sum = Rev(X) + Rev(Y);
            Console.WriteLine(Rev(sum));
        }

        static int Rev(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return int.Parse(new string(charArray));
        }

        static int Rev(int num)
        {
            return Rev(num.ToString());
        }
    }
}