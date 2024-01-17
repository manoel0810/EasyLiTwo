namespace EasyLiTwo.Application.Frames
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.label5 = new System.Windows.Forms.Label();
            this.GuidCode = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UserBirthday = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LockAndUnlockUser = new System.Windows.Forms.CheckBox();
            this.UpdatePassword = new System.Windows.Forms.LinkLabel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(25, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID";
            // 
            // GuidCode
            // 
            this.GuidCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuidCode.Location = new System.Drawing.Point(117, 84);
            this.GuidCode.Name = "GuidCode";
            this.GuidCode.ReadOnly = true;
            this.GuidCode.Size = new System.Drawing.Size(267, 23);
            this.GuidCode.TabIndex = 0;
            this.GuidCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(177, 247);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 35);
            this.Cancel.TabIndex = 5;
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
            this.Save.Location = new System.Drawing.Point(299, 247);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 35);
            this.Save.TabIndex = 4;
            this.Save.Text = "Salvar";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome:";
            // 
            // UserEmail
            // 
            this.UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmail.Location = new System.Drawing.Point(117, 140);
            this.UserEmail.MaxLength = 120;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(267, 23);
            this.UserEmail.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(117, 111);
            this.Username.MaxLength = 120;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(267, 23);
            this.Username.TabIndex = 1;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.CloseButton);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(577, 38);
            this.BarraTitulo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Form Cliente";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(547, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // UserBirthday
            // 
            this.UserBirthday.Location = new System.Drawing.Point(117, 172);
            this.UserBirthday.Name = "UserBirthday";
            this.UserBirthday.Size = new System.Drawing.Size(267, 20);
            this.UserBirthday.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyLiTwo.Properties.Resources.icon_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(411, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // LockAndUnlockUser
            // 
            this.LockAndUnlockUser.AutoSize = true;
            this.LockAndUnlockUser.Location = new System.Drawing.Point(28, 205);
            this.LockAndUnlockUser.Name = "LockAndUnlockUser";
            this.LockAndUnlockUser.Size = new System.Drawing.Size(68, 17);
            this.LockAndUnlockUser.TabIndex = 30;
            this.LockAndUnlockUser.Text = "Bloquear";
            this.LockAndUnlockUser.UseVisualStyleBackColor = true;
            this.LockAndUnlockUser.Visible = false;
            this.LockAndUnlockUser.CheckedChanged += new System.EventHandler(this.LockAndUnlockUser_CheckedChanged);
            // 
            // UpdatePassword
            // 
            this.UpdatePassword.AutoSize = true;
            this.UpdatePassword.LinkColor = System.Drawing.Color.Black;
            this.UpdatePassword.Location = new System.Drawing.Point(305, 68);
            this.UpdatePassword.Name = "UpdatePassword";
            this.UpdatePassword.Size = new System.Drawing.Size(79, 13);
            this.UpdatePassword.TabIndex = 31;
            this.UpdatePassword.TabStop = true;
            this.UpdatePassword.Text = "Atualizar senha";
            this.UpdatePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdatePassword_LinkClicked);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 294);
            this.Controls.Add(this.UpdatePassword);
            this.Controls.Add(this.LockAndUnlockUser);
            this.Controls.Add(this.UserBirthday);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GuidCode);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditUser_KeyDown);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox GuidCode;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox UserEmail;
        public System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DateTimePicker UserBirthday;
        private System.Windows.Forms.CheckBox LockAndUnlockUser;
        private System.Windows.Forms.LinkLabel UpdatePassword;
    }
}