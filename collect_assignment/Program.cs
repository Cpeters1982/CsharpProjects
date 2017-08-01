using System;

namespace collect_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            dog rex = new dog("Muggsy", 75, 4);
            rex.move();
            rex.speak();
            System.Console.WriteLine(rex.position);

            bird tweety = new bird("Tweety", 2, 2);
            tweety.move();
            tweety.move();
            tweety.speak();
            System.Console.WriteLine("Tweety flew " + tweety.position + " feet!");
        }
    }
}
