using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class NYMeatPizza : IPizza
    {
        public string GetName()
        {
            return "The Meat Lover's";
        }

        public string GetIngredients()
        {
            return "Our Special Sauce, Mozzarella, tons of Sausage, Ham,\nPepperoni, and Ground Beef";
        }
    }
}
