using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_PizzaPlace
{   //Factory
    interface IFranchise
    {
        string[] GetPizzas();            //Pizza names will be stored in "list"
        string[] GetPizzaIngredients();  //Pizza ingredients will be stored in "list"
    }
}
