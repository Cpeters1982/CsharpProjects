namespace collect_assignment
{
    public class dog:Animal
    {
        public dog(string name, int weight, int legs):base("Dog", 10, 4)
        {
            this.moveSpeed = 6;
            this.name = name;
            this.weight = weight;
            this.legs = legs;
            System.Console.WriteLine();
        }
        public new void speak()
        {
            System.Console.WriteLine("Woof!");
        }
    }
}