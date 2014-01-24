using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class NYVeggiePizza : IPizza
    {
        public string GetName()
        {
            return "The Veggie Delight";
        }

        public string GetIngredients()
        {
            return string.Format("Our Special Sauce, Mozzarella, Grilled Eggplant, Grilled Onions,\n" +
                "Grilled Zuchinni, Grilled Portobellos, and Grilled Red Peppers"); 
        }
    }
}
