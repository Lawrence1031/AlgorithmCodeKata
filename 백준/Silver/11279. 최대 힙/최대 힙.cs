using System.Linq;
using System.Text;

namespace _11279
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            MaxHeap heap = new MaxHeap();

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    sb.AppendLine(heap.Remove().ToString());
                }
                else
                {
                    heap.Insert(num);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

class MaxHeap
{
    private List<int> heap = new List<int>();

    public void Insert(int value)
    {
        heap.Add(value);
        int current = heap.Count - 1;

        while (current > 0 && heap[current] > heap[(current - 1) / 2])
        {
            int parent = (current - 1) / 2;
            Swap(current, parent);
            current = parent;
        }
    }

    public int Remove()
    {
        if (heap.Count == 0)
            return 0;

        int result = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        int current = 0;
        while (true)
        {
            int left = 2 * current + 1;
            int right = 2 * current + 2;
            int largest = current;

            if (left < heap.Count && heap[left] > heap[largest])
                largest = left;

            if (right < heap.Count && heap[right] > heap[largest])
                largest = right;

            if (largest == current)
                break;

            Swap(current, largest);
            current = largest;
        }

        return result;
    }

    private void Swap(int a, int b)
    {
        int tmp = heap[a];
        heap[a] = heap[b];
        heap[b] = tmp;
    }

}