namespace ClassLibrary
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public bool IsBusy { get; set; }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
