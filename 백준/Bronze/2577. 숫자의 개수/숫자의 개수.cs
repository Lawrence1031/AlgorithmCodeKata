namespace _2577
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = a * b * c;
            char[] charArr = d.ToString().ToCharArray();

            int[] intArr = new int[10];

            for (int i = 0; i < charArr.Length; i++)
            {
                int tmp = Convert.ToInt32(charArr[i]) - '0';

                for (int j = 0; j < intArr.Length; j++)
                {
                    if (tmp == j)
                    {
                        intArr[j]++;
                    }
                }            
            }

            foreach (int i in intArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}