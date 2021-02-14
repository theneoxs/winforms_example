namespace LabWork16
{
    partial class Authorization
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
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.auth = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(33, 12);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(117, 20);
            this.logBox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(33, 38);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(117, 20);
            this.passBox.TabIndex = 1;
            // 
            // auth
            // 
            this.auth.Location = new System.Drawing.Point(62, 76);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(88, 23);
            this.auth.TabIndex = 2;
            this.auth.Text = "Авторизация";
            this.auth.UseVisualStyleBackColor = true;
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(62, 105);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(88, 23);
            this.registration.TabIndex = 3;
            this.registration.Text = "Регистрация";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // logText
            // 
            this.logText.AutoSize = true;
            this.logText.Location = new System.Drawing.Point(156, 15);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(38, 13);
            this.logText.TabIndex = 4;
            this.logText.Text = "Логин";
            // 
            // passText
            // 
            this.passText.AutoSize = true;
            this.passText.Location = new System.Drawing.Point(156, 41);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(45, 13);
            this.passText.TabIndex = 5;
            this.passText.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 140);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.logBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(235, 179);
            this.MinimumSize = new System.Drawing.Size(235, 179);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button auth;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label logText;
        private System.Windows.Forms.Label passText;
        private System.Windows.Forms.TextBox passBox;
    }
}