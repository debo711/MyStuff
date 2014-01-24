using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Concrete Product
    class CHMeatPizza : IPizza
    {
        public string GetName()
        {
            return "The Tender Kanye West";
        }

        public string GetIngredients()
        {
            return string.Format("Fresh Marinara, Mozzarella, Italian Sausage, Canadian Bacon,\nAndouille"
            + " Sausage,and Pepperoni");
        }
        
    }
}
