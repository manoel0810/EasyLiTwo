using EasyLiTwo.GlobalUtilities;
using System;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class PasswordConfirmation : Form
    {
        private DialogResult _result;
        private string _password;
        readonly FormatNumericInputs numericInputs = new FormatNumericInputs();

        public PasswordConfirmation()
        {
            InitializeComponent();
        }

        public DialogResult GetResult => _result;
        public string GetPassword => _password;

        private void Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Password1.Text) || string.IsNullOrWhiteSpace(Password2.Text))
                return;
            else
            {
                if (Password1.Text.Length < 4 || Password2.Text.Length < 4)
                {
                    MessageBox.Show("Sua senha deve conter quatro caracteres", "Confirmações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (Password1.Text != Password2.Text)
                    {
                        MessageBox.Show("Suas senhas estão diferentes", "Confirmações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        _password = Password1.Text;
                        _result = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _result = DialogResult.None;
            Close();
        }

        private void Password1_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericInputs.ValitedNumInput(ref e, false);
        }

        private void Password2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericInputs.ValitedNumInput(ref e, false);
        }
    }
}
