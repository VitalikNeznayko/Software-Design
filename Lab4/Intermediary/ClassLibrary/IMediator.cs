namespace ClassLibrary
{
    public interface IMediator
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
        void RegisterRunway(Runway runway);
        void RegisterAircraft(Aircraft aircraft);
    }

}
