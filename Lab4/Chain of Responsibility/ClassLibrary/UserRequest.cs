namespace ClassLibrary
{
    class UserRequest
    {
        public string IssueType { get; set; }
        public string SubIssueType { get; set; }
        public bool IsHandled { get; set; }
        private readonly SupportSystem system;

        public UserRequest(SupportSystem system)
        {
            this.system = system;
            IsHandled = false;
        }

        public void Restart()
        {
            IsHandled = false;
            IssueType = null;
            SubIssueType = null;
            system.StartMenu();
        }
    }
}
