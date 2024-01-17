using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class MainForm : Form
    {
        private readonly ISqlFactory _factory;

        public MainForm(ISqlFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void UsuáriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (UserCenter userCenter = new UserCenter(_factory))
            {
                userCenter.ShowDialog();
            }
        }
    }
}
