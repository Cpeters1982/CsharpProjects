using System;

namespace class_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Where we instantiate our class
            Vehicle myCar = new Vehicle(3, 4);
            Vehicle myBike = new Vehicle(1, 2);
            System.Console.WriteLine(myCar.numPassenger);
            System.Console.WriteLine(myBike.numPassenger);
            System.Console.WriteLine();
            myBike.Move(1.3);
            myCar.Move(4.5);
            System.Console.WriteLine($"My bike went {myBike.distance} miles and my car went {myCar.distance} miles.");
            System.Console.WriteLine($"My car has {myCar.numPassenger} passengers and {myCar.wheels} wheels.");
        }
    }
}