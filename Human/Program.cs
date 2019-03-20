using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human nick = new Human("Nick");
            Orc NewOrc = new Orc("Orc1");
            Console.WriteLine("#########################################");
            Console.WriteLine("Starting battle...");
            Console.WriteLine("#########################################");
            Console.WriteLine("Character Name: " + nick.name 
            + " Health: " + nick.health);
            Console.WriteLine("Character Name: " + NewOrc.name 
            + " Health: " + NewOrc.health);

            Console.WriteLine(nick.name + " is attacking " + NewOrc.name);
            nick.attack(NewOrc);

            Console.WriteLine("Character Name: " + nick.name 
            + " Health: " + nick.health);
            Console.WriteLine("Character Name: " + NewOrc.name 
            + " Health: " + NewOrc.health);

            Console.WriteLine(nick.name + " is attacking " + NewOrc.name);
            nick.attack(NewOrc);
            Console.WriteLine(NewOrc.name + " is attacking " + nick.name);
            NewOrc.attack(nick);

            Console.WriteLine("Character Name: " + nick.name 
            + " Health: " + nick.health);
            Console.WriteLine("Character Name: " + NewOrc.name 
            + " Health: " + NewOrc.health);

            Console.WriteLine(nick.name + " is attacking " + NewOrc.name);
            nick.attack(NewOrc);
            Console.WriteLine(NewOrc.name + " is attacking " + nick.name);
            NewOrc.attack(nick);

            Console.WriteLine("Character Name: " + nick.name 
            + " Health: " + nick.health);
            Console.WriteLine("Character Name: " + NewOrc.name 
            + " Health: " + NewOrc.health);
            Console.WriteLine("#########################################");

        }
    }
}