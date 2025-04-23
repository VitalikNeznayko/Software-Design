namespace ClassLibrary
{
    public class SupportSystem
    {
        private readonly SupportHandler chain;

        public SupportSystem()
        {
            chain = new DeviceSupportHandler();
            var network = new NetworkSupportHandler();
            var payment = new PaymentSupportHandler();
            var refund = new RefundSupportHandler();

            chain.SetNext(network);
            network.SetNext(payment);
            payment.SetNext(refund);
        }

        public void StartMenu()
        {
            var request = new UserRequest(this);
            while (!request.IsHandled)
            {
                Console.WriteLine("\n=== Система підтримки користувачів ===");
                Console.WriteLine("Виберіть тип вашої проблеми:");
                Console.WriteLine("1. Технічні проблеми (проблеми з пристроєм, мережею)");
                Console.WriteLine("2. Фінансові питання (платежі, повернення)");
                Console.Write("Ваш вибір (1-2): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        request.IssueType = "technical";
                        HandleTechnicalIssue(request);
                        break;
                    case "2":
                        request.IssueType = "billing";
                        HandleBillingIssue(request);
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір. Будь ласка, виберіть число від 1 до 2.");
                        break;
                }
            }
        }

        private void HandleTechnicalIssue(UserRequest request)
        {
            Console.WriteLine("\n=== Уточнення технічної проблеми ===");
            Console.WriteLine("Виберіть конкретну проблему:");
            Console.WriteLine("1. Проблеми з пристроєм");
            Console.WriteLine("2. Проблеми з мережею");
            Console.Write("Ваш вибір (1-2): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    request.SubIssueType = "device";
                    chain.HandleRequest(request);
                    break;
                case "2":
                    request.SubIssueType = "network";
                    chain.HandleRequest(request);
                    break;
                default:
                    Console.WriteLine("Некоректний вибір. Будь ласка, виберіть число від 1 до 2.");
                    HandleTechnicalIssue(request);
                    break;
            }
        }

        private void HandleBillingIssue(UserRequest request)
        {
            Console.WriteLine("\n=== Уточнення фінансової проблеми ===");
            Console.WriteLine("Виберіть конкретну проблему:");
            Console.WriteLine("1. Проблеми з платежами");
            Console.WriteLine("2. Проблеми з поверненням коштів");
            Console.Write("Ваш вибір (1-2): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    request.SubIssueType = "payment";
                    chain.HandleRequest(request);
                    break;
                case "2":
                    request.SubIssueType = "refund";
                    chain.HandleRequest(request);
                    break;
                default:
                    Console.WriteLine("Некоректний вибір. Будь ласка, виберіть число від 1 до 2.");
                    HandleBillingIssue(request);
                    break;
            }
        }
    }
}
