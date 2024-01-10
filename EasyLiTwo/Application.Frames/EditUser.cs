using EasyLiTwo.Application.Modal;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Input.Repositories;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;
using EasyLiTwo.Database.Output.DTOs;
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
            PasswordConfirmation password = new PasswordConfirmation(_operat == Operat.Create ? PasswordConfirmation.PassworkConfirmationMode.NewPassword : PasswordConfirmation.PassworkConfirmationMode.ConfirmPassword);
            password.ShowDialog();

            if (password.GetResult == DialogResult.OK)
            {
                string sha = ComputeHash(password.GetPassword);
                if (TryCreateClientEntity(out var entity, GenerateClienteDTO(sha)))
                {
                    WriteClientRepository cliente = new WriteClientRepository(new Sqlite());
                    Action a = () => { };

                    if (_operat == Operat.Create)
                    {
                        a = () =>
                        {
                            cliente.InsertClient(entity);
                            ShowMessage("Cadastro de clientes", "O novo cliente foi cadastrado com sucesso.", false, "Fechar");
                        };
                    }
                    else if (_operat == Operat.Update)
                    {
                        if (CheckUserPassWord(sha, GuidCode.Text))
                        {
                            a = () =>
                            {
                                cliente.UpdateClient(entity);
                                ShowMessage("Correção de dados", "As informações foram atualizadas com êxito", false, "Fechar");
                            };
                        }
                        else
                        {
                            a = () =>
                            {
                                ShowMessage("Correção de dados", "Senha do usuário inválida", true);
                            };
                        }
                    }

                    ExitMainContext(a);
                }
                else
                {
                    ShowMessage("Registro de cliente", "Não foi possível registrar as informações.\nVerifique os dados de entrada.");
                    return;
                }
            }
            else
            {
                ShowMessage("Senhas de segurança", "É necessário informar a senha do usuário");
                password?.Dispose();
                return;
            }
        }

        private bool CheckUserPassWord(string hash, string uid)
        {
            ClientReadRepository read = new ClientReadRepository(new Sqlite());
            var entity = read.GetClientByGuid(uid);
            if (entity != null)
                return entity.SHA == hash.ToUpper();


            return false;
        }

        private void ExitMainContext(Action exitMessage)
        {
            exitMessage.Invoke();
            _isModifyOrNew = true;
            Close();
        }

        private void ShowMessage(string header, string message, bool doAlert = true, string buttonText = null)
        {
            ConfirmCase confirmCase = new ConfirmCase(header, message, doAlert, buttonText);
            confirmCase.ShowDialog();
            confirmCase?.Dispose();
        }

        private ClientDTO GenerateClienteDTO(string sha)
        {
            return new ClientDTO()
            {
                Guid = _id.ToString(),
                Name = Username.Text.Trim(),
                Email = UserEmail.Text.Trim(),
                Birth = UserBirthday.Value.Date,
                SHA = sha,
                RegDate = DateTime.Now,
                Status = (int)UserState.Free
            };
        }

        private bool TryCreateClientEntity(out ClientEntity entity, ClientDTO dto)
        {
            if (dto == null)
            {
                entity = null;
                return false;
            }

            entity = new ClientEntity(dto);
            return entity.IsValid();
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
            KeyPreview = true;

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

        private void EditUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
