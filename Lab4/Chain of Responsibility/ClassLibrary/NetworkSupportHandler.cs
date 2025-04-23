namespace ClassLibrary
{
    class NetworkSupportHandler : SupportHandler
    {
        public override void HandleRequest(UserRequest request)
        {
            if (request.IssueType == "technical" && request.SubIssueType == "network")
            {
                Console.WriteLine("\nРішення: Перевірте підключення до Wi-Fi або зверніться до провайдера.\n");
                request.IsHandled = true;
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
