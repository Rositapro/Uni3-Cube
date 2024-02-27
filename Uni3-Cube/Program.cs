using Uni3_Cube;
class Program
{
    static void Main(string[] args)
    {
        // Constructor that receives the cube's side as a parameter
        double side = 5; // You can change this value to the desired side
        string cubeColor = "Red";
        bool isCubeFull = true;
        Cube cube = new Cube(side, cubeColor, isCubeFull);

        // Default constructor that initializes the cube's side to 0
        Cube defaultCube = new Cube();

        Console.WriteLine("Area of face 4 of the cube: " + cube.CalculateArea(4));
        Console.WriteLine("Area of the cube: " + cube.CalculateArea());
        Console.WriteLine("Perimeter of the cube: " + cube.CalculatePerimeter());
        Console.WriteLine("Volume of the cube: " + cube.CalculateVolume(side));

        double newSide = 10;
        Console.WriteLine("Area of the cube: " + cube.CalculateArea(newSide));
        Console.WriteLine("Perimeter of the cube: " + cube.CalculatePerimeter(newSide));
        Console.WriteLine("Volume of the cube: " + cube.CalculateVolume(newSide));

        // Print the current side of the cube
        cube.PrintSide();
        defaultCube.PrintSide();
        Console.ReadLine();
    }
}



