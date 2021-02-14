namespace LabWork16
{
    partial class Delete
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
            this.ID_text = new System.Windows.Forms.Label();
            this.deleteButtom = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ID_text
            // 
            this.ID_text.AutoSize = true;
            this.ID_text.Location = new System.Drawing.Point(118, 15);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(18, 13);
            this.ID_text.TabIndex = 1;
            this.ID_text.Text = "ID";
            // 
            // deleteButtom
            // 
            this.deleteButtom.BackColor = System.Drawing.SystemColors.Info;
            this.deleteButtom.Location = new System.Drawing.Point(12, 38);
            this.deleteButtom.Name = "deleteButtom";
            this.deleteButtom.Size = new System.Drawing.Size(75, 23);
            this.deleteButtom.TabIndex = 2;
            this.deleteButtom.Text = "Удалить";
            this.deleteButtom.UseVisualStyleBackColor = false;
            this.deleteButtom.Click += new System.EventHandler(this.deleteButtom_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(175, 71);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteButtom);
            this.Controls.Add(this.ID_text);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(191, 110);
            this.MinimumSize = new System.Drawing.Size(191, 110);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ID_text;
        private System.Windows.Forms.Button deleteButtom;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}