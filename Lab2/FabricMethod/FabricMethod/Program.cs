using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        SubscriptionFactory website = new WebSite();
        SubscriptionFactory mobileApp = new MobileApp();
        SubscriptionFactory managerCall = new ManagerCall();

        try
        {
            Subscription domestic = website.CreateSubscription("Domestic");
            domestic.DisplayInfo();
            Subscription education = mobileApp.CreateSubscription("Educational");
            education.DisplayInfo();
            Subscription premium = managerCall.CreateSubscription("Premium");
            premium.DisplayInfo();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}