namespace _1284
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 각 숫자 사이에 1cm의 여백
            // 1은 2cm, 0은 4cm, 그 외는 3cm

            while (true)
            {
                string N = Console.ReadLine();

                if (N == "0")
                    return;

                char[] arr = N.ToCharArray();
                int len = 1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '1')
                        len += 2;
                    else if (arr[i] == '0')
                        len += 4;
                    else
                        len += 3;

                    len++;
                }

                Console.WriteLine(len);
            }
        }
    }
}