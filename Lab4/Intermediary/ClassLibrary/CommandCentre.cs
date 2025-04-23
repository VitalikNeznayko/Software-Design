namespace ClassLibrary
{
    public class CommandCentre : IMediator
    {
        private readonly List<Runway> runways = new List<Runway>();
        private readonly List<Aircraft> aircrafts = new List<Aircraft>();
        private readonly Dictionary<Aircraft, Runway> aircraftRunwayMap = new Dictionary<Aircraft, Runway>();

        public void RegisterRunway(Runway runway)
        {
            runways.Add(runway);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircrafts.Add(aircraft);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            var runway = runways.Find(r => !r.IsBusy);
            if (runway != null)
            {
                Console.WriteLine($"Runway {runway.Id} is available for landing.");
                runway.IsBusy = true;
                runway.HighLightRed();
                aircraftRunwayMap[aircraft] = runway;
                Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}.");
            }
            else
            {
                Console.WriteLine($"Could not land, all runways are busy for aircraft {aircraft.Name}.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            if (aircraftRunwayMap.TryGetValue(aircraft, out var runway))
            {
                runway.IsBusy = false;
                runway.HighLightGreen();
                aircraftRunwayMap.Remove(aircraft);
                aircraft.IsTakingOff = false;
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
