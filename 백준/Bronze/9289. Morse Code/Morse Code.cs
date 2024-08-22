namespace _9289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string text = "";
                for (int j = 0; j < inputs.Length; j++)
                {
                    text += MorseText(inputs[j]);
                }
                Console.WriteLine($"Case {i + 1}: {text}");
            }
        }

        static string MorseText(string text)
        {
            switch (text)
            {
                case ".-": return "A";
                case "-...": return "B";
                case "-.-.": return "C";
                case "-..": return "D";
                case ".": return "E";
                case "..-.": return "F";
                case "--.": return "G";
                case "....": return "H";
                case "..": return "I";
                case ".---": return "J";
                case "-.-": return "K";
                case ".-..": return "L";
                case "--": return "M";
                case "-.": return "N";
                case "---": return "O";
                case ".--.": return "P";
                case "--.-": return "Q";
                case ".-.": return "R";
                case "...": return "S";
                case "-": return "T";
                case "..-": return "U";
                case "...-": return "V";
                case ".--": return "W";
                case "-..-": return "X";
                case "-.--": return "Y";
                case "--..": return "Z";
                default:
                    return "";
            }
        }
    }
}