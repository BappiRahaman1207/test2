namespace MyWinApps
{
    partial class Home
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
            this.ComboBoxButton = new System.Windows.Forms.Button();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.PersonalInformationButton = new System.Windows.Forms.Button();
            this.CoffeeShopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxButton
            // 
            this.ComboBoxButton.Location = new System.Drawing.Point(49, 95);
            this.ComboBoxButton.Name = "ComboBoxButton";
            this.ComboBoxButton.Size = new System.Drawing.Size(75, 23);
            this.ComboBoxButton.TabIndex = 0;
            this.ComboBoxButton.Text = "ComboBox";
            this.ComboBoxButton.UseVisualStyleBackColor = true;
            this.ComboBoxButton.Click += new System.EventHandler(this.ComboBoxButton_Click);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Location = new System.Drawing.Point(174, 95);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.CalculatorButton.TabIndex = 0;
            this.CalculatorButton.Text = "Calculator";
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // PersonalInformationButton
            // 
            this.PersonalInformationButton.Location = new System.Drawing.Point(285, 95);
            this.PersonalInformationButton.Name = "PersonalInformationButton";
            this.PersonalInformationButton.Size = new System.Drawing.Size(128, 23);
            this.PersonalInformationButton.TabIndex = 1;
            this.PersonalInformationButton.Text = "Personal Information";
            this.PersonalInformationButton.UseVisualStyleBackColor = true;
            this.PersonalInformationButton.Click += new System.EventHandler(this.PersonalInformationButton_Click);
            // 
            // CoffeeShopButton
            // 
            this.CoffeeShopButton.Location = new System.Drawing.Point(457, 94);
            this.CoffeeShopButton.Name = "CoffeeShopButton";
            this.CoffeeShopButton.Size = new System.Drawing.Size(75, 23);
            this.CoffeeShopButton.TabIndex = 2;
            this.CoffeeShopButton.Text = "Coffee Shop";
            this.CoffeeShopButton.UseVisualStyleBackColor = true;
            this.CoffeeShopButton.Click += new System.EventHandler(this.CoffeeShopButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoffeeShopButton);
            this.Controls.Add(this.PersonalInformationButton);
            this.Controls.Add(this.CalculatorButton);
            this.Controls.Add(this.ComboBoxButton);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComboBoxButton;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Button PersonalInformationButton;
        private System.Windows.Forms.Button CoffeeShopButton;
    }
}

