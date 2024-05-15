namespace _4619
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0] == "0")
                {
                    return;
                }

                int B = int.Parse(inputs[0]);
                int N = int.Parse(inputs[1]);

                int A = 1;
                int closetA = A;
                double minDifference = Math.Abs(Math.Pow(A, N) - B);

                while (true)
                {
                    double power = Math.Pow(A, N);
                    double difference = Math.Abs(power - B);

                    if (difference < minDifference)
                    {
                        minDifference = difference;
                        closetA = A;
                    }
                    else if (power > B)
                    {
                        break;
                    }

                    A++;
                }

                Console.WriteLine(closetA);
            }
        }
    }
}