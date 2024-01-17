using EasyLiTwo.Application.Modal;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using EasyLiTwo.Database.Infrastructure.Input.Repositories;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class UserCenter : Form
    {
        private DataTable _users = new DataTable();
        private readonly ISqlFactory _factory;

        public UserCenter(ISqlFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void CallUserEditForm(EditUser.Operat operation, ClientEntity entity = null)
        {
            using (EditUser edit = new EditUser(operation, _factory, entity))
            {
                edit.ShowDialog();
                bool modify = edit.HasChanged;

                if (modify)
                    LoadGrid();
            }
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            CallUserEditForm(EditUser.Operat.Create);
        }

        private void UserCenter_Load(object sender, EventArgs e)
        {
            LoadGrid();
            SetDim();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Users.SelectedRows.Count == 1)
            {
                if (Users.SelectedRows[0].Cells[0].Value is null)
                    return;

                string userID = Users.SelectedRows[0].Cells[0].Value.ToString();
                ClientReadRepository _read = new ClientReadRepository(new Sqlite());
                CallUserEditForm(EditUser.Operat.Update, new ClientEntity(_read.GetClientByGuid(userID)));
            }
        }

        private DialogResult ShowDialogBox(string header, string message, string btnExtraText, DialogResult expectedResult)
        {
            ConfirmCase confir = new ConfirmCase(header, message, btnExtraText, expectedResult);
            confir.ShowDialog();

            DialogResult result = confir.Result;
            confir?.Dispose();
            return result;
        }

        private void DeleteUser(string uid, Action dataGridViewDeleteAction)
        {
            WriteClientRepository _write = new WriteClientRepository(new Sqlite());
            _write.DeleteClient(uid);
            RemoveRowFromBase(uid);

            dataGridViewDeleteAction.Invoke();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Users.SelectedRows.Count == 1)
            {
                var value = Users.SelectedRows[0].Cells[0].Value;
                if (value is null)
                    return;

                if (ShowDialogBox("Apagar cliente", "Deseja realmente apagar esse cliente?\nEssa ação não é reversível", "Apagar", DialogResult.Yes) == DialogResult.Yes)
                    DeleteUser((string)value, () => { Users.Rows.Remove(Users.CurrentRow); });
            }
            else if (Users.SelectedRows.Count > 1)
            {
                List<object[]> guids = new List<object[]>();
                foreach (DataGridViewRow row in Users.SelectedRows)
                    if (row.Cells[0].Value != null)
                        guids.Add(new object[] { (string)row.Cells[0].Value, row });

                if (guids.Count > 0)
                {
                    if (ShowDialogBox("Apagar clientes", $"Deseja realmente apagar um número de {guids.Count} usuários?\nAção não reversível", "Apagar", DialogResult.Yes) == DialogResult.Yes)
                    {
                        foreach (object[] guid in guids)
                            DeleteUser((string)guid[0], () => { RemoveRowFromDataGridView((DataGridViewRow)guid[1]); });
                    }
                }
            }
        }

        private void RemoveRowFromDataGridView(DataGridViewRow row)
        {
            int index = -1;
            foreach (DataGridViewRow r in Users.SelectedRows)
            {
                if (r.Cells[0].Value == row.Cells[0].Value)
                {
                    index = r.Index;
                    break;
                }
            }

            if (index != -1)
                Users.Rows.RemoveAt(index);
        }

        private void RemoveRowFromBase(string guid)
        {
            int index = -1;
            for (int i = 0; i < _users.Rows.Count; i++)
            {
                if (_users.Rows[i].Field<string>("ID") == guid)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                _users.Rows.RemoveAt(index);
        }

        private void LoadGrid()
        {
            ClientReadRepository _read = new ClientReadRepository(new Sqlite());
            var list = _read.GetAll();
            if (list != null)
            {
                DataTable Schema = new DataTable();

                Schema.Columns.Add("ID", typeof(string));
                Schema.Columns.Add("Nome", typeof(string));
                Schema.Columns.Add("Email", typeof(string));
                Schema.Columns.Add("Status", typeof(string));
                DataRow row = Schema.NewRow();

                foreach (var item in list)
                {
                    row["ID"] = item.Guid;
                    row["Nome"] = item.Name;
                    row["Email"] = item.Email;
                    row["Status"] = ((UserState)item.Status == UserState.Free ? "Ativo" : "Bloqueado");

                    Schema.Rows.Add(row);
                    row = Schema.NewRow();
                }

                _users = Schema;
                SetGridSource(_users);
            }
        }

        private void Users_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Users.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value is DBNull)
                {
                    return;
                }

                if ((string)e.Value == "Bloqueado")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 170, 170);
                }
                else if ((string)e.Value == "Ativo")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(205, 240, 190);
                }
            }
        }

        private void SetGridSource(DataTable source, bool HideID = true)
        {
            Users.DataSource = source;
            Users.Columns[0].Visible = !HideID;
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Filter.Text) && Filter.Text.Length >= 3)
            {
                DataTable filteredDataTable = _users.Clone();
                foreach (DataRow row in _users.Rows)
                {
                    if (row["Nome"].ToString().ToUpper().Contains(Filter.Text.ToUpper()))
                    {
                        filteredDataTable.ImportRow(row);
                    }
                }

                SetGridSource(filteredDataTable);
            }
            else if (string.IsNullOrWhiteSpace(Filter.Text))
            {
                SetGridSource(_users);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetDim()
        {
            if (Users.Columns.Count < 4)
                return;

            double totalAvaible = Users.Width * 0.7d;
            double rest = Users.Width * 0.2d;

            Users.Columns[1].Width = Convert.ToInt32(totalAvaible / 2);
            Users.Columns[2].Width = Convert.ToInt32(totalAvaible / 2);
            Users.Columns[3].Width = Convert.ToInt32(rest);
        }

        private void UserCenter_ResizeEnd(object sender, EventArgs e)
        {
            SetDim();
        }

        private void UserCenter_Resize(object sender, EventArgs e)
        {
            SetDim();
        }

        private void ClickEditButton()
        {
            if (Users.SelectedRows.Count == 1)
            { Edit.PerformClick(); }
        }

        private void Users_DoubleClick(object sender, EventArgs e)
        {
            ClickEditButton();
        }

        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClickEditButton();
            }
        }

        private void Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClickEditButton();
            }
        }

        private void Users_SelectionChanged(object sender, EventArgs e)
        {
            if (Users.SelectedRows.Count > 1)
            {
                Edit.Enabled = false;
            }
            else if (Users.SelectedRows.Count < 2)
            {
                Edit.Enabled = true;
            }
        }
    }
}
