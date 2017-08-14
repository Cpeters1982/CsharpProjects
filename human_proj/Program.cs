using System;

namespace human_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Human one = new Human("Jean Claude Van-Damme",50,50,50,1000);
            Human two = new Human("Arnold Schwarzenegger",50,50,50,1000);
            one.Attack(two);
            System.Console.WriteLine($"{one.name} knocked {two.name}'s health down to {two.health}");
        }
    }
}
