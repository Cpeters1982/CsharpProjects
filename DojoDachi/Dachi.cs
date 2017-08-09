using System;

namespace DojoDachi
{
    public class dachi
    {
        public int happiness { get; set; }
        public int fullness { set; get; }
        public int meals { get; set; }
        public int energy { set; get; }
        public string status { get; set; }
        public dachi()
        {
            happiness = 20;
            fullness = 20;
            energy = 50;
            meals = 3;
            status = "You caught a new Dachi! Let's see what she does!";
        }
        public dachi feed()
        {
            Random rando = new Random();
            this.meals -= 1;
            if(rando.Next(0,4) != 0)
            {
                int amt = rando.Next(5,10);
                this.fullness += amt;
                this.status = $"Your Dachi just fed and is {amt} more full!";
            }
            else
            {
                this.status = $"Your Dachi didn't wanna eat...";
            }
            return this;
        }
        public dachi work()
        {
            Random rando = new Random();
            this.energy -= 5;
            int amt = rando.Next(1,4);
            this.meals += amt;
            this.status = $"Your dachi worked really hard! She got {amt} meals. Nom-Nom!";
            return this;
        }
        public dachi play()
        {
            this.energy -= 5;
            Random rando = new Random();
            if(rando.Next(0,4) != 0){
                int amt = rando.Next(5, 11);
                this.happiness += amt;
                this.status = $"Your Dachi just played and is {amt} happier!";
            }
            else
            {
                this.status = $"Your dachi didn't want to play :(";
            }
            return this;
        }

        public dachi sleep()
        {
            this.energy += 15;
            this.fullness -= 5;
            this.happiness -= 5;
            this.status = "Your Dachi slept like the dead! (Don't worry, she's not actually dead...";
            if (fullness < 0 || happiness < 0)
            {
                this.status = "Your Dachi has passed away. Rest in Power, Dachi!";
            }
            return this;
        }    
    }
}
