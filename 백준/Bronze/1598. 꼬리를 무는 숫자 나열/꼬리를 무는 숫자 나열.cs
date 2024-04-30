namespace _1598
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            int aRow = (a - 1) % 4 + 1;
            int aCol = (a - 1) / 4 + 1;
            int bRow = (b - 1) % 4 + 1;
            int bCol = (b - 1) / 4 + 1;

            int rowDistance = Math.Abs(aRow - bRow);
            int colDistance = Math.Abs(aCol - bCol);

            Console.WriteLine(rowDistance + colDistance);
        }
    }
}