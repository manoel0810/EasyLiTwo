using EasyLiTwo.Application.Modal;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Input.Repositories;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class EditUser : Form
    {
        private readonly ClientEntity _entity;
        private readonly Operat _operat;
        private Guid _id;
        private bool _isModifyOrNew = false;

        public bool HasChanged => _isModifyOrNew;

        public EditUser(Operat operat, ClientEntity entity = null)
        {
            InitializeComponent();
            _operat = operat;
            _entity = entity;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_operat == Operat.Create)
            {
                PasswordConfirmation password = new PasswordConfirmation();
                password.ShowDialog();

                if (password.GetResult == DialogResult.OK)
                {
                    string sha = ComputeHash(password.GetPassword);
                    ClientEntity entity = new ClientEntity(_id, Username.Text.Trim(), UserEmail.Text.Trim(), UserBirthday.Value.Date, sha, DateTime.Now.Date, UserState.Free);

                    if (entity.IsValid())
                    {
                        WriteClientRepository cliente = new WriteClientRepository(new Sqlite());
                        cliente.InsertClient(entity);

                        ConfirmCase confirn = new ConfirmCase("Cadastro de clientes", "O novo cliente foi cadastrado com sucesso.", true, "Fechar");
                        confirn.ShowDialog();
                        confirn?.Dispose();

                        _isModifyOrNew = true;
                        password?.Dispose();
                        Close();
                    }
                    else
                    {
                        ConfirmCase confirmCase = new ConfirmCase("Registro de cliente", "Não foi possível registrar o cliente.\nVerifique os dados de entrada.", true);
                        confirmCase.ShowDialog();
                        confirmCase?.Dispose();

                        return;
                    }
                }
                else
                {
                    MessageBox.Show("É necessário uma senha para o usuário", "Confirmações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    password?.Dispose();
                    return;
                }
            }
        }

        private string ComputeHash(string input)
        {
            using (SHA256 service = SHA256.Create())
            {
                byte[] bytes = service.ComputeHash(Encoding.UTF8.GetBytes(input));
                return ByteToString(bytes);
            }
        }

        private string ByteToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
                result += b.ToString("X2");

            return result;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            if (_operat == Operat.Create)
            {
                _id = Guid.NewGuid();
                GuidCode.Text = _id.ToString();
            }
            else if (_operat == Operat.Update)
            {
                _id = _entity.Code;
                GuidCode.Text = _id.ToString();
                Username.Text = _entity.Username;
                UserEmail.Text = _entity.Email;
                UserBirthday.Value = _entity.Birth;
            }
        }

        [Flags]
        public enum Operat
        {
            Create,
            Update
        }
    }
}
