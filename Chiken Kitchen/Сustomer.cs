using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Customer
    {
        public string Name;
        public Ingredient Order;
        public List<Ingredient> Allergies = new List<Ingredient>();
        public Customer(string _Name, params Ingredient[] _Allergies)
        {
            Name = _Name;
            Allergies.AddRange(_Allergies);
        }
        public Customer(string _Name)
        {
            Name = _Name;
        }
        public void SetOrder(Ingredient _Order, List<Ingredient> allIngredients)
        {
            foreach(Ingredient ingredient in allIngredients)
            {
                if (_Order.Name == ingredient.Name)
                {
                    Order = ingredient;
                    Order.Count = 1;
                }
            }
        }
        public void SetOrder(Ingredient _Order, List<Ingredient> allIngredients, int OrderCount)
        {
            foreach (Ingredient ingredient in allIngredients)
            {
                if (_Order.Name == ingredient.Name)
                {
                    Order = ingredient;
                    Order.Count = OrderCount;
                }
            }
        }
        public void GiveFood(List<Ingredient> allIngredients)
        {
            foreach (Ingredient ingredient in allIngredients)
            {
                if (ingredient.Name == Order.Name)
                {
                    if (ingredient.Count < Order.Count)
                    {
                        Console.WriteLine("We dont have " +Order.Name);
                        return;
                    }
                    ingredient.Count-=Order.Count;
                    Console.WriteLine(Name + " get " + ingredient.Name);
                    return;
                }
            }
            Console.WriteLine("Order doesnt exist in Ingedient List");
        }
    }
}
