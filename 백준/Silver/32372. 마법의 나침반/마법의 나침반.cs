namespace _32372
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            List<int> answerX = Enumerable.Range(1, N).ToList();
            List<int> answerY = Enumerable.Range(1, N).ToList();


            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);
                int direction = int.Parse(inputs[2]);

                switch (direction)
                {
                    case 1: 
                        answerX = answerX.Where(pos => pos < x).ToList();
                        answerY = answerY.Where(pos => pos == y).ToList();
                        break;
                    case 2:
                        answerX = answerX.Where(pos => pos < x).ToList();
                        answerY = answerY.Where(pos => pos > y).ToList();
                        break;
                    case 3:
                        answerX = answerX.Where(pos => pos == x).ToList();
                        answerY = answerY.Where(pos => pos > y).ToList();
                        break;
                    case 4:
                        answerX = answerX.Where(pos => pos > x).ToList();
                        answerY = answerY.Where(pos => pos > y).ToList();
                        break;
                    case 5:
                        answerX = answerX.Where(pos => pos > x).ToList();
                        answerY = answerY.Where(pos => pos == y).ToList();
                        break;
                    case 6:
                        answerX = answerX.Where(pos => pos > x).ToList();
                        answerY = answerY.Where(pos => pos < y).ToList();
                        break;
                    case 7:
                        answerX = answerX.Where(pos => pos == x).ToList();
                        answerY = answerY.Where(pos => pos < y).ToList();
                        break;
                    case 8:
                        answerX = answerX.Where(pos => pos < x).ToList();
                        answerY = answerY.Where(pos => pos < y).ToList();
                        break;
                }
            }

            Console.WriteLine($"{answerX[0]} {answerY[0]}");
        }
    }
}