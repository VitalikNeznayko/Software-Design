namespace ClassLibrary
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            fileWriter = new FileWriter(filePath);
        }

        public new void Log(string message)
        {
            base.Log(message);
            fileWriter.WriteLine($"LOG: {message}"); 
        }

        public new void Error(string message)
        {
            base.Error(message);
            fileWriter.WriteLine($"ERROR: {message}"); 
        }

        public new void Warn(string message)
        {
            base.Warn(message); 
            fileWriter.WriteLine($"WARN: {message}"); 
        }
    }
}
