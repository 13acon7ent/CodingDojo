using System;
using System.Collections.Generic;

namespace FoodsAssignment
{
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 800, false, false),
                new Food("Burger", 950, true, false),
                new Food("Chips", 80, false, false),
                new Food("Onion Rings", 600, false, true),
                new Food("Poutine", 700, false, false),
                new Food("Donair", 190, true, false),
                new Food("Ribs", 500, false, true),
                new Food("Chicken", 340, false, true),

            };
        }
        public Food Serve()
        {
            Random r = new Random();
            return Menu[r.Next(Menu.Count)];
        }

    }
}