using System;
using System.Windows.Forms;

namespace EasyLiTwo.GlobalUtilities
{
    public class FormatNameField
    {
        public static void FormatNameCamp(ref KeyPressEventArgs e, TextBox TextBoxObject)
        {
            if (TextBoxObject.Text.Length == 0x0)
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                e.Handled = false;
            }
            else if (TextBoxObject.Text.Length > 0x1)
                if (TextBoxObject.Text[TextBoxObject.Text.Length - 0x1] == ' ')
                {
                    e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                    e.Handled = false;
                }
        }

    }
}
