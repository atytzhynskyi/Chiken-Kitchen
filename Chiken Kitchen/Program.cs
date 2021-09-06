using System;
using System.Collections.Generic;

namespace Chiken_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> water = new List<Ingredient> { new Ingredient("water", 10) };
            Food ice = new Food("ice", water);
        }
    }
}
