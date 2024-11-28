namespace _27541
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            string answer = "";

            if (S[N - 1] == 'G')
            {
                answer = S.Substring(0, N - 1);
            }
            else
            {
                answer = new string(S + 'G');
            }

            Console.WriteLine(answer);
        }
    }
}