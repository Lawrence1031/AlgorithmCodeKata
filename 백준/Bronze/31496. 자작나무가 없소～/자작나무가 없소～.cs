namespace _31496
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            string S = inputs[1];
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                string[] itemInfo = Console.ReadLine().Split(' ');
                string itemName = itemInfo[0];
                int itemQuantity = int.Parse(itemInfo[1]);

                string[] words = itemName.Split('_');

                if (Array.Exists(words, word => word == S))
                {
                    count += itemQuantity;
                }
            }

            Console.WriteLine(count);
        }
    }
}