namespace ClassLibrary
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            if (Uri.IsWellFormedUriString(href, UriKind.Absolute))
            {
                return href; 
            }
            throw new ArgumentException($"Invalid URL: {href}");
        }
    }

}
