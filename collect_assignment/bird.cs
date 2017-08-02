namespace collect_assignment
{
    public class bird:Animal
    {
        public bird(string name, int weight, int legs):base("Bird", 1, 2)
        {
            this.moveSpeed = 25;
            this.name = name;
            this.weight = weight;
            this.legs = legs;
        }
        public new void speak()
        {
            System.Console.WriteLine("Squawk!");

        }
    }
}