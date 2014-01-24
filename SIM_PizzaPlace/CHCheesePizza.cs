using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class CHCheesePizza : IPizza
    {
        public string GetName()
        {
            return "The Cheesy Common"; 
        }

        public string GetIngredients()
        {
            return "Nothing but our Fresh Marinara and tons of Mozzarella";
        }
    }
}
