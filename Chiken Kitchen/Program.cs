using System;
using System.Collections.Generic;

namespace Chiken_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void FillBaseIngredients(List<Ingredient> allIngredients)
        {
            string[] BaseIngredients = "Chicken, Tuna, Potatoes, Asparagus, Milk, Honey, Paprika, Garlic, Water, Lemon, Tomatoes, Pickles, Feta, Vinegar, Rice, Chocolate".Split(", ");
            foreach(string i in BaseIngredients)
            {
                allIngredients.Add(new Ingredient(i, 10));
            }
        } // Tomatoes, Pickles, Feta
        static void FillFoodRecipe(List<Ingredient> allIngredients)
        {
            allIngredients.Add(new Food("Emperor Chicken", new Food("Fat Cat Chiken"), new Food("Spicy Sauce"), new Food("Tuna Cake")));
            allIngredients.Add(new Food("Fat Cat Chiken", new Food("Princess Chicken"), new Food("Youth Sauce"), new Food("Tuna Cake")));
            allIngredients.Add(new Food("Princess Chicken", new Food("Chicken"), new Food("Youth Sauce")));
            allIngredients.Add(new Food("Youth Sauce", new Food("Asparagus"), new Food("Milk"), new Food("Honey")));
            allIngredients.Add(new Food("Spicy Sauce", new Food("Paprika"), new Food("Garlic"), new Food("Water")));
            allIngredients.Add(new Food("Omega Sauce", new Food("Lemon"), new Food("Water")));
            allIngredients.Add(new Food("Diamond Salad", new Food("Tomatoes"), new Food("Pickles"), new Food("Feta")));
            allIngredients.Add(new Food("Ruby Salad", new Food("Tomatoes"), new Food("Vinegar")));
            allIngredients.Add(new Food("Fries", new Food("Potatoes")));
            allIngredients.Add(new Food("Smashed Potatoes", new Food("Potatoes")));
            allIngredients.Add(new Food("Tuna Cake", new Food("Tuna"), new Food("Chocolate"), new Food("Youth Sauce")));
            allIngredients.Add(new Food("Fish In Water", new Food("Tuna"), new Food("Omega Sauce"), new Food("Ruby Salad")));
        }
    }
}
