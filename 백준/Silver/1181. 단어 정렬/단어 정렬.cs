namespace _1181
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            var list = arr.Distinct()
                          .OrderBy(item => item.Length)
                          .ThenBy(item => item)
                          .ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}