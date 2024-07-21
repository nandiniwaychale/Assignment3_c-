using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(10.5f, 20.7f, 30.2f);

            Console.WriteLine("Printing x, y, and z individually:");
            Console.WriteLine($"X: {point.ToString("X", null)}");
            Console.WriteLine($"Y: {point.ToString("Y", null)}");
            Console.WriteLine($"Z: {point.ToString("Z", null)}");

            Console.WriteLine("\nPrinting combined using default format:");
            Console.WriteLine(point); // Calls ToString() implicitly

            Console.WriteLine("\nPrinting combined using general format:");
            Console.WriteLine(point.ToString("G", null));
        }
    }
}

