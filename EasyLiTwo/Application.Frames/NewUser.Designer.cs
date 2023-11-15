namespace EasyLiTwo.Application.Frames
{
    partial class NewUser
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
            this.UserFullName_Needed = new System.Windows.Forms.TextBox();
            this.Nickname_Needed = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.UserTypes_Needed = new System.Windows.Forms.ComboBox();
            this.TryReg = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Password_Needed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RepeatPassword_Needed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserFullName_Needed
            // 
            this.UserFullName_Needed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UserFullName_Needed.Location = new System.Drawing.Point(12, 23);
            this.UserFullName_Needed.MaxLength = 64;
            this.UserFullName_Needed.Name = "UserFullName_Needed";
            this.UserFullName_Needed.Size = new System.Drawing.Size(263, 20);
            this.UserFullName_Needed.TabIndex = 0;
            // 
            // Nickname_Needed
            // 
            this.Nickname_Needed.Location = new System.Drawing.Point(281, 23);
            this.Nickname_Needed.MaxLength = 20;
            this.Nickname_Needed.Name = "Nickname_Needed";
            this.Nickname_Needed.Size = new System.Drawing.Size(112, 20);
            this.Nickname_Needed.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 66);
            this.Email.MaxLength = 64;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(381, 20);
            this.Email.TabIndex = 2;
            // 
            // UserTypes_Needed
            // 
            this.UserTypes_Needed.FormattingEnabled = true;
            this.UserTypes_Needed.Location = new System.Drawing.Point(293, 107);
            this.UserTypes_Needed.Name = "UserTypes_Needed";
            this.UserTypes_Needed.Size = new System.Drawing.Size(100, 21);
            this.UserTypes_Needed.TabIndex = 5;
            // 
            // TryReg
            // 
            this.TryReg.Location = new System.Drawing.Point(318, 152);
            this.TryReg.Name = "TryReg";
            this.TryReg.Size = new System.Drawing.Size(75, 23);
            this.TryReg.TabIndex = 6;
            this.TryReg.Text = "Registrar";
            this.TryReg.UseVisualStyleBackColor = true;
            this.TryReg.Click += new System.EventHandler(this.TryReg_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(236, 152);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Voltar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome completo*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo acesso*";
            // 
            // Password_Needed
            // 
            this.Password_Needed.Location = new System.Drawing.Point(12, 108);
            this.Password_Needed.MaxLength = 24;
            this.Password_Needed.Name = "Password_Needed";
            this.Password_Needed.PasswordChar = '•';
            this.Password_Needed.Size = new System.Drawing.Size(100, 20);
            this.Password_Needed.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha*";
            // 
            // RepeatPassword_Needed
            // 
            this.RepeatPassword_Needed.Location = new System.Drawing.Point(118, 108);
            this.RepeatPassword_Needed.MaxLength = 24;
            this.RepeatPassword_Needed.Name = "RepeatPassword_Needed";
            this.RepeatPassword_Needed.PasswordChar = '•';
            this.RepeatPassword_Needed.Size = new System.Drawing.Size(100, 20);
            this.RepeatPassword_Needed.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Senha*";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 189);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TryReg);
            this.Controls.Add(this.UserTypes_Needed);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.RepeatPassword_Needed);
            this.Controls.Add(this.Password_Needed);
            this.Controls.Add(this.Nickname_Needed);
            this.Controls.Add(this.UserFullName_Needed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo usuário";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Nickname_Needed;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox UserTypes_Needed;
        private System.Windows.Forms.Button TryReg;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Password_Needed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RepeatPassword_Needed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserFullName_Needed;
    }
}