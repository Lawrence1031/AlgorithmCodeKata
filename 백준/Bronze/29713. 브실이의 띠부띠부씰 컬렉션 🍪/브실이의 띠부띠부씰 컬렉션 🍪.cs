namespace _29713
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (char c = 'A';  c <= 'Z'; c++)
            {
                dict[c] = 0;
            }

            for (int i = 0; i < N; i++)
            {
                dict[input[i]]++;
            }

            int BValue = dict['B'];
            int RValue = dict['R'] / 2;
            int OValue = dict['O'];
            int NValue = dict['N'];
            int ZValue = dict['Z'];
            int EValue = dict['E'] / 2;
            int SValue = dict['S'];
            int IValue = dict['I'];
            int LValue = dict['L'];
            int VValue = dict['V'];

            int[] values = { BValue , RValue, OValue, NValue, ZValue, 
                             EValue, SValue, IValue, LValue, VValue };
            Console.WriteLine(values.Min());
        }
    }
}