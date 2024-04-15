namespace _2908
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string strA = inputs[0];
            string strB = inputs[1];

            char[] charA = strA.ToCharArray();
            char[] charB = strB.ToCharArray();

            Array.Reverse(charA);
            Array.Reverse(charB);

            string reversedA = new string(charA);
            string reversedB = new string(charB);

            int A = int.Parse(reversedA);
            int B = int.Parse(reversedB);

            int answer = A >= B ? A : B;

            Console.WriteLine(answer);
        }
    }
}