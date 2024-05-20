using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _1672
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string DNASequence = Console.ReadLine();

            char[,] decodeTable =
            {
                { 'A', 'C', 'A', 'G' },
                { 'C', 'G', 'T', 'A' },
                { 'A', 'T', 'C', 'G' },
                { 'G', 'A', 'G', 'T' }
            };

            char result = DNASequence[N - 1];
            for (int i = N - 2; i >= 0; i--)
            {
                char first = DNASequence[i];
                char second = result;

                int row = GetIdx(first);
                int col = GetIdx(second);

                result = decodeTable[row, col];
            }

            Console.WriteLine(result);
        }

        static int GetIdx(char nucleotide)
        {
            switch (nucleotide)
            {
                case 'A': return 0;
                case 'G': return 1;
                case 'C': return 2;
                case 'T': return 3;
                default: return 99;
            }
        }
    }
}