namespace _6841
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                string translation = "";
                switch (input)
                {
                    case "CU": translation = "see you"; break;
                    case ":-)": translation = "I’m happy"; break;
                    case ":-(": translation = "I’m unhappy"; break;
                    case ";-)": translation = "wink"; break;
                    case ":-P": translation = "stick out my tongue"; break;
                    case "(~.~)": translation = "sleepy"; break;
                    case "TA": translation = "totally awesome"; break;
                    case "CCC": translation = "Canadian Computing Competition"; break;
                    case "CUZ": translation = "because"; break;
                    case "TY": translation = "thank-you"; break;
                    case "YW": translation = "you’re welcome"; break;
                    case "TTYL": translation = "talk to you later"; break;
                    default: translation = input; break;
                }

                Console.WriteLine(translation);
            }
        }
    }
}