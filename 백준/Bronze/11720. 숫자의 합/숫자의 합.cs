namespace _11720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int answer = 0;

            string s1 = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(s1[i] - '0');
                answer += arr[i];
            }
            Console.WriteLine(answer);
        }
    }
}