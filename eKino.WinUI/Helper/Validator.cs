using eKino.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Helper
{
    public static class Validator
    {
        public static void ValidateControl(object control, ErrorProvider err, CancelEventArgs e, int minLength = 0, bool email = false, string? sameAs = null, string? regex = null, string? formatHint = null)
        {
            if (control is TextBox textbox)
            {

                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    err.SetError(textbox, Resources.Validation_Required);
                }
                else if (minLength > 0 && textbox.Text.Length < minLength)
                {
                    err.SetError(textbox, $"This field requires {minLength} characters at minimum.");
                }
                else if (email && !ValidEmail(textbox.Text))
                {
                    err.SetError(textbox, $"A valid email address is required.");
                }
                else if(!string.IsNullOrEmpty(sameAs) && !string.IsNullOrEmpty(textbox.Text) && textbox.Text != sameAs)
                {
                    err.SetError(textbox, $"Please enter the same value again.");
                }
                else if(regex != null && !Regex.IsMatch(textbox.Text, regex))
                {
                    if(formatHint != null)
                        err.SetError(textbox, $"Invalid format, the value should match the following pattern: " + formatHint);
                    else
                        err.SetError(textbox, $"Invalid format.");
                }
                else
                {
                    err.SetError(textbox, null);
                    return;
                }

                e.Cancel = true;
                textbox.Focus();
            }
            else if(control is ComboBox cmb)
            {
                if(cmb.SelectedItem == null)
                {
                    err.SetError(cmb, Resources.Validation_Required);
                    e.Cancel = true;
                    cmb.Focus();
                }
                else
                {
                    err.SetError(cmb, null);
                    return;
                }
            }
            else if(control is PictureBox pb)
            {
                if(pb.Image == null)
                {
                    err.SetError(pb, Resources.Validation_Required);
                    e.Cancel = true;
                    pb.Focus();
                }
                else
                {
                    err.SetError(pb, null);
                    return;
                }
            }
        }

        private static bool ValidEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
