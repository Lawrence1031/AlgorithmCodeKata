namespace _2630
{
    internal class Program
    {
        static int whiteCnt = 0;
        static int blueCnt = 0;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = int.Parse(inputs[j]);
                }
            }

            DivideAndConquer(arr, 0, 0, N);

            Console.WriteLine(whiteCnt);
            Console.WriteLine(blueCnt);
        }

        static void DivideAndConquer(int[,] arr, int startX, int startY, int size)
        {
            bool isSameColor = true;
            int color = arr[startX, startY];

            for (int i = startX; i < startX + size; i++)
            {
                for (int j = startY; j < startY + size; j++)
                {
                    if (arr[i, j] != color)
                    {
                        isSameColor = false;
                        break;
                    }
                }
                if (!isSameColor)
                {
                    break;
                }
            }
            
            if (isSameColor)
            {
                if (color == 0) whiteCnt++;
                else blueCnt++;
            }
            else
            {
                int newSize = size / 2;
                DivideAndConquer(arr, startX, startY, newSize);
                DivideAndConquer(arr, startX + newSize, startY, newSize);
                DivideAndConquer(arr, startX, startY + newSize, newSize);
                DivideAndConquer(arr, startX + newSize, startY + newSize, newSize);
            }
        }
    }
}