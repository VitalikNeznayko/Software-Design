using ClassLibrary;

public class Program
{
    public static void Main()
    {
        IRenderer vector = new VectorRenderer();
        Shape circle = new Circle(vector);
        Shape square = new Square(vector);
        circle.Draw(); 
        square.Draw(); 

        IRenderer raster = new RasterRenderer();
        Shape triangle = new Triangle(raster);
        triangle.Draw();

        Shape squarePixels = new Square(raster);
        squarePixels.Draw(); 
    }
}