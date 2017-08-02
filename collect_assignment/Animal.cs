namespace collect_assignment
{
    public abstract class Animal
    {
        public int weight;
        public int legs;
        public string name;
        public int position = 0;
        public int moveSpeed = 1;


        public Animal (string name, int  weight, int legs)
        {
            this.name = name;
            this.weight = weight;
            this.legs = legs;
        }
        public void speak()
        {
        
        }
        public void move()
        {
            this.position += this.moveSpeed;
        }
    }
}