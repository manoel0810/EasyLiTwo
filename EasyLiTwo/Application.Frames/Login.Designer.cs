namespace EasyLiTwo.Application.Frames
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logon = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainImage
            // 
            this.MainImage.Image = ((System.Drawing.Image)(resources.GetObject("MainImage.Image")));
            this.MainImage.Location = new System.Drawing.Point(23, 16);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(174, 174);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.Username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(23, 222);
            this.Username.MaxLength = 20;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(174, 25);
            this.Username.TabIndex = 0;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.Password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(23, 269);
            this.Password.MaxLength = 16;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(174, 25);
            this.Password.TabIndex = 1;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Logon
            // 
            this.Logon.FlatAppearance.BorderSize = 0;
            this.Logon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logon.Location = new System.Drawing.Point(54, 306);
            this.Logon.Name = "Logon";
            this.Logon.Size = new System.Drawing.Size(112, 28);
            this.Logon.TabIndex = 2;
            this.Logon.Text = "Entrar";
            this.Logon.UseVisualStyleBackColor = true;
            this.Logon.Click += new System.EventHandler(this.Logon_Click);
            // 
            // NewUser
            // 
            this.NewUser.AutoSize = true;
            this.NewUser.LinkColor = System.Drawing.Color.Black;
            this.NewUser.Location = new System.Drawing.Point(60, 351);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(101, 13);
            this.NewUser.TabIndex = 6;
            this.NewUser.TabStop = true;
            this.NewUser.Text = "Novo? Cadastre-se!";
            this.NewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUser_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(220, 370);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.Logon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.MainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyLi Two";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Logon;
        private System.Windows.Forms.LinkLabel NewUser;
    }
}

