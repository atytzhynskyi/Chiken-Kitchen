using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Food : Ingredient
    {
        List<Ingredient> Recipe;
        public Food(string _Name, params Ingredient[] _Recipe) : base(_Name)
        {
            Recipe = new List<Ingredient>();
            Recipe.AddRange(_Recipe);
        }
        public override void Cook(List<Ingredient> allIngredients)
        {
            if (!isEnoughIngredients(allIngredients))
            {
                Console.WriteLine("We dont have enough ingredients " + Name + " " + Count);
                return;
            }
            int i = 0;
            foreach (Ingredient ingredient in Recipe)
            {
                if (ingredient is Food && Count<=0)
                {
                    ingredient.Cook(allIngredients);
                    UseIngredient(allIngredients, ingredient);
                }
                else UseIngredient(allIngredients, ingredient);
            }
            Count++;
        }
        public override bool isEnoughIngredients(List<Ingredient> allIngredients)
        {
            foreach (Ingredient ingredient in Recipe)
            {
                if (ingredient.Count <= 0)
                {
                    if (ingredient is Food)//if the ingredient is food and there are not enough ingredients to cook it then return false
                    {
                        if (ingredient.isEnoughIngredients(allIngredients))
                        {
                            continue;
                        }
                        else return false;
                    }
                    else return false;//else not enough ingredients
                }
            }
            return true;
        }
        private void UseIngredient(List<Ingredient> allIngredients, Ingredient ingredient) {
            foreach(Ingredient i in allIngredients)
            {
                if (i.Name == ingredient.Name)
                {
                    i.Count--;
                    return;
                }
            }
        }
    }
}
