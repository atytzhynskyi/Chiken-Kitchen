using System;
using System.Collections.Generic;

namespace Chiken_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> allIngredients = new List<Ingredient> { new Ingredient("water", 10) };
            Food ice = new Food("ice", new Ingredient("water", 1));
            ice.Cook(allIngredients);
            allIngredients.Add(ice);
            Food meltingIce = new Food("melting ice", new Ingredient("water", 1), new Ingredient("ice", 1));
            meltingIce.Cook(allIngredients);
            Console.WriteLine(meltingIce.Name + " " + meltingIce.Count);
            Console.WriteLine(allIngredients[0].Name + " " + allIngredients[0].Count);
            Console.WriteLine(allIngredients[1].Name + " " + allIngredients[1].Count);
        }
    }
}
