namespace EasyLiTwo.Application.Frames
{
    partial class PasswordConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordConfirmation));
            this.label6 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LbPassword2 = new System.Windows.Forms.Label();
            this.LbPassword1 = new System.Windows.Forms.Label();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbPassword3 = new System.Windows.Forms.Label();
            this.Password3 = new System.Windows.Forms.TextBox();
            this.BarraTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Confirmar senha";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.CloseButton);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(577, 47);
            this.BarraTitulo.TabIndex = 17;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(532, 9);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LbPassword2
            // 
            this.LbPassword2.AutoSize = true;
            this.LbPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbPassword2.Location = new System.Drawing.Point(147, 106);
            this.LbPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPassword2.Name = "LbPassword2";
            this.LbPassword2.Size = new System.Drawing.Size(68, 20);
            this.LbPassword2.TabIndex = 26;
            this.LbPassword2.Text = "Repetir:";
            // 
            // LbPassword1
            // 
            this.LbPassword1.AutoSize = true;
            this.LbPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbPassword1.Location = new System.Drawing.Point(147, 70);
            this.LbPassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPassword1.Name = "LbPassword1";
            this.LbPassword1.Size = new System.Drawing.Size(61, 20);
            this.LbPassword1.TabIndex = 25;
            this.LbPassword1.Text = "Senha:";
            // 
            // Password2
            // 
            this.Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password2.Location = new System.Drawing.Point(239, 101);
            this.Password2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password2.MaxLength = 4;
            this.Password2.Name = "Password2";
            this.Password2.PasswordChar = '•';
            this.Password2.Size = new System.Drawing.Size(191, 26);
            this.Password2.TabIndex = 1;
            this.Password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password2_KeyPress);
            // 
            // Password1
            // 
            this.Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password1.Location = new System.Drawing.Point(239, 67);
            this.Password1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password1.MaxLength = 4;
            this.Password1.Name = "Password1";
            this.Password1.PasswordChar = '•';
            this.Password1.Size = new System.Drawing.Size(191, 26);
            this.Password1.TabIndex = 0;
            this.Password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password1_KeyPress);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(140, 200);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(133, 43);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(303, 200);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(133, 43);
            this.Save.TabIndex = 3;
            this.Save.Text = "Confirmar";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Password1);
            this.panel1.Controls.Add(this.BarraTitulo);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Password3);
            this.panel1.Controls.Add(this.Password2);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.LbPassword1);
            this.panel1.Controls.Add(this.LbPassword3);
            this.panel1.Controls.Add(this.LbPassword2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 260);
            this.panel1.TabIndex = 27;
            // 
            // LbPassword3
            // 
            this.LbPassword3.AutoSize = true;
            this.LbPassword3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbPassword3.Location = new System.Drawing.Point(147, 140);
            this.LbPassword3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPassword3.Name = "LbPassword3";
            this.LbPassword3.Size = new System.Drawing.Size(61, 20);
            this.LbPassword3.TabIndex = 26;
            this.LbPassword3.Text = "Antiga:";
            this.LbPassword3.Visible = false;
            // 
            // Password3
            // 
            this.Password3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password3.Location = new System.Drawing.Point(239, 135);
            this.Password3.Margin = new System.Windows.Forms.Padding(4);
            this.Password3.MaxLength = 4;
            this.Password3.Name = "Password3";
            this.Password3.PasswordChar = '•';
            this.Password3.Size = new System.Drawing.Size(191, 26);
            this.Password3.TabIndex = 2;
            this.Password3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password3.Visible = false;
            this.Password3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password2_KeyPress);
            // 
            // PasswordConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 260);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmação";
            this.Load += new System.EventHandler(this.PasswordConfirmation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordConfirmation_KeyDown);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LbPassword2;
        private System.Windows.Forms.Label LbPassword1;
        public System.Windows.Forms.TextBox Password2;
        public System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Password3;
        private System.Windows.Forms.Label LbPassword3;
    }
}