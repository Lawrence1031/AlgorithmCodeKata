namespace _9243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string before = Console.ReadLine();
            string after = Console.ReadLine();

            for (int i = 0; i < before.Length; i++)
            {
                if (N % 2 == 0)
                {
                    if (before[i] != after[i])
                    {
                        Console.WriteLine("Deletion failed");
                        return;
                    }
                }
                else
                {
                    if (before[i] == after[i])
                    {
                        Console.WriteLine("Deletion failed");
                        return;
                    }
                }
            }

            Console.WriteLine("Deletion succeeded");
        }
    }
}