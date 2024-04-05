namespace _15829
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[L];
            int answer = 0;

            string s = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = s[i] - 96;
                answer += (arr[i] * (int)Math.Pow(31, i)) % 1234567891;
            }

            Console.WriteLine(answer);
        }
    }
}