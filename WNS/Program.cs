using System;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human nick = new Human("Nick");
            Wizard gerold = new Wizard("Gerold");
            Ninja cam = new Ninja("Cam");
            Samurai timmy = new Samurai("Timmy");

            nick.Attack(gerold);
            gerold.Attack(cam);
            timmy.Meditate();
            cam.Steal(timmy);
            gerold.Heal(nick);


        }
    }
}
