namespace _4388
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                if (inputs[0] == "0" && inputs[1] == "0")
                {
                    return;
                }

                if (inputs[0] == "0" || inputs[1] == "0")
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int a = int.Parse(inputs[0]);
                    int b = int.Parse(inputs[1]);

                    Console.WriteLine(CarryCnt(a, b));
                }
            }

            static int CarryCnt(int a, int b)
            {
                int cnt = 0;
                int carry = 0;

                while (a > 0 || b > 0)
                {
                    int sum = a % 10 + b % 10 + carry;

                    if (sum >= 10)
                    {
                        cnt++;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }

                    a /= 10;
                    b /= 10;
                }

                return cnt;
            }
        }
    }
}