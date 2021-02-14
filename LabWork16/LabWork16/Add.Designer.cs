namespace LabWork16
{
    partial class Add
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
            this.nameText = new System.Windows.Forms.Label();
            this.breedText = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(118, 15);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(75, 13);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "Имя питомца";
            // 
            // breedText
            // 
            this.breedText.AutoSize = true;
            this.breedText.Location = new System.Drawing.Point(118, 41);
            this.breedText.Name = "breedText";
            this.breedText.Size = new System.Drawing.Size(91, 13);
            this.breedText.TabIndex = 1;
            this.breedText.Text = "Порода питомца";
            // 
            // ageText
            // 
            this.ageText.AutoSize = true;
            this.ageText.Location = new System.Drawing.Point(118, 67);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(49, 13);
            this.ageText.TabIndex = 2;
            this.ageText.Text = "Возраст";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // breedTextBox
            // 
            this.breedTextBox.Location = new System.Drawing.Point(12, 38);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(100, 20);
            this.breedTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(12, 64);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Info;
            this.addButton.Location = new System.Drawing.Point(12, 90);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(214, 125);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.breedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.breedText);
            this.Controls.Add(this.nameText);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(230, 164);
            this.MinimumSize = new System.Drawing.Size(230, 164);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label breedText;
        private System.Windows.Forms.Label ageText;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox breedTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button addButton;
    }
}