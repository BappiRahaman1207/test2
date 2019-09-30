namespace MyWinApps
{
    partial class List
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
            this.BackButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.ShowRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(629, 54);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(79, 112);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddTextBox.TabIndex = 1;
            // 
            // ShowRichTextBox
            // 
            this.ShowRichTextBox.Location = new System.Drawing.Point(79, 151);
            this.ShowRichTextBox.Name = "ShowRichTextBox";
            this.ShowRichTextBox.Size = new System.Drawing.Size(223, 205);
            this.ShowRichTextBox.TabIndex = 2;
            this.ShowRichTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(216, 112);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowRichTextBox);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.BackButton);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.RichTextBox ShowRichTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}