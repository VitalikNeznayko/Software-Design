namespace ClassLibrary
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private readonly IMediator mediator;

        public Aircraft(string name, IMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
            mediator.RegisterAircraft(this);
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to land.");
            mediator.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to take off.");
            IsTakingOff = true;
            mediator.RequestTakeOff(this);
        }
    }
}
