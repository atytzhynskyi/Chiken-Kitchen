using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Food : Ingredient
    {
        List<Ingredient> Recipe;
        public Food(string _Name, List<Ingredient> _Recipe) : base(_Name)
        {
            Recipe = _Recipe;
        }
        public override void Cook()
        {
            if (!isEnoughIngredients())
            {
                Console.WriteLine("We dont have enough ingredients");
                return;
            }
            foreach (Ingredient ingredient in Recipe)
            {
                if (ingredient is Food)
                {
                    ingredient.Cook();
                }
                else ingredient.Count -= 1;
            }
        }
        public override bool isEnoughIngredients()
        {
            foreach (Ingredient ingredient in Recipe)
            {
                if (ingredient.Count == 0)
                {
                    if (ingredient is Food)//if the ingredient is food and there are not enough ingredients to cook it then return false
                    {
                        if(!ingredient.isEnoughIngredients()) return false;
                    }
                    else return false;//else not enough ingredients
                }
            }
            return true;
        }
    }
}
