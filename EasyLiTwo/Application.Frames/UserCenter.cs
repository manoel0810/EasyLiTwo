using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class UserCenter : Form
    {
        public UserCenter()
        {
            InitializeComponent();
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            EditUser edit = new EditUser(operat: EditUser.Operat.Create);
            edit.ShowDialog();
            edit?.Dispose();


            ReloadGrid();
        }

        private void UserCenter_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void ReloadGrid()
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }

        private void LoadGrid()
        {

            ClientReadRepository read = new ClientReadRepository(new Sqlite());
            var list = read.GetAll();

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

                Users.DataSource = Schema;
                Users.Columns[0].Visible = false;
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
    }
}
