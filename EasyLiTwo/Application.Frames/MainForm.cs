using EasyLiTwo.Database.Domain.Entities;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void UsuáriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UserCenter usenter = new UserCenter();
            usenter.ShowDialog();
            usenter?.Dispose();
        }
    }
}
