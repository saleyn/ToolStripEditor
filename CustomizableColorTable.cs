using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ToolStripCustomizer.ColorTables;

namespace ToolStripCustomizer
{
    sealed class CustomizableColorTable : PresetColorTable, ICloneable
    {
        private static readonly ProfessionalColorTable professionalColorTable =
            new ProfessionalColorTable();

        private Dictionary<ColorTableGroup, Color> defaultColors;

        private Dictionary<ColorTableGroup, Color> colors =
            new Dictionary<ColorTableGroup, Color>();

        public CustomizableColorTable()
            : base(string.Empty)
        {
            InitFromBase(true);
        }

        public Color ResetColor(ColorTableGroup colorGroup)
        {
            Color baseColor = defaultColors[colorGroup];
            colors[colorGroup] = baseColor;
            return baseColor;
        }

        public Color OverrideColor(ColorTableGroup colorGroup, Color color)
        {
            var old = colors[colorGroup];
            colors[colorGroup] = color;
            return old;
        }

        public void InitFrom(ProfessionalColorTable colorTable, bool makeColorsDefault)
        {
            // Instead of "colors[ColorTableGroup.ButtonSelectedBorder] = colorTable.ButtonSelectedBorder"...
            // use reflection.
            Type colorTableType = colorTable.GetType();
            Type colorTableGroupType = typeof(ColorTableGroup);
            foreach (ColorTableGroup colorTableGroup in Enum.GetValues(colorTableGroupType))
            {
                var prop = colorTableType.GetProperty(Enum.GetName(colorTableGroupType, colorTableGroup));
                if (prop != null)
                    colors[colorTableGroup] = (Color)prop.GetValue(colorTable, null);
            }

            if (makeColorsDefault)
                MakeColorsDefault();
        }

        public void InitFromBase(bool makeColorsDefault)
        {
            // Instead of " colors[ColorTableGroup.ButtonSelectedBorder] = base.ButtonSelectedBorder"...
            // use reflection.
            Type colorTableType = professionalColorTable.GetType();
            Type colorTableGroupType = typeof(ColorTableGroup);
            foreach (ColorTableGroup colorTableGroup in Enum.GetValues(colorTableGroupType))
            {
                switch (colorTableGroup)
                {
                    case ColorTableGroup.FormForeColor:
                    case ColorTableGroup.FormBackColor:
                    case ColorTableGroup.GridGridColor:
                    case ColorTableGroup.GridBackColor:
                    {
                        var name = Enum.GetName(colorTableGroupType, colorTableGroup);
                        try
                        { 
                            var prop = colorTableType.GetProperty(name);
                            colors[colorTableGroup] = (Color)prop.GetValue(professionalColorTable, null);
                        }
                        catch
                        {
                            colors[colorTableGroup] = Color.Black;
                        }
                        break;
                    }
                    default:
                    {
                        var prop = colorTableType.GetProperty(Enum.GetName(colorTableGroupType, colorTableGroup));
                        colors[colorTableGroup] = (Color)prop.GetValue(professionalColorTable, null);
                        break;
                    }
                }
            }

            if (makeColorsDefault)
                MakeColorsDefault();
        }

        public void MakeColorsDefault()
        {
            defaultColors = new Dictionary<ColorTableGroup, Color>(colors);
        }

        public Color this[ColorTableGroup colorGroup]
        {
            get { return colors[colorGroup]; }
            set { colors[colorGroup] = value; }
        }

        public Color FormForeColor { get { return colors[ColorTableGroup.FormForeColor]; } }
        public Color FormBackColor { get { return colors[ColorTableGroup.FormBackColor]; } }
        public Color GridGridColor { get { return colors[ColorTableGroup.GridGridColor]; } }
        public Color GridBackColor { get { return colors[ColorTableGroup.GridBackColor]; } }

        public override Color ButtonSelectedBorder
        {
            get
            {
                return colors[ColorTableGroup.ButtonSelectedBorder];
            }
        }

        public override Color ButtonCheckedGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ButtonCheckedGradientBegin];
            }
        }

        public override Color ButtonCheckedGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.ButtonCheckedGradientMiddle];
            }
        }

        public override Color ButtonCheckedGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ButtonCheckedGradientEnd];
            }
        }

        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ButtonSelectedGradientBegin];
            }
        }

        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.ButtonSelectedGradientMiddle];
            }
        }

        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ButtonSelectedGradientEnd];
            }
        }

        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ButtonPressedGradientBegin];
            }
        }

        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.ButtonPressedGradientMiddle];
            }
        }

        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ButtonPressedGradientEnd];
            }
        }

        public override Color CheckBackground
        {
            get
            {
                return colors[ColorTableGroup.CheckBackground];
            }
        }

        public override Color CheckSelectedBackground
        {
            get
            {
                return colors[ColorTableGroup.CheckSelectedBackground];
            }
        }

        public override Color CheckPressedBackground
        {
            get
            {
                return colors[ColorTableGroup.CheckPressedBackground];
            }
        }

        public override Color GripDark
        {
            get
            {
                return colors[ColorTableGroup.GripDark];
            }
        }

        public override Color GripLight
        {
            get
            {
                return colors[ColorTableGroup.GripLight];
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ImageMarginGradientBegin];
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.ImageMarginGradientMiddle];
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ImageMarginGradientEnd];
            }
        }

        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ImageMarginRevealedGradientBegin];
            }
        }

        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.ImageMarginRevealedGradientMiddle];
            }
        }

        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ImageMarginRevealedGradientEnd];
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.MenuStripGradientBegin];
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.MenuStripGradientEnd];
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return colors[ColorTableGroup.MenuItemSelected];
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return colors[ColorTableGroup.MenuItemBorder];
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return colors[ColorTableGroup.MenuBorder];
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.MenuItemSelectedGradientBegin];
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.MenuItemSelectedGradientEnd];
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.MenuItemPressedGradientBegin];
            }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.MenuItemPressedGradientMiddle];
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.MenuItemPressedGradientEnd];
            }
        }

        public override Color RaftingContainerGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.RaftingContainerGradientBegin];
            }
        }

        public override Color RaftingContainerGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.RaftingContainerGradientEnd];
            }
        }

        public override Color SeparatorDark
        {
            get
            {
                return colors[ColorTableGroup.SeparatorDark];
            }
        }

        public override Color SeparatorLight
        {
            get
            {
                return colors[ColorTableGroup.SeparatorLight];
            }
        }

        public override Color StatusStripGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.StatusStripGradientBegin];
            }
        }

        public override Color StatusStripGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.StatusStripGradientEnd];
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return colors[ColorTableGroup.ToolStripBorder];
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return colors[ColorTableGroup.ToolStripDropDownBackground];
            }
        }

        public override Color ToolStripGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ToolStripGradientBegin];
            }
        }

        public override Color ToolStripGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.ToolStripGradientMiddle];
            }
        }

        public override Color ToolStripGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ToolStripGradientEnd];
            }
        }

        public override Color ToolStripContentPanelGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ToolStripContentPanelGradientBegin];
            }
        }

        public override Color ToolStripContentPanelGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ToolStripContentPanelGradientEnd];
            }
        }

        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.ToolStripPanelGradientBegin];
            }
        }

        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.ToolStripPanelGradientEnd];
            }
        }

        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return colors[ColorTableGroup.OverflowButtonGradientBegin];
            }
        }

        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return colors[ColorTableGroup.OverflowButtonGradientMiddle];
            }
        }

        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return colors[ColorTableGroup.OverflowButtonGradientEnd];
            }
        }

        #region Implementation of ICloneable

        public object Clone()
        {
            CustomizableColorTable clone = (CustomizableColorTable)MemberwiseClone();
            clone.colors = new Dictionary<ColorTableGroup, Color>(clone.colors);
            return clone;
        }

        #endregion
    }

    enum ColorTableGroup
    {
        ButtonSelectedBorder,
        ButtonCheckedGradientBegin,
        ButtonCheckedGradientMiddle,
        ButtonCheckedGradientEnd,
        ButtonSelectedGradientBegin,
        ButtonSelectedGradientMiddle,
        ButtonSelectedGradientEnd,
        ButtonPressedGradientBegin,
        ButtonPressedGradientMiddle,
        ButtonPressedGradientEnd,
        CheckBackground,
        CheckSelectedBackground,
        CheckPressedBackground,
        GripDark,
        GripLight,
        ImageMarginGradientBegin,
        ImageMarginGradientMiddle,
        ImageMarginGradientEnd,
        ImageMarginRevealedGradientBegin,
        ImageMarginRevealedGradientMiddle,
        ImageMarginRevealedGradientEnd,
        MenuStripGradientBegin,
        MenuStripGradientEnd,
        MenuItemSelected,
        MenuItemBorder,
        MenuBorder,
        MenuItemSelectedGradientBegin,
        MenuItemSelectedGradientEnd,
        MenuItemPressedGradientBegin,
        MenuItemPressedGradientMiddle,
        MenuItemPressedGradientEnd,
        RaftingContainerGradientBegin,
        RaftingContainerGradientEnd,
        SeparatorDark,
        SeparatorLight,
        StatusStripGradientBegin,
        StatusStripGradientEnd,
        ToolStripBorder,
        ToolStripDropDownBackground,
        ToolStripGradientBegin,
        ToolStripGradientMiddle,
        ToolStripGradientEnd,
        ToolStripContentPanelGradientBegin,
        ToolStripContentPanelGradientEnd,
        ToolStripPanelGradientBegin,
        ToolStripPanelGradientEnd,
        OverflowButtonGradientBegin,
        OverflowButtonGradientMiddle,
        OverflowButtonGradientEnd,

        FormForeColor,
        FormBackColor,
        GridGridColor,
        GridBackColor,
  }
}