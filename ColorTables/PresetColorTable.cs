using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolStripCustomizer.ColorTables
{
    abstract class PresetColorTable : ProfessionalColorTable
    {
        protected PresetColorTable(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }

        public string Name
        {
            get; 
            protected set;
        }

        public override Color ButtonSelectedHighlight
        {
            get { return ButtonSelectedGradientMiddle; }
        }

        public override Color ButtonSelectedHighlightBorder
        {
            get { return ButtonSelectedBorder; }
        }

        public override Color ButtonPressedHighlight
        {
            get { return ButtonPressedGradientMiddle; }
        }

        public override Color ButtonPressedHighlightBorder
        {
            get { return ButtonPressedBorder; }
        }

        public override Color ButtonCheckedHighlight
        {
            get { return ButtonCheckedGradientMiddle; }
        }

        public override Color ButtonCheckedHighlightBorder
        {
            get { return ButtonSelectedBorder; }
        }

        public override Color ButtonPressedBorder
        {
            get { return ButtonSelectedBorder; }
        }
    }
}
