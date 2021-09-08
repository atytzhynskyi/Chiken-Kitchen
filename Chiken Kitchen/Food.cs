using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Food : Ingredient
    {
        public List<Ingredient> Recipe = new List<Ingredient>();
        public override List<Ingredient> GetRecipe() => Recipe;

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
                }
                UseIngredient(allIngredients, ingredient);
            }
            Count++;
        }
        private void UseIngredient(List<Ingredient> allIngredients, Ingredient ingredientRecipe)
        {
            foreach (Ingredient ingredient in allIngredients)
            {
                if (ingredient.Name == ingredientRecipe.Name)
                {
                    ingredient.Count -= ingredientRecipe.Count;
                    return;
                }
            }
        }
        public override bool isEnoughIngredients(List<Ingredient> allIngredients)
        {
            List<Ingredient> ingredientsCopy = new List<Ingredient>();
            ingredientsCopy.AddRange(allIngredients);
            CookWithoutCheck(ingredientsCopy);//cook food by recipe
            foreach (Ingredient ingredientRecipe in Recipe){
                foreach (Ingredient ingredient in ingredientsCopy)
                    if (ingredient is Food && ingredientRecipe.Name == ingredient.Name)
                        while (ingredientRecipe.Count >= ingredient.Count) ingredient.CookWithoutCheck(ingredientsCopy);
            }
            foreach (Ingredient ingredient in ingredientsCopy){
                if (ingredient.Count<0){
                    Console.WriteLine("We dont have enough ingredients " + ingredient.Name + " " + ingredient.Count);
                    return false;
                }
                foreach (Ingredient ingredientRecipe in Recipe)
                    if (ingredient.Name == ingredientRecipe.Name && ingredient.Count <= ingredientRecipe.Count){
                        Console.WriteLine("We cant cook " + Name);
                        Console.WriteLine("We dont have enough ingredients " + ingredient.Name + " " + ingredient.Count);
                        return false;
                    }
            }
            return true;
        }
        static public bool isAllergiesFood(List<Ingredient> allIngredients, Ingredient customerOrder, Customer customer)
        {
            foreach (Ingredient ingredient in allIngredients) //Set ingredient from allIngredient as customerOrder to set a Recipe
                if (customerOrder.Name == ingredient.Name){
                    customerOrder = ingredient;
                    break;
                }
            foreach (Ingredient ingredient in customerOrder.GetRecipe()){
                foreach (Ingredient allergiesIngredient in customer.Allergies)
                    if (ingredient.Name == allergiesIngredient.Name){
                        return true;
                    }
                if (isAllergiesFood(allIngredients, ingredient, customer)) return true;
            }
            return false;
        }
    }
}
