using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class SFVeggiePizza : IPizza
    {
        public string GetName()
        {
            return "The Magic Pie";
        }

        public string GetIngredients()
        {
            return "Pesto, Mozzarella, Garlic, Cherry Tomatoes, Arugula, and\nSweet Yellow and Red Peppers";  
        }
    }
}
