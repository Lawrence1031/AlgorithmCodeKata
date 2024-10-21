namespace _31520
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i].ToString()) == num)
                {
                    num++;
                }
                else
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            Console.WriteLine(num - 1);
        }
    }
}