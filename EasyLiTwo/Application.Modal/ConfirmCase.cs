using System;
using System.Media;
using System.Windows.Forms;

namespace EasyLiTwo.Application.Modal
{
    public partial class ConfirmCase : Form
    {
        private readonly DialogResult _expectedResult;
        private readonly string _message;
        private readonly string _header;
        private readonly string _confirmText;
        private readonly bool _onlyConfirmation;
        private readonly bool _doAlert;

        private DialogResult _realResult;

        public DialogResult Result
        {
            get
            {
                return _realResult;
            }
            private set
            {
                _realResult = value;
            }
        }

        /// <summary>
        /// Inicia uma nova instância do objeto ConfirmCase, e traz como saída padrão da chamada um <b>expectedResult</b>
        /// </summary>
        /// <param name="header">Cabeçalho da mensagem</param>
        /// <param name="message">Mensagem que será exibida para o usuário</param>
        /// <param name="confirmText">Texto do botão de confirmação</param>
        /// <param name="expectedResult">Determina a saída esperada para o evento de <b>ActionButtonClick</b></param>
        /// <param name="doAlert">Quando <b>true</b>, emite um som ao exibir a caixa de diálogo</param>

        public ConfirmCase(string header, string message, string confirmText, DialogResult expectedResult, bool doAlert = false)
        {
            InitializeComponent();

            _header = header;
            _message = message;
            _confirmText = confirmText;
            _expectedResult = expectedResult;

            _onlyConfirmation = false;
            _doAlert = doAlert;
        }

        /// <summary>
        /// Inicia uma nova instância do objeto ConfirmCase, e traz como saída padrão da chamada um <b>DialogResult.OK</b>
        /// </summary>
        /// <param name="header">Cabeçalho da mensagem</param>
        /// <param name="message">Mensagem que será exibida para o usuário</param>
        /// <param name="confirmText">Texto do botão de confirmação</param>
        /// <param name="doAlert">Quando <b>true</b>, emite um som ao exibir a caixa de diálogo</param>

        public ConfirmCase(string header, string message, bool doAlert = false, string confirmText = null)
        {
            InitializeComponent();

            _header = header;
            _message = message;
            _confirmText = confirmText;
            _expectedResult = DialogResult.OK;

            _onlyConfirmation = true;
            _doAlert = doAlert;
        }

        private void ConfirmCase_Load(object sender, EventArgs e)
        {
            Header.Text = _header ?? Header.Text;
            Message.Text = _message ?? Header.Text;
            ConfirmAction.Text = _confirmText ?? ConfirmAction.Text;

            if (_onlyConfirmation)
            {
                Cancel.Visible = false;
                ConfirmAction.Location = new System.Drawing.Point((Width - ConfirmAction.Width) / 2, ConfirmAction.Location.Y);
            }

            if (_doAlert)
            {
                SystemSound alert = SystemSounds.Asterisk;
                alert.Play();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _realResult = DialogResult.Cancel;
            Close();
        }

        private void ConfirmAction_Click(object sender, EventArgs e)
        {
            _realResult = _expectedResult;
            Close();
        }
    }
}
