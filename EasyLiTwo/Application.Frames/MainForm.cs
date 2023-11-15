using EasyLiTwo.Database.Domain.Entities;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class MainForm : Form
    {
        private readonly UserEntity _userEntity;
        public MainForm(UserEntity currentUserEntity)
        {
            InitializeComponent();
            _userEntity = currentUserEntity;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
