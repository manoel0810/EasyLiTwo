using EasyLiTwo.AuxiliaryClasses;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;
using EasyLiTwo.Shared;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class Login : Form
    {
        LoginAuxiliary LoginAuxiliary;
        private UserEntity _userEntity;
        private readonly ISqlFactory _factory;

        public Login(ISqlFactory factory)
        {
            InitializeComponent();
            _factory = factory;
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
            CurrentUser.SetUser(_userEntity);
            System.Windows.Forms.Application.Run(new MainForm(_factory));     
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
                UserReadRepository userReadRepository = new UserReadRepository(_factory);
                var ulist = userReadRepository.GetUserBySHA(AuthCode).ToList();

                if (ulist.Count > 0)
                {
                    _userEntity = new UserEntity(ulist[0]);
                    if (_userEntity.IsFree())
                        GoMainForm();
                    else
                    {
                        Username.Clear();
                        Password.Clear();
                        Username.Focus();

                        MessageBox.Show("Seu acesso ao EasyLi está suspenso. Entre em contato com o administrador do sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    return;
                }
                else
                {
                    MessageBox.Show("Username e/ou senha inválidos", "EasyLi Two", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Password.Clear();
                    Password.Focus();

                    return;
                }
            }
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
