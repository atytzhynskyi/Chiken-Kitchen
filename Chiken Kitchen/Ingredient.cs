using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Ingredient
    {
        public string Name;
        public int Count;
        public Ingredient(string _Name, int _Count)
        {
            Name = _Name;
            Count = _Count;
        }
        public Ingredient(string _Name)
        {
            Name = _Name;
        }
        public virtual void Cook(List<Ingredient> allIngredients) 
        {
            throw new NotImplementedException();
        }
        public virtual void CookWithoutCheck(List<Ingredient> allIngredients)
        {
            throw new NotImplementedException();
        }

        public virtual bool isEnoughIngredients(List<Ingredient> allIngredients)
        {
            throw new NotImplementedException();
        }
    }
}
