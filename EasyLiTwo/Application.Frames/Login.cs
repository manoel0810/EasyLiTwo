using EasyLiTwo.AuxiliaryClasses;
using System;
using System.Threading;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class Login : Form
    {
        LoginAuxiliary LoginAuxiliary;

        public Login()
        {
            InitializeComponent();
        }

        private void GoMainForm()
        {
            Thread T = new Thread(StartMainForm);
            T.SetApartmentState(ApartmentState.STA);
            T.Start();

            Close();
            Dispose();
        }

        private void StartMainForm()
        {
            System.Windows.Forms.Application.Run(new MainForm());
        }

        private void Logon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                return;

            if (LoginAuxiliary == null)
                LoginAuxiliary = new LoginAuxiliary(Username.Text, Password.Text);
            else
                LoginAuxiliary.Reset(Username.Text, Password.Text);


            if (LoginAuxiliary.IsValid())
            {
                string AuthCode = LoginAuxiliary.GetHash;
                //fazer consulta
            }



            //GoMainForm();
        }

        private void NewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
            newUser?.Dispose();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logon.PerformClick();
                return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
