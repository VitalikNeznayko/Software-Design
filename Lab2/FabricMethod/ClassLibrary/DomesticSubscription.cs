namespace ClassLibrary
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base("Домашня", 16)
        {
            Channels.AddRange(new List<string> { "Новини", "Фільми", "Мультфільми" });
            Features.Add("Full HD якість");
        }
    }
}
