namespace _1592
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int L = int.Parse(inputs[2]);

            // 사람 N명, 한 사람이 M번 받으면 종료
            // 공을 받은 횟수가 홀수면 시계(+)로 L, 짝수면 반시계(-)로 L

            int[] arr = new int[N];
            int cur = 0;
            int throwCnt = 0;

            while (true)
            {
                arr[cur]++;

                if (arr[cur] == M)
                {
                    Console.WriteLine(throwCnt);
                    return;
                }

                if (arr[cur] % 2 == 1)
                {
                    cur = (cur + L) % N;
                }
                else
                {
                    cur = (cur - L + N) % N;
                }

                throwCnt++;
            }
        }
    }
}