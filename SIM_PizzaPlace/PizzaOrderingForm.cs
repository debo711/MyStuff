using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_PizzaPlace
{
    public partial class PizzaOrderingForm : Form
    {
        private IFranchise pizzaFranchise = null;

        public PizzaOrderingForm()
        {
            InitializeComponent();
        }

        //"Client"
        private void CityMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string franchise = CityList.SelectedItem.ToString();

            ShowMenuFor(franchise);            //will get the pizzas available depending in location chosen
            CheeseCheckBox.Checked = false;    //will uncheck checkboxes if user wishes to change their location
            MeatCheckBox.Checked = false;
            VeggieCheckBox.Checked = false;
        }

        private void ShowMenuFor(string franchiseLocation)  
        {
            switch (franchiseLocation)                   //will create a franchise depending on location chosen
            {
                case "Chicago":
                    pizzaFranchise = new ChicagoFranchise();
                    break;
                case "San Francisco":
                    pizzaFranchise = new SanFranciscoFranchise();
                    break;
                case "New York":
                    pizzaFranchise = new NewYorkFranchise();
                    break;
            }

            ChangeCheckBoxNames(pizzaFranchise);         //pizza options change depending on franchise location
            ChangeIngredientsLabels(pizzaFranchise);     //ingredients change depending on franchise location  

            MenuPanel.Visible = true;                    //makes menu visible after user has chosen their location
            OrderButton.Enabled = true;                  
        }

        private void ChangeCheckBoxNames(IFranchise franchise)
        {
            string[] pizzaNameArray;

            pizzaNameArray = franchise.GetPizzas();      //gets pizza names for the selected franchise
            CheeseCheckBox.Text = pizzaNameArray[0];
            MeatCheckBox.Text = pizzaNameArray[1];
            VeggieCheckBox.Text = pizzaNameArray[2];
        }

        private void ChangeIngredientsLabels(IFranchise franchise)
        {
            string[] ingredientsArray;

            ingredientsArray = franchise.GetPizzaIngredients();  //gets ingredients for each pizza at that location
            CheesePizzaIngredients.Text = ingredientsArray[0];
            MeatPizzaIngredients.Text = ingredientsArray[1];
            VeggiePizzaIngredients.Text = ingredientsArray[2];
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            //if no pizzas are chosen
            if (!CheeseCheckBox.Checked && !MeatCheckBox.Checked && !VeggieCheckBox.Checked)
            {
                MessageBox.Show("Please select pizza(s) to order", "Order Incomplete", MessageBoxButtons.OK);
            }
            else
            {
                string displayMessage = "You have succesfully placed your order for:\n\n\t  ";

                if (CheeseCheckBox.Checked)
                {
                    displayMessage += CheeseCheckBox.Text + "\n\t  ";
                }
                if (MeatCheckBox.Checked)
                {
                    displayMessage += MeatCheckBox.Text + "\n\t  ";
                }
                if (VeggieCheckBox.Checked)
                {
                    displayMessage += VeggieCheckBox.Text + "\n";
                }

                displayMessage += "\n\t             Thank You!";

                MessageBox.Show(displayMessage, "Order Successful", MessageBoxButtons.OK);
                this.Close();           //will close ordering form once order is complete
            }
        }
    }
}
