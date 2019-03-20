using System;

namespace human {
    public class Human
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string givenname) 
        {
            name = givenname;
            strength = 5;
            intelligence = 5;
            dexterity = 5;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
         public void attack(object target)
        {
            Orc enemy = target as Orc;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
    
    public class Orc
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Orc(string givenname) 
        {
            name = givenname;
            strength = 15;
            intelligence = 3;
            dexterity = 7;
            health = 200;
        }
        public Orc(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
         public void attack(object target)
        {
            Human enemy = target as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
}