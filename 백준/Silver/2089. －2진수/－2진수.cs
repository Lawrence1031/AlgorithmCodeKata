namespace _2089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string answer = "";
            while (N != 0)
            {
                int remainder = N % (-2);
                N /= (-2);

                if (remainder < 0)
                {
                    remainder += 2;
                    N += 1;
                }

                answer = remainder.ToString() + answer;
            }

            Console.WriteLine(answer);
        }
    }
}