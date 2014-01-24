using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Abstract Product
    interface IPizza
    {
        string GetName();         //will return the pizza name
        string GetIngredients();  //will return the pizza ingredients
    }
}
