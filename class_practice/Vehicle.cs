namespace class_practice
{
    public class Vehicle
    // defines a new class
    {
    public int numPassenger;
    // sets an attribute
    public double distance;

    public int wheels;

    public Vehicle(int val = 0, int whe = 0) {
        // constructor! when a class is created, it's constructor is called. 
        // They usually initialize data members of the new object.
        numPassenger = val;
        distance = 0.0;
        wheels = whe;
    }
    public void Move(double miles){
        distance += miles;

    }
    }
}