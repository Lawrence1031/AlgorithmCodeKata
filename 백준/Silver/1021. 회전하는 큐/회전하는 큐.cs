namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            LinkedList<int> deque = new LinkedList<int>(Enumerable.Range(1, N));

            int totalOperations = 0;

            foreach (int target in positions)
            {
                int idx = deque.ToList().IndexOf(target);

                int leftRotations = idx;
                int rightRotations = deque.Count() - idx;

                if (leftRotations <= rightRotations)
                {
                    for (int i = 0; i < leftRotations; i++)
                    {
                        int first = deque.First.Value;
                        deque.RemoveFirst();
                        deque.AddLast(first);
                        totalOperations++;
                    }
                }
                else
                {
                    for (int i = 0; i < rightRotations; i++)
                    {
                        int last = deque.Last.Value;
                        deque.RemoveLast();
                        deque.AddFirst(last);
                        totalOperations++;
                    }
                }

                deque.RemoveFirst();
            }

            Console.WriteLine(totalOperations);
        }
    }
}