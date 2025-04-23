namespace ClassLibrary
{
    class RefundSupportHandler : SupportHandler
    {
        public override void HandleRequest(UserRequest request)
        {
            if (request.IssueType == "billing" && request.SubIssueType == "refund")
            {
                Console.WriteLine("Рішення: Заповніть форму для повернення на нашому сайті.");
                request.IsHandled = true;
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
