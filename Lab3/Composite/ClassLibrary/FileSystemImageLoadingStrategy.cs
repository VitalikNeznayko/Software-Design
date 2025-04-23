namespace ClassLibrary
{
    public class FileSystemImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {

            if (File.Exists(href))
            {
                return href;
            }
            throw new FileNotFoundException($"Image file not found at: {href}");
        }
    }

}
