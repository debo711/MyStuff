using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class SFMeatPizza : IPizza
    {
        public string GetName()
        {
            return "The Wild Boar";
        }

        public string GetIngredients()
        {
            return "Spicy Marinara, Fresh Mozzarella, Pepperoni, Salami, Prosciutto,\nand Pancetta";
        }
    }
}
