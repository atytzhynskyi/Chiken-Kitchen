using System;
using System.Collections.Generic;

namespace Chiken_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> allIngredients = new List<Ingredient>();
            FillLists.FillBaseIngredients(allIngredients);
            FillLists.FillFoodRecipe(allIngredients);
            List<Customer> customers = new List<Customer>();
            FillLists.FillCustomers(customers);
            foreach(Customer customer in customers)
            {
                if (customer.Name == "Julie Mirage")
                {
                    customer.SetOrder(new Ingredient("Fish In Water"), allIngredients);
                    if (Food.isAllergiesFood(allIngredients, customer.Order, customer)){
                        Console.WriteLine(customer.Order.Name + " is allergic food for " + customer.Name);
                        continue;
                    }
                    if (customer.Order.Count <= 0) customer.Order.Cook(allIngredients);
                    customer.GiveFood(allIngredients);
                }
                if(customer.Name == "Elon Carousel")
                {
                    customer.SetOrder(new Ingredient("Fish In Water"), allIngredients);
                    if (Food.isAllergiesFood(allIngredients, customer.Order, customer))
                    {
                        Console.WriteLine(customer.Order.Name + " is allergic food for " + customer.Name);
                        continue;
                    }
                    if (customer.Order.Count <= 0) customer.Order.Cook(allIngredients);
                    customer.GiveFood(allIngredients);
                }
                if (customer.Name == "Julie Mirage")
                {
                    customer.SetOrder(new Ingredient("Emperor Chicken"), allIngredients);
                    if (Food.isAllergiesFood(allIngredients, customer.Order, customer))
                    {
                        Console.WriteLine(customer.Order.Name + " is allergic food for " + customer.Name);
                        continue;
                    }
                    if (customer.Order.Count <= 0) customer.Order.Cook(allIngredients);
                    customer.GiveFood(allIngredients);
                }
                if (customer.Name == "Bernard Unfortunate")
                {
                    customer.SetOrder(new Ingredient("Emperor Chicken"), allIngredients);
                    if (Food.isAllergiesFood(allIngredients, customer.Order, customer))
                    {
                        Console.WriteLine(customer.Order.Name + " is allergic food for " + customer.Name);
                        continue;
                    }
                    if (customer.Order.Count <= 0) customer.Order.Cook(allIngredients);
                    customer.GiveFood(allIngredients);
                }
            }
        }
    }
}

/*1. Julie Mirage wants to buy Fish In Water. She gets her Fish in Water.
3. Julie Mirage wants to buy Emperor Chicken. She gets her Emperor Chicken.
2. Elon Carousel wants to buy Fish In Water. You have to refuse him service, because one
dependency uses Chocolate and he is allergic to it.
4. Bernard Unfortunate wants to buy Emperor Chicken. You have to refuse him service, because
one dependency uses Potatoes and he is allergic to them.*/
