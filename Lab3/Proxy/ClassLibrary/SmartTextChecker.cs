namespace ClassLibrary
{
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader reader;

        public SmartTextChecker(ITextReader reader)
        {
            this.reader = reader;
        }

        public char[][] ReadText(string filePath)
        {
            Console.WriteLine($"Log: Opening file: {filePath}");

            char[][] result = reader.ReadText(filePath);

            Console.WriteLine($"Log: File read successfully.");
            Console.WriteLine($"Log: Lines: {result.Length}");

            int totalChars = 0;
            foreach (var line in result)
                totalChars += line.Length;

            Console.WriteLine($"Log: Total characters: {totalChars}");
            Console.WriteLine($"Log: Closing file.");

            return result;
        }
    }

}
