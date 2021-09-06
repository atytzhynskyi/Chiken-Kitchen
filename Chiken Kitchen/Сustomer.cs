using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Сustomer
    {
        public string Name;
        public Ingredient Order;
        public List<Ingredient> Allergies = new List<Ingredient>();
        public Сustomer(string _Name, params Ingredient[] _Allergies)
        {
            Name = _Name;
            Allergies.AddRange(_Allergies);
        }
        public Сustomer(string _Name)
        {
            Name = _Name;
        }
        public void SetOrder(Ingredient _Order)
        {
            Order = _Order;
        }
        public void GiveFood(List<Ingredient> allIngredients)
        {
            foreach (Ingredient ingredient in allIngredients)
            {
                if (ingredient.Name == Order.Name)
                {
                    if (ingredient.Count <= 0)
                    {
                        Console.WriteLine("We dont have this food");
                        return;
                    }
                    ingredient.Count--;
                    Console.WriteLine(Name + " get " + ingredient.Name);
                    return;
                }
            }
            Console.WriteLine("Order doesnt exist in Ingedient List");
        }
        public bool isAllergiesFood(List<Ingredient> Recipe) {
            foreach(Ingredient ingredientAllergies in Allergies){
                foreach(Ingredient ingredientRecipe in Recipe){
                    if (ingredientAllergies.Name == ingredientRecipe.Name) return true;
                }
            }
            return false;
        }
    }
}
