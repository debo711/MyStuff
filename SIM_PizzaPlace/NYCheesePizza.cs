using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class NYCheesePizza : IPizza
    {
        public string GetName()
        {
            return "The White Pizza";
        }

        public string GetIngredients()
        {
            return "Basil Pesto, Fresh Mozzarella, Provolone, and Goat Cheese\nCrumbles"; 
        }
    }
}
