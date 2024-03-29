﻿using EasyLiTwo.Application.Modal;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using EasyLiTwo.Database.Infrastructure.Input.Repositories;
using EasyLiTwo.Database.Output.DTOs;
using EasyLiTwo.GlobalUtilities;
using EasyLiTwo.Shared;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class EditUser : Form
    {
        private readonly ISqlFactory _factory;
        private readonly Operat _operat;

        private Guid _id;
        private ClientEntity _entity;
        private bool _isModifyOrNew = false;
        private UserState _newState = UserState.Free;

        public bool HasChanged => _isModifyOrNew;

        public EditUser(Operat operat, ISqlFactory factory, ClientEntity entity = null)
        {
            InitializeComponent();
            _operat = operat;
            _factory = factory;
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
            if (CurrentUser.GetUserPublicInformation().UserType == UserType.Administrator)
            {
                DoUpdates();
            }
            else
            {
                using (PasswordConfirmation password = new PasswordConfirmation(_operat == Operat.Create ? PasswordConfirmation.PassworkConfirmationMode.NewPassword : PasswordConfirmation.PassworkConfirmationMode.ConfirmPassword))
                {
                    password.ShowDialog();
                    if (password.GetResult == DialogResult.OK)
                        DoUpdates(password.GetPassword);
                }
            }
        }

        private void DoUpdates(string password = null)
        {
            string sha = password == null ? _entity.SHA : ComputeHash(password);
            if (TryCreateClientEntity(out var entity, GenerateClienteDTO(sha)))
            {
                WriteClientRepository cliente = new WriteClientRepository(_factory);
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
                    if (CheckUserPassWord(sha))
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

        private bool CheckUserPassWord(string hash)
        {
            return _entity.SHA == hash.ToUpper();
        }

        private void ExitMainContext(Action exitMessage)
        {
            exitMessage.Invoke();
            _isModifyOrNew = true;
            Close();
        }

        private void ShowMessage(string header, string message, bool doAlert = true, string buttonText = null)
        {
            using (ConfirmCase confirmCase = new ConfirmCase(header, message, doAlert, buttonText))
            {
                confirmCase.ShowDialog();
            }
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
                Status = _operat == Operat.Create ? (int)UserState.Free : (int)_newState
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
            Username.KeyPress += (_, arg) =>
            {
                FormatNameField.FormatNameCamp(ref arg, (TextBox)_);
            };

            var user = CurrentUser.GetUserPublicInformation();
            if (user.UserType == UserType.Administrator && _operat == Operat.Update)
                LockAndUnlockUser.Visible = true;

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

                LockAndUnlockUser.Text = _entity.UserState == UserState.Free ? "Bloquear" : "Desbloquear";
                _newState = _entity.UserState;
            }
        }

        private void EditUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void LockAndUnlockUser_CheckedChanged(object sender, EventArgs e)
        {
            if (LockAndUnlockUser.Checked)
            {
                if (LockAndUnlockUser.Text.StartsWith("B"))
                    _newState = UserState.Blocked;
                else if (LockAndUnlockUser.Text.StartsWith("D"))
                    _newState = UserState.Free;
            }
            else
                _newState = _entity.UserState;
        }

        private void UpdatePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (PasswordConfirmation password = new PasswordConfirmation(CurrentUser.GetUserPublicInformation().UserType == UserType.Administrator ? PasswordConfirmation.PassworkConfirmationMode.NewPassword : PasswordConfirmation.PassworkConfirmationMode.UpdatePassword))
            {
                password.ShowDialog();
                if (password.GetResult == DialogResult.OK)
                {
                    if (CurrentUser.GetUserPublicInformation().UserType != UserType.Administrator)
                    {
                        if (ComputeHash(password.GetPassword) != _entity.SHA)
                        {
                            ShowMessage("Correção de dados", "Senha do usuário inválida", true);
                            return;
                        }
                    }

                    ClientEntity updated = new ClientEntity(GenerateClienteDTO(ComputeHash(password.GetNewPassword)));
                    WriteClientRepository write = new WriteClientRepository(_factory);
                    write.UpdateClient(updated);
                    _entity = updated;

                    ShowMessage("Correção de dados", "Senha do usuário atualizada com êxito");
                }
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
