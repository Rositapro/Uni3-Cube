using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni3_Cube
{
    internal class Cube
    {

        private double side;
        private string color;
        private bool isFull;

        // Constructor that receives the cube's side as a parameter
        public Cube(double side, string color, bool isFull)
        {
            this.side = side;
            this.color = color;
            this.isFull = isFull;
        }

        // Destructor
        ~Cube()
        {
            Console.WriteLine("The object has been destroyed.");
        }

        // Default constructor that initializes the cube's side to 0
        public Cube()
        {
            this.side = 0;
            this.color = "White";
            this.isFull = false;
        }

        // Method that only returns the area of the cube
        public double CalculateArea()
        {
            return 6 * Math.Pow(side, 2);
        }

        // Overload
        public double CalculateArea(double newSide)
        {
            side = newSide;
            return 6 * Math.Pow(side, 2);
        }

        // Method with overload that calculates the area of a single face
        public double CalculateArea(int faceNumber)
        {
            if (faceNumber < 1 || faceNumber > 6)
            {
                throw new ArgumentOutOfRangeException("faceNumber", "The face number must be between 1 and 6.");
            }
            return Math.Pow(side, 2);
        }

        // Method that only returns the perimeter of the cube
        public double CalculatePerimeter()
        {
            return 12 * side;
        }

        // Overload
        public double CalculatePerimeter(double newSide)
        {
            side = newSide;
            return 12 * side;
        }

        // Method that only returns the volume of the cube
        public double CalculateVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        // Method that receives a new side for the cube and returns the volume
        public double CalculateVolume(int newSide)
        {
            side = newSide;
            return Math.Pow(side, 3);
        }

        // Method that neither returns nor receives anything, simply prints the current side of the cube
        public void PrintSide()
        {
            Console.WriteLine("Cube properties:");
            Console.WriteLine("The side of the cube is: " + side);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Is full: " + isFull);
        }
    }
}