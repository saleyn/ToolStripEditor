using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToolStripCustomizer
{
    class BaseForm : Form
    {
        protected static readonly bool RunningOnMono = Type.GetType("Mono.Runtime") != null;

        protected BaseForm()
        {
            AutoScaleMode = AutoScaleMode.Dpi;
            if (!RunningOnMono)
            {
                Font = SystemFonts.MessageBoxFont;
            }
        }
    }
}
