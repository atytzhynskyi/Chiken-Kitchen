using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Food : Ingredient
    {
        public List<Ingredient> Recipe = new List<Ingredient>();
        public Food(string _Name, params Ingredient[] _Recipe) : base(_Name)
        {
            Recipe.AddRange(_Recipe);
        }
        public Food(string _Name, int _Count, params Ingredient[] _Recipe) : base(_Name, _Count)
        {
            Recipe.AddRange(_Recipe);
        }
        public override void Cook(List<Ingredient> allIngredients)
        {
            if (!isEnoughIngredients(allIngredients))
            {
                Console.WriteLine("We dont have enough ingredients " + Name + " " + Count);
                return;
            }
            CookWithoutCheck(allIngredients);
        }
        public override void CookWithoutCheck(List<Ingredient> allIngredients)
        {
            foreach (Ingredient ingredient in Recipe)
            {
                if (ingredient is Food && Count <= 0)
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
            List<Ingredient> ingredientsFound = new List<Ingredient>();
            ingredientsFound.AddRange(allIngredients);
            foreach (Ingredient ingredientRecipe in Recipe) {
                foreach (Ingredient ingredient in ingredientsFound)
                    if (ingredientRecipe is Food && ingredientRecipe.Name == ingredient.Name)
                        while (ingredientRecipe.Count >= ingredient.Count) ingredient.CookWithoutCheck(ingredientsFound);
            }
            foreach (Ingredient ingredient in ingredientsFound) {
                if (ingredient.Count <= 0) {
                    return false;
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
