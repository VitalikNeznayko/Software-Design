namespace ClassLibrary
{
    class DeviceSupportHandler : SupportHandler
    {
        public override void HandleRequest(UserRequest request)
        {
            if (request.IssueType == "technical" && request.SubIssueType == "device")
            {
                Console.WriteLine("\nРішення: Перезапустіть пристрій або перевірте оновлення прошивки.\n");
                request.IsHandled = true;
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
