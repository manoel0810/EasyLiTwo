using EasyLiTwo.AuxiliaryClasses;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Input.Repositories;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, System.EventArgs e)
        {
            Dictionary<UserType, string> avaibleTypes = new Dictionary<UserType, string>()
            {
                { UserType.Default, "Normal" },
                { UserType.Maintence, "Técnico" },
                { UserType.Administrator, "Administrador" }
            };

            DataTable avaibleTypesDataTable = new DataTable();
            avaibleTypesDataTable.Columns.Add("DisplayMember", typeof(string));
            avaibleTypesDataTable.Columns.Add("ValueMemeber", typeof(UserType));
            DataRow row = avaibleTypesDataTable.NewRow();

            foreach (KeyValuePair<UserType, string> kvp in avaibleTypes)
            {
                row["DisplayMember"] = kvp.Value;
                row["ValueMemeber"] = kvp.Key;
                avaibleTypesDataTable.Rows.Add(row);

                row = avaibleTypesDataTable.NewRow();
            }


            UserTypes_Needed.DataSource = avaibleTypesDataTable;
            UserTypes_Needed.DisplayMember = "DisplayMember";
            UserTypes_Needed.ValueMember = "ValueMemeber";
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TryReg_Click(object sender, System.EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox t)
                {
                    if (t.Name.EndsWith("_Needed") && string.IsNullOrWhiteSpace(t.Text))
                    {
                        MessageBox.Show("Informe todos os campos obrigatórios", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (c is ComboBox cb)
                {
                    if (cb.Name.EndsWith("_Needed") && cb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecione todos os campos obrigatórios", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            if (Password_Needed.Text != RepeatPassword_Needed.Text)
            {
                MessageBox.Show("Suas senhas estão diferentes. Corrija", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Password_Needed.Text.Length < 6)
            {
                MessageBox.Show("Suas deve conter pelo menos seis caracteres", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsAlreadyNicknameRegistred(Nickname_Needed.Text))
            {
                MessageBox.Show("O nome de usuário é inválido", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                WriteUserRepository writeUserRepository = new WriteUserRepository(new Sqlite());
                LoginAuxiliary auxiliary = new LoginAuxiliary(Nickname_Needed.Text, RepeatPassword_Needed.Text);

                var userEntity = new UserEntity(Nickname_Needed.Text, auxiliary.GetHash, UserFullName_Needed.Text, Email.Text, (UserType)UserTypes_Needed.SelectedValue, UserState.Free);
                if (!userEntity.IsValid())
                {
                    MessageBox.Show("Não foi possível validar os dados de entrada", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                writeUserRepository.InsertUser(userEntity);
                MessageBox.Show("Usuário registrado com êxito", "Registro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool IsAlreadyNicknameRegistred(string nickname)
        {
            UserReadRepository getUserByNicknameRepository = new UserReadRepository(new Sqlite());
            var obj = getUserByNicknameRepository.GetUserByNickname(nickname);

            return (obj != null && obj.Count() != 0);
        }
    }
}
