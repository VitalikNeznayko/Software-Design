namespace ClassLibrary
{
  public class VectorRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as lines");
        }
    }
}
