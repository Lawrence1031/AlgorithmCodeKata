namespace _2863
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            double A = double.Parse(inputs[0]);
            double B = double.Parse(inputs[1]);
            inputs = Console.ReadLine().Split(' ');
            double C = double.Parse(inputs[0]);
            double D = double.Parse(inputs[1]);
            double[] arr = new double[4];
            arr[0] = A / C + B / D;
            arr[1] = C / D + A / B;
            arr[2] = D / B + C / A;
            arr[3] = B / A + D / C;

            if (arr.Max() == arr[0]) Console.WriteLine(0);
            else if (arr.Max() == arr[1]) Console.WriteLine(1);
            else if (arr.Max() == arr[2]) Console.WriteLine(2);
            else Console.WriteLine(3);
        }
    }
}