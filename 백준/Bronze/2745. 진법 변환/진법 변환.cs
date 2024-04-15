namespace _2745
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string N = inputs[0];
            int B = int.Parse(inputs[1]);
            char[] chars = N.ToCharArray();
            double answer = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                int digit = 0;
                if (chars[i] >= '0' && chars[i] <= '9')
                {
                    digit = chars[i] - '0';
                }
                else
                {
                    digit = chars[i] - 'A' + 10;
                }

                answer += digit * Math.Pow(B, chars.Length - i - 1);
            }

            Console.WriteLine(answer);
        }
    }
}