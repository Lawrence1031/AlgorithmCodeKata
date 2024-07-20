namespace _17450
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sStatus = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] nStatus = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] uStatus = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sPrice = 10 * sStatus[0];
            int nPrice = 10 * nStatus[0];
            int uPrice = 10 * uStatus[0];

            sPrice = sPrice >= 5000 ? sPrice - 500 : sPrice;
            nPrice = nPrice >= 5000 ? nPrice - 500 : nPrice;
            uPrice = uPrice >= 5000 ? uPrice - 500 : uPrice;

            double sPercent = (double)(10 * sStatus[1]) / sPrice;
            double nPercent = (double)(10 * nStatus[1]) / nPrice;
            double uPercent = (double)(10 * uStatus[1]) / uPrice;

            double answer = Math.Max(sPercent, Math.Max(nPercent, uPercent));

            if (answer == sPercent) Console.WriteLine("S");
            else if (answer == nPercent) Console.WriteLine("N");
            else if (answer == uPercent) Console.WriteLine("U");
        }
    }
}