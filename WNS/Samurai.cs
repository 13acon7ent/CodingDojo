using System;
namespace Heroes
{
    class Samurai : Human
    {
        // Samurai should have a default health of 200	
        public Samurai(string name) : base(name, 3, 3, 3, 200) 
        {
        }
        public override int Attack(Human target)
        {
            int remainingHealth = Attack(target);
            if(remainingHealth < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{target.Name} HAS BEEN BRUTALIZED!");
            }
            return remainingHealth;
        }
        public void Meditate()
        {
            Console.WriteLine("Samurai is Meditating...");
            health = 200;
        }
    }
}