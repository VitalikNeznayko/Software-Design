using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader reader;
        private readonly Regex denyPattern;

        public SmartTextReaderLocker(ITextReader reader, string denyRegex)
        {
            this.reader = reader;
            denyPattern = new Regex(denyRegex, RegexOptions.IgnoreCase);
        }

        public char[][] ReadText(string filePath)
        {
            if (denyPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return reader.ReadText(filePath);
        }
    }

}
