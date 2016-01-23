using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToolStripCustomizer
{
    internal partial class ColorAdjustForm : BaseForm
    {
        private CustomizableColorTable initialColorTable, colorTable;

        public ColorAdjustForm()
        {
            InitializeComponent();
        }

        private void UpdateColors()
        {
            var deltaHue = hueBar.Value;
            var deltaSat = 2.0 / (saturationBar.Maximum - saturationBar.Minimum) * saturationBar.Value;
            var deltaLight = 2.0 / (lightnessBar.Maximum - lightnessBar.Minimum) * lightnessBar.Value;

            var enumValues = Enum.GetValues(typeof(ColorTableGroup));
            foreach (ColorTableGroup colorTableGroup in enumValues)
            {
                // Skip empty colors.
                if (initialColorTable[colorTableGroup] == Color.Empty)
                    continue;

                HslColor hslColor = HslColor.FromColor(initialColorTable[colorTableGroup]);
                colorTable[colorTableGroup] = new HslColor(hslColor.Alpha, hslColor.Hue + deltaHue,
                                                           hslColor.Saturation + deltaSat,
                                                           hslColor.Luminosity + deltaLight).ToColor();
            }

            MainForm.Renderer.RefreshToolStrips();
        }

        private void ResetBars()
        {
            hueBar.Value = 0;
            saturationBar.Value = 0;
            lightnessBar.Value = 0;
        }

        private void OnHueBarValueChanged(object sender, EventArgs e)
        {
            UpdateColors();      
        }

        private void OnResetButtonClick(object sender, EventArgs e)
        {
            ResetBars();
            UpdateColors();
        }

        private void OnHueBarScroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            Point cursorPos = Cursor.Position;
            cursorPos.Offset(Cursor.Size.Width / 2, Cursor.Size.Height / 2);
            toolTip.Show(bar.Value.ToString(), bar, bar.PointToClient(cursorPos), 1000);
        }

        private void OnShown(object sender, EventArgs e)
        {
            colorTable = MainForm.Renderer.ColorTable;
            initialColorTable = (CustomizableColorTable)colorTable.Clone();
            ResetBars();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                colorTable.InitFrom(initialColorTable, false);
            }
        }
    }
}
