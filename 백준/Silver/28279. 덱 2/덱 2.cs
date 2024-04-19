using System.Text;

namespace _28279
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Deck deck = new Deck();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string command = inputs[0];

                switch (command)
                {
                    case "1":
                        deck.PushFront(int.Parse(inputs[1]));
                        break;
                    case "2":
                        deck.PushBack(int.Parse(inputs[1]));
                        break;
                    case "3":
                        sb.AppendLine(deck.PopFront().ToString());
                        break;
                    case "4":
                        sb.AppendLine(deck.PopBack().ToString());
                        break;
                    case "5":
                        sb.AppendLine(deck.Size().ToString());
                        break;
                    case "6":
                        sb.AppendLine(deck.IsEmpty() ? "1" : "0");
                        break;
                    case "7":
                        sb.AppendLine(deck.Front().ToString());
                        break;
                    case "8":
                        sb.AppendLine(deck.Back().ToString());
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }

    class Deck
    {
        private LinkedList<int> list;

        public Deck()
        {
            list = new LinkedList<int>();
        }

        public void PushFront(int value)
        {
            list.AddFirst(value);
        }
        public void PushBack(int value)
        {
            list.AddLast(value);
        }
        public int PopFront()
        {
            if (list.Count == 0) return -1;

            int front = list.First.Value;
            list.RemoveFirst();
            return front;
        }
        public int PopBack()
        {
            if (list.Count == 0) return -1;

            int back = list.Last.Value;
            list.RemoveLast();
            return back;
        }
        public int Front()
        {
            if (list.Count == 0) return -1;

            return list.First.Value;
        }
        public int Back()
        {
            if (list.Count == 0) return -1;

            return list.Last.Value;
        }
        public int Size()
        {
            return list.Count;
        }
        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}