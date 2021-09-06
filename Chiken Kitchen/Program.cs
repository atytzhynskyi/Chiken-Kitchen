using System;
using System.Collections.Generic;

namespace Chiken_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            A.Add(1);
            ref int a = ref A[0];
            B.Add(a);
            A.Add(2);
            A[0] = 3;
            foreach (int i in B)
            {
                Console.WriteLine(i);
            }
            /*List<Ingredient> allIngredients = new List<Ingredient> { new Ingredient("water", 10) };
             Food ice = new Food("ice", allIngredients);
             ice.Cook();
             allIngredients.Add(ice);
             Console.WriteLine(allIngredients[0].Name + " " + allIngredients[0].Count);
             Console.WriteLine(allIngredients[1].Name + " " + allIngredients[1].Count);
             Food meltingIce = new Food("melting ice", allIngredients);
             meltingIce.Cook();*/
        }
    }
}
