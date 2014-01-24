using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class CHVeggiePizza : IPizza
    {
        public string GetName()
        {
            return "The Rich Rockie Fresh";
        }

        public string GetIngredients()
        {
            return string.Format("Fresh Marinara, Mozzarella, Green and Red Peppers, Olives\nMushrooms," +
                " and Parmesan");
        }
    }
}
