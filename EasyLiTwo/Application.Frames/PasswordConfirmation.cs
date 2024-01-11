using EasyLiTwo.GlobalUtilities;
using System;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Frames
{
    public partial class PasswordConfirmation : Form
    {
        private DialogResult _result;
        private string _password;
        private string _newPassword;
        private readonly PassworkConfirmationMode _confirmationMode;
        readonly FormatNumericInputs numericInputs = new FormatNumericInputs();

        public PasswordConfirmation(PassworkConfirmationMode confirmationMode)
        {
            InitializeComponent();
            _confirmationMode = confirmationMode;
        }

        public DialogResult GetResult => _result;
        public string GetPassword => _password;
        public string GetNewPassword => _newPassword;

        private void Save_Click(object sender, EventArgs e)
        {

            if (IsPasswordValid())
            {
                if (_confirmationMode == PassworkConfirmationMode.NewPassword || _confirmationMode == PassworkConfirmationMode.UpdatePassword)
                {
                    if (Password1.Text != Password2.Text)
                    {
                        MessageBox.Show("Suas senhas estão diferentes", "Confirmações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        UpdateAndClose();
                }
                else if (_confirmationMode == PassworkConfirmationMode.ConfirmPassword)
                {
                    //Adicionar mais rotinas se necessário e chamar a saída com UpdateAndClose();
                    UpdateAndClose();
                }
            }
            else
            {
                MessageBox.Show("Informe os campos corretamente", "Senhas do usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void UpdateAndClose()
        {
            _password = Password1.Text;
            _newPassword = Password3.Text;
            _result = DialogResult.OK;
            Close();
        }

        private bool IsPasswordValid()
        {
            switch (_confirmationMode)
            {
                case PassworkConfirmationMode.UpdatePassword:
                    return !(Password1.Text.Length < 4 || Password2.Text.Length < 4 || Password3.Text.Length < 4);
                case PassworkConfirmationMode.NewPassword:
                    return !(Password1.Text.Length < 4 || Password2.Text.Length < 4);
                case PassworkConfirmationMode.ConfirmPassword:
                    return !(Password1.Text.Length < 4);
            }

            return false;
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
            FormatNumericInputs.ValitedNumInput(ref e, false);
        }

        private void Password2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatNumericInputs.ValitedNumInput(ref e, false);
        }

        [Flags]
        public enum PassworkConfirmationMode
        {
            NewPassword,
            UpdatePassword,
            ConfirmPassword
        }

        private void PasswordConfirmation_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            if (_confirmationMode == PassworkConfirmationMode.UpdatePassword)
            {
                LbPassword3.Visible = true;
                Password3.Visible = true;
            }
            else if (_confirmationMode == PassworkConfirmationMode.ConfirmPassword)
            {
                LbPassword2.Visible = false;
                Password2.Visible = false;

                LbPassword1.Location = LbPassword2.Location;
                Password1.Location = Password2.Location;
            }
        }

        private void PasswordConfirmation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save.PerformClick();
        }
    }
}
