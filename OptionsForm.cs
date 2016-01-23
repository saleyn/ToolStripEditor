using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using ToolStripCustomizer.Properties;

namespace ToolStripCustomizer
{
    partial class OptionsForm : BaseForm
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsFormFormClosed(object sender, FormClosedEventArgs e)
        {
            switch (DialogResult)
            {
                case DialogResult.OK:
                    Settings.Default.Save();
                    break;
                default:
                    Settings.Default.Reload();
                    break;
            }
        }

        private void OptionsFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.None && DialogResult == DialogResult.OK)
            {
                bool valid = true;
                if (string.IsNullOrEmpty(namespaceTextBox.Text))
                {
                    namespaceTextBox.Focus();
                    valid = false;
                }
                //else if (string.IsNullOrEmpty(classNameTextBox.Text))
                //{
                //    classNameTextBox.Focus();
                //    valid = false;
                //}

                if (!valid)
                {
                    SystemSounds.Beep.Play();
                    e.Cancel = true;
                }
            }
        }
    }
}
