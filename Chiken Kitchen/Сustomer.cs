using System;
using System.Collections.Generic;
using System.Text;

namespace Chiken_Kitchen
{
    class Сustomer
    {
        public string Name;
        public List<Ingredient> Allergies;
        public Сustomer(string _Name, params Ingredient[] _Allergies)
        {
            Name = _Name;
            Allergies.AddRange(_Allergies);
        }
        public Сustomer(string _Name)
        {
            Name = _Name;
        }
    }
}
