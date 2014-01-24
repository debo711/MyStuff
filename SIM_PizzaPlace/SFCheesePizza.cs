using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class SFCheesePizza : IPizza
    {
        public string GetName()
        {
            return "The Bianca";
        }

        public string GetIngredients()
        {
            return "Spicy Marinara, Mozzarella di Bufala, and Provolone Piccante";
        }
    }
}
