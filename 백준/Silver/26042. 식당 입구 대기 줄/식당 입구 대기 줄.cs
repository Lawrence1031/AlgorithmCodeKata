namespace _26042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int maxCnt = 0;
            int last = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                if (inputs[0] == "1")
                {
                    int studentNum = int.Parse(inputs[1]);
                    queue.Enqueue(studentNum);

                    if (queue.Count > maxCnt)
                    {
                        maxCnt = queue.Count;
                        last = studentNum;
                    }
                    else if (queue.Count == maxCnt)
                    {
                        last = Math.Min(last, studentNum);
                    }
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine($"{maxCnt} {last}");
        }
    }
}