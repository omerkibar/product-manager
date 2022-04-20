namespace ProductManager
{
    partial class RegisterForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxRegisterUsername = new System.Windows.Forms.TextBox();
            this.tbxRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbxRegisterCPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnMySQL = new System.Windows.Forms.RadioButton();
            this.rbtnMSSQL = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(129, 204);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(102, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxRegisterUsername
            // 
            this.tbxRegisterUsername.Location = new System.Drawing.Point(129, 26);
            this.tbxRegisterUsername.Name = "tbxRegisterUsername";
            this.tbxRegisterUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxRegisterUsername.TabIndex = 1;
            // 
            // tbxRegisterPassword
            // 
            this.tbxRegisterPassword.Location = new System.Drawing.Point(129, 76);
            this.tbxRegisterPassword.Name = "tbxRegisterPassword";
            this.tbxRegisterPassword.PasswordChar = '*';
            this.tbxRegisterPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxRegisterPassword.TabIndex = 2;
            // 
            // tbxRegisterCPassword
            // 
            this.tbxRegisterCPassword.Location = new System.Drawing.Point(129, 128);
            this.tbxRegisterCPassword.Name = "tbxRegisterCPassword";
            this.tbxRegisterCPassword.PasswordChar = '*';
            this.tbxRegisterCPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxRegisterCPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // rbtnMySQL
            // 
            this.rbtnMySQL.AutoSize = true;
            this.rbtnMySQL.ForeColor = System.Drawing.Color.OrangeRed;
            this.rbtnMySQL.Location = new System.Drawing.Point(129, 171);
            this.rbtnMySQL.Name = "rbtnMySQL";
            this.rbtnMySQL.Size = new System.Drawing.Size(60, 17);
            this.rbtnMySQL.TabIndex = 5;
            this.rbtnMySQL.TabStop = true;
            this.rbtnMySQL.Text = "MySQL";
            this.rbtnMySQL.UseVisualStyleBackColor = true;
            // 
            // rbtnMSSQL
            // 
            this.rbtnMSSQL.AutoSize = true;
            this.rbtnMSSQL.ForeColor = System.Drawing.Color.OrangeRed;
            this.rbtnMSSQL.Location = new System.Drawing.Point(35, 171);
            this.rbtnMSSQL.Name = "rbtnMSSQL";
            this.rbtnMSSQL.Size = new System.Drawing.Size(62, 17);
            this.rbtnMSSQL.TabIndex = 4;
            this.rbtnMSSQL.TabStop = true;
            this.rbtnMSSQL.Text = "MSSQL";
            this.rbtnMSSQL.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(254, 248);
            this.Controls.Add(this.rbtnMSSQL);
            this.Controls.Add(this.rbtnMySQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRegisterCPassword);
            this.Controls.Add(this.tbxRegisterPassword);
            this.Controls.Add(this.tbxRegisterUsername);
            this.Controls.Add(this.btnRegister);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxRegisterUsername;
        private System.Windows.Forms.TextBox tbxRegisterPassword;
        private System.Windows.Forms.TextBox tbxRegisterCPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnMySQL;
        private System.Windows.Forms.RadioButton rbtnMSSQL;
    }
}