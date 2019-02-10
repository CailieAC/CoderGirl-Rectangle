using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");

            // Get input from the user and save it to a variable.
            float length = float.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");

            // Get input from the user and save it to a second variable.
            float width = float.Parse(Console.ReadLine());

            // Output - The area of the rectangle is (computed value)
            Console.WriteLine("The area of the rectangle is " + length*width);
            Console.ReadLine();
        }
    }
}
