namespace _1100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            for (int i = 0; i < 8; i++)
            {
                string input = Console.ReadLine();
                char[] arr = input.ToCharArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    if ((i + j) % 2 == 0 && arr[j] == 'F')
                    {
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}