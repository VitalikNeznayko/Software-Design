namespace ClassLibrary
{
    class PaymentSupportHandler : SupportHandler
    {
        public override void HandleRequest(UserRequest request)
        {
            if (request.IssueType == "billing" && request.SubIssueType == "payment")
            {
                Console.WriteLine("\nРішення: Перевірте правильність платіжних даних або зв’яжіться з банком.\n");
                request.IsHandled = true;
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
