﻿using System;
using System.Windows.Forms;

namespace EasyLiTwo.GlobalUtilities
{
    public class FormatNumericInputs
    {
        public static void ValitedNumInput(ref KeyPressEventArgs e, bool IncludeCharp = false)
        {
            char[] Commands = { Convert.ToChar(0x1), Convert.ToChar(0x3), Convert.ToChar(0x8),
                                Convert.ToChar(0x16), Convert.ToChar(0x18), Convert.ToChar(0x1A)};

            foreach (char c in Commands)
            {
                if (c.Equals(e.KeyChar))
                {
                    e.Handled = false;
                    return;
                }
            }

            string[] Verify = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (IncludeCharp)
            {
                Array.Resize(ref Verify, Verify.Length + 1);
                Verify[Verify.Length - 1] = "#";
            }

            bool Okay = false;
            foreach (string stg in Verify)
            {
                if (stg == e.KeyChar.ToString())
                {
                    Okay = true;
                    break;
                }
            }

            if (!Okay)
                e.KeyChar = Char.MinValue;

            e.Handled = false;
        }
    }
}
