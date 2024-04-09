namespace _1107
{
    internal class Program
    {
        static bool[] broken = new bool[10];
        static void Main(string[] args)
        {
            // 리모컨

            // 리모컨에 버튼이 0부터 9까지, +와 -가 있다.
            // 현재 채널이 100일 때, 이동하려는 채널 N이 주어지면
            // 그 채널 N으로 이동하는 가장 적은 횟수를 return 하시오.
            // 이 때, 고장난 버튼이 존재하며 이를 알려준다.

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            if (M > 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                foreach (var input in inputs)
                {
                    broken[int.Parse(input)] = true;
                }
            }

            int minPress = Math.Abs(N - 100);

            for (int i = 0; i <= 1000000; i++)
            {
                int length = CanPress(i);
                if (length > 0)
                {
                    int press = Math.Abs(i - N);
                    minPress = Math.Min(minPress, length + press);                    
                }
            }

            Console.WriteLine(minPress);
        }

        static int CanPress(int n)
        {
            if (n == 0)
            {
                return broken[0] ? 0 : 1;
            }

            int length = 0;
            while (n > 0)
            {
                if (broken[n % 10])
                {
                    return 0;
                }
                length++;
                n /= 10;
            }
            return length;
        }
    }
}