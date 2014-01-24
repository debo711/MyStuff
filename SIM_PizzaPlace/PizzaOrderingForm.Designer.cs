namespace SIM_PizzaPlace
{
    partial class PizzaOrderingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.CityList = new System.Windows.Forms.ComboBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.VeggiePizzaIngredients = new System.Windows.Forms.Label();
            this.MeatPizzaIngredients = new System.Windows.Forms.Label();
            this.CheesePizzaIngredients = new System.Windows.Forms.Label();
            this.VeggieCheckBox = new System.Windows.Forms.CheckBox();
            this.MeatCheckBox = new System.Windows.Forms.CheckBox();
            this.CheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(58, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(252, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome to Pizza Place!";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Location = new System.Drawing.Point(115, 66);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(143, 13);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Please choose your location:";
            // 
            // CityList
            // 
            this.CityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityList.FormattingEnabled = true;
            this.CityList.Items.AddRange(new object[] {
            "Chicago",
            "New York",
            "San Francisco"});
            this.CityList.Location = new System.Drawing.Point(127, 91);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(121, 21);
            this.CityList.TabIndex = 2;
            this.CityList.SelectedIndexChanged += new System.EventHandler(this.CityMenu_SelectedIndexChanged);
            // 
            // OrderButton
            // 
            this.OrderButton.Enabled = false;
            this.OrderButton.Location = new System.Drawing.Point(127, 350);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(121, 23);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "Place Your Order!";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.VeggiePizzaIngredients);
            this.MenuPanel.Controls.Add(this.MeatPizzaIngredients);
            this.MenuPanel.Controls.Add(this.CheesePizzaIngredients);
            this.MenuPanel.Controls.Add(this.VeggieCheckBox);
            this.MenuPanel.Controls.Add(this.MeatCheckBox);
            this.MenuPanel.Controls.Add(this.CheeseCheckBox);
            this.MenuPanel.Location = new System.Drawing.Point(12, 133);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(344, 182);
            this.MenuPanel.TabIndex = 5;
            this.MenuPanel.Visible = false;
            // 
            // VeggiePizzaIngredients
            // 
            this.VeggiePizzaIngredients.AutoSize = true;
            this.VeggiePizzaIngredients.Location = new System.Drawing.Point(37, 147);
            this.VeggiePizzaIngredients.Name = "VeggiePizzaIngredients";
            this.VeggiePizzaIngredients.Size = new System.Drawing.Size(35, 13);
            this.VeggiePizzaIngredients.TabIndex = 5;
            this.VeggiePizzaIngredients.Text = "label3";
            // 
            // MeatPizzaIngredients
            // 
            this.MeatPizzaIngredients.AutoSize = true;
            this.MeatPizzaIngredients.Location = new System.Drawing.Point(37, 86);
            this.MeatPizzaIngredients.Name = "MeatPizzaIngredients";
            this.MeatPizzaIngredients.Size = new System.Drawing.Size(35, 13);
            this.MeatPizzaIngredients.TabIndex = 4;
            this.MeatPizzaIngredients.Text = "label2";
            // 
            // CheesePizzaIngredients
            // 
            this.CheesePizzaIngredients.AutoSize = true;
            this.CheesePizzaIngredients.Location = new System.Drawing.Point(37, 36);
            this.CheesePizzaIngredients.Name = "CheesePizzaIngredients";
            this.CheesePizzaIngredients.Size = new System.Drawing.Size(35, 13);
            this.CheesePizzaIngredients.TabIndex = 3;
            this.CheesePizzaIngredients.Text = "label1";
            // 
            // VeggieCheckBox
            // 
            this.VeggieCheckBox.AutoSize = true;
            this.VeggieCheckBox.Location = new System.Drawing.Point(19, 127);
            this.VeggieCheckBox.Name = "VeggieCheckBox";
            this.VeggieCheckBox.Size = new System.Drawing.Size(80, 17);
            this.VeggieCheckBox.TabIndex = 2;
            this.VeggieCheckBox.Text = "checkBox3";
            this.VeggieCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeatCheckBox
            // 
            this.MeatCheckBox.AutoSize = true;
            this.MeatCheckBox.Location = new System.Drawing.Point(19, 66);
            this.MeatCheckBox.Name = "MeatCheckBox";
            this.MeatCheckBox.Size = new System.Drawing.Size(80, 17);
            this.MeatCheckBox.TabIndex = 1;
            this.MeatCheckBox.Text = "checkBox2";
            this.MeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheeseCheckBox
            // 
            this.CheeseCheckBox.AutoSize = true;
            this.CheeseCheckBox.Location = new System.Drawing.Point(19, 16);
            this.CheeseCheckBox.Name = "CheeseCheckBox";
            this.CheeseCheckBox.Size = new System.Drawing.Size(80, 17);
            this.CheeseCheckBox.TabIndex = 0;
            this.CheeseCheckBox.Text = "checkBox1";
            this.CheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // PizzaOrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 394);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.CityList);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PizzaOrderingForm";
            this.Text = "Order a Pizza!";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.ComboBox CityList;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.CheckBox MeatCheckBox;
        private System.Windows.Forms.CheckBox CheeseCheckBox;
        private System.Windows.Forms.Label VeggiePizzaIngredients;
        private System.Windows.Forms.Label MeatPizzaIngredients;
        private System.Windows.Forms.Label CheesePizzaIngredients;
        private System.Windows.Forms.CheckBox VeggieCheckBox;
    }
}

