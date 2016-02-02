using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ToolStripCustomizer.ColorTables;
using ToolStripCustomizer.Properties;

namespace ToolStripCustomizer
{
  partial class MainForm : BaseForm
    {
        public static readonly List<PresetColorTable> Presets;
        public static readonly CustomToolStripRenderer Renderer = new CustomToolStripRenderer();

        private const string ColorGroupColumnName = "ColorTableItemColumn";
        private const string ColorValueColumnName = "ColorValueColumn";
        private const string ColorColumnName = "ColorPreviewColumn";
        private const string EditColumnName = "EditColorColumn";

        private readonly ColorAdjustForm colorAdjustForm = new ColorAdjustForm();

        static MainForm()
        {
            Presets = new List<PresetColorTable>
                          {
                              new VS2012LightColorTable(),
                              new VS2012BlueColorTable(),
                              new VS2010ColorTable(),
                              new Office2007ColorTable(),
                              new Office2003ColorTable(),
                              new OfficeClassicColorTable(),
                              new OfficeXPColorTable(),
                              new DarkColorTable(),
                              new SystemColorTable()
                          };
        }

        public MainForm()
        {
            InitializeComponent();

            Renderer.ColorTable.OverrideColor(ColorTableGroup.FormForeColor, ForeColor);
            Renderer.ColorTable.OverrideColor(ColorTableGroup.FormBackColor, BackColor);
            Renderer.ColorTable.OverrideColor(ColorTableGroup.GridGridColor, gridView.GridColor);
            Renderer.ColorTable.OverrideColor(ColorTableGroup.GridBackColor, gridView.BackgroundColor);

            ToolStripManager.Renderer = Renderer;

            // Add system colors.
            var colors = Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor color in colors)
            {
                var toAdd = Color.FromKnownColor(color);
                if (toAdd.IsSystemColor)
                {
                    var item = fromKnownColorMenuItem.DropDownItems.Add(toAdd.Name);
                    item.Image = CreateColorPreview(null, toAdd, 16, 16);
                    item.Tag = toAdd;
                    item.Click += KnownColorPopupClick;
                }
            }

            // Add menu items for presets.
            foreach (var presetColorTable in Presets)
            {
                var menuItem = newFromPresetMenuItem.DropDownItems.Add(presetColorTable.Name);
                menuItem.Click += NewFromPresetMenuItemClick;
                menuItem.Tag = presetColorTable;
                var toolItem = newToolStripButton.DropDownItems.Add(presetColorTable.Name);
                toolItem.Click += NewFromPresetMenuItemClick;
                toolItem.Tag = presetColorTable;                
            }

            // Add row for each color group.
            var values = Enum.GetValues(typeof(ColorTableGroup));
            foreach (ColorTableGroup colorGroup in values)
            {
                var color = Renderer.ColorTable[colorGroup];
                SetRow(gridView.Rows.Add(), colorGroup, color);
            }

            // Solution for VS bug with ToolStrips positioning in designer.
            mainToolStrip.Location = new Point(0, 0);
            previewToolStrip.Location = new Point(mainToolStrip.Bounds.Right, 0);
        }

    private ColorTableGroup GetRowColorGroup(int rowIndex)
        {
            var value = gridView.Rows[rowIndex].Cells[ColorGroupColumnName].Value.ToString();
            return (ColorTableGroup) Enum.Parse(typeof (ColorTableGroup), value);
        }

        private Color GetRowColor(int rowIndex)
        {
            return (Color) gridView.Rows[rowIndex].Tag;
        }

        private void SetRow(int rowIndex, ColorTableGroup? colorGroup, Color color, string name = null)
        {
            var row = gridView.Rows[rowIndex];
            var firstCell = row.Cells[ColorGroupColumnName];
            var colorCell = row.Cells[ColorValueColumnName];
            var imageCell = row.Cells[ColorColumnName];
            var buttonCell = row.Cells[EditColumnName];

            if (firstCell != null)
            {
                firstCell.Value = colorGroup == null ? name : colorGroup.ToString();
            }

            if (colorCell != null)
            {
                colorCell.Value =
                    color.IsNamedColor
                        ? color.Name
                        : string.Format(Resources.ColorText, color.A, color.R, color.G, color.B);
            }

            if (buttonCell != null)
            {
                buttonCell.Value = "...";
            }

            if (imageCell != null)
            {
                imageCell.Value = CreateColorPreview(imageCell.Value as Image, color,
                                                     Settings.Default.ColorWidth,
                                                     Settings.Default.ColorHeight);
            }

            row.Tag = color;
        }

        private Image CreateColorPreview(Image baseImage, Color color, int width, int height)
        {
            var image = baseImage ?? new Bitmap(width, height, PixelFormat.Format32bppArgb);
            var rect = new Rectangle(0, 0, image.Width - 1, image.Height - 1);

            using (var graphics = Graphics.FromImage(image))
            {
                // Grid.
                if (color.A < 255)
                {
                    graphics.Clear(color);
                    graphics.FillRectangle(
                        new HatchBrush(HatchStyle.DottedGrid, Color.Black, Color.Transparent),
                        rect);
                }

                // Color.
                graphics.FillRectangle(new SolidBrush(color), rect);

                // Border.
                graphics.DrawRectangle(Pens.Black, rect);
            }

            return image;
        }

        private void ResetAll()
        {
            Renderer.ColorTable.InitFromBase(true);
            Renderer.RefreshToolStrips();
            UpdateRows(gridView.Rows);

            if (RunningOnMono)
            {
                Refresh();
            }
        }

        private void ResetRowsAndColors(IEnumerable rows)
        {
            foreach (DataGridViewRow row in rows)
                Renderer.ColorTable.ResetColor(GetRowColorGroup(row.Index));

            Renderer.RefreshToolStrips();
            UpdateRows(rows);
        }

        private void UpdateRows(IEnumerable rows)
        {
            gridView.SuspendLayout();

            foreach (DataGridViewRow row in rows)
            {
                var group = GetRowColorGroup(row.Index);
                var color = Renderer.ColorTable[group];
                SetRow(row.Index, group, color);
            }

            gridView.ResumeLayout(false);
            gridView.Refresh();            
        }

        private static bool ClipboardHasData()
        {
            try
            {
                return Clipboard.ContainsData(DataFormats.Serializable);
            }
            catch (ExternalException)
            {
                // Clipboard is being used by another process.
                return false;
            }
        }

        private void Copy(DataGridViewRow row)
        {
            var color = GetRowColor(row.Index);
            var text = string.Format("{0}: {1}",
                                     row.Cells[ColorGroupColumnName].Value,
                                     row.Cells[ColorValueColumnName].Value);

            try
            {
                var dataObject = new DataObject();
                dataObject.SetText(text, TextDataFormat.Text);
                dataObject.SetData(DataFormats.Serializable, color);
                Clipboard.SetDataObject(dataObject, false, 5, 200);      
            }
            catch (ExternalException)
            {
                // Clipboard is being used by another process.
                SystemSounds.Beep.Play();
            }
        }

        private void Paste(IEnumerable rows)
        {
            var obj = Clipboard.GetData(DataFormats.Serializable);
            if (obj is Color)
            {
                var color = (Color) obj;
                foreach (DataGridViewRow row in rows)
                    UpdateRow(row.Index, color);
            }
            else
            {
                // Unknown format.
                SystemSounds.Beep.Play();
            }
        }

        private void UpdatePasteButton(bool forceEnabled)
        {
            pasteMenuItem.Enabled = 
                gridView.SelectedRows.Count > 0 && 
                (forceEnabled || ClipboardHasData());

            pastePopupItem.Enabled = pasteMenuItem.Enabled;
            pasteToolStripButton.Enabled = pasteMenuItem.Enabled;
        }

        private void EditRow(int rowIndex)
        {
            colorDialog.Color = GetRowColor(rowIndex);
            var result = colorDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                UpdateRow(rowIndex, colorDialog.Color);
            }        
        }        

        private void changeColor(Control c, Color color)
        {
            c.ForeColor = color;
            foreach (Control ctl in c.Controls)
                changeColor(ctl, color);
        }

        private void UpdateRow(int rowIndex, Color color)
        {
            var group = GetRowColorGroup(rowIndex);
            SetRow(rowIndex, group, colorDialog.Color);
            Renderer.ColorTable[group] = colorDialog.Color;

            switch (group)
            {
                case ColorTableGroup.FormForeColor:
                    changeColor(this, colorDialog.Color);
                    menuStrip.ForeColor = colorDialog.Color;
                    gridView.ForeColor = colorDialog.Color;
                    break;
                case ColorTableGroup.FormBackColor:
                    BackColor = colorDialog.Color;
                    gridView.BackColor = colorDialog.Color;
                    break;
                case ColorTableGroup.GridGridColor:
                    gridView.GridColor = colorDialog.Color;
                    break;
                case ColorTableGroup.GridBackColor:
                    BackColor = colorDialog.Color;
                    gridView.BackgroundColor = colorDialog.Color;
                    gridView.RowsDefaultCellStyle.BackColor = colorDialog.Color;
                    break;
        /*
                case ColorTableGroup.GridHeaderColor:
                    BackColor = colorDialog.Color;
                    gridView.RowsDefaultCellStyle. = colorDialog.Color;
                    break;
                case ColorTableGroup.SelectionForeColor:
                    BackColor = colorDialog.Color;
                    gridView.BackgroundColor = colorDialog.Color;
                    gridView.RowsDefaultCellStyle.BackColor = colorDialog.Color;
                    break;
                    */
                default:
                    break;
            }

            Renderer.RefreshToolStrips();
            gridView.Refresh();
        }

        #region Event Handlers

        private void KnownColorPopupClick(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item != null)
            {
                var color = (Color)item.Tag;
                foreach (DataGridViewRow row in gridView.SelectedRows)
                {
                    var group = GetRowColorGroup(row.Index);
                    SetRow(row.Index, group, color);
                    Renderer.ColorTable[group] = color;
                }

                gridView.Refresh();
                Renderer.RefreshToolStrips();
            }
        }

        private void GridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Edit color when user clicks on "...".
            var row = gridView.Rows[e.RowIndex];
            if (row.Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                EditRow(row.Index);
            }
        }

        private void ResetMenuItemClick(object sender, EventArgs e)
        {
            // Reset selected rows.
            ResetRowsAndColors(gridView.SelectedRows);
        }

        private void ClearMenuItemClick(object sender, EventArgs e)
        {
            // Clear selected rows.
            foreach (DataGridViewRow row in gridView.SelectedRows)
            {
                var group = GetRowColorGroup(row.Index);
                SetRow(row.Index, group, Color.Empty);
                Renderer.ColorTable[group] = Color.Empty;
            }

            Renderer.RefreshToolStrips();
            gridView.Refresh();
        }

        private void ExitMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveMenuItemClick(object sender, EventArgs e)
        {
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Generator.SaveAs(Renderer.ColorTable, saveFileDialog.FileName);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(string.Format(Resources.IOErrorText, ex.Message),
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenMenuItemClick(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Generator.LoadFrom(Renderer.ColorTable, openFileDialog.FileName);
                    UpdateRows(gridView.Rows);
                    Renderer.RefreshToolStrips();

                    if (RunningOnMono)
                    {
                        Refresh();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(string.Format(Resources.IOErrorText, ex.Message),
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show(Resources.ParseErrorText, Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NewMenuItemClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Resources.ResetPromptText, Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetAll();
            }
        }

        private void SelectAllMenuItemClick(object sender, EventArgs e)
        {
            gridView.SelectAll();
        }

        private void SetAlphaMenuItemClick(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null) return;

            int alpha;
            if (int.TryParse(item.Text, out alpha))
            {
                foreach (DataGridViewRow row in gridView.SelectedRows)
                {
                    Color color = GetRowColor(row.Index);
                    Color newColor = Color.FromArgb(alpha, color);
                    ColorTableGroup group = GetRowColorGroup(row.Index);
                    SetRow(row.Index, group, newColor);
                    Renderer.ColorTable[group] = newColor;
                }

                gridView.Refresh();
                Renderer.RefreshToolStrips();
            }
        }

        private void RowContextMenuOpening(object sender, CancelEventArgs e)
        {
            var alpha = 0.0;
            var count = 0;
            foreach (DataGridViewRow row in gridView.SelectedRows)
            {
                alpha += GetRowColor(row.Index).A;
                count++;
            }

            if (count > 0)
            {
                alpha = Math.Round(alpha / count);
                var index = (int)Math.Round(13.0 / 260.0 * alpha);
                var itemsCount = alphaMenuItem.DropDownItems.Count;

                for (var i = 0; i < itemsCount; i++)
                {
                    var item = (ToolStripMenuItem)alphaMenuItem.DropDownItems[i];
                    item.Checked = i == index;
                }
            }
        }

        private void NewFromPresetMenuItemClick(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item != null && item.Tag is PresetColorTable)
            {
                Renderer.ColorTable.InitFrom((PresetColorTable)item.Tag, true);
                UpdateRows(gridView.Rows);
                Renderer.RefreshToolStrips();

                if (RunningOnMono)
                {
                    Refresh();
                }
            }
        }

        private void ToolStripSplitButtonButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton.ShowDropDown();
        }

        private void CopyMenuItemClick(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 1)
            {
                Copy(gridView.SelectedRows[0]);
                UpdatePasteButton(true);
            }
        }

        private void GridViewSelectionChanged(object sender, EventArgs e)
        {
            copyMenuItem.Enabled = gridView.SelectedRows.Count == 1;
            copyPopupItem.Enabled = copyMenuItem.Enabled;
            copyToolStripButton.Enabled = copyMenuItem.Enabled;

            selectAllMenuItem.Enabled = gridView.SelectedRows.Count < gridView.Rows.Count;
            selectAllPopupItem.Enabled = selectAllMenuItem.Enabled;

            // Update status text.
            if (gridView.SelectedRows.Count == 0)
            {
                statusLabel.Text = string.Empty;
            }
            else if (gridView.SelectedRows.Count == 1)
            {
                statusLabel.Text = string.Format(
                    Resources.SelectedRowText,
                    gridView.SelectedRows[0].Cells[ColorGroupColumnName].Value);
            }
            else if (gridView.SelectedRows.Count > 0)
            {
                statusLabel.Text = string.Format(
                    Resources.SelectedRowsText,
                    gridView.SelectedRows.Count);
            }
        }

        private void PasteMenuItemClick(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count > 0 && ClipboardHasData())
            {
                Paste(gridView.SelectedRows);
                gridView.Refresh();
                Renderer.RefreshToolStrips();
            }
        }

        private void GridViewMouseDown(object sender, MouseEventArgs e)
        {
            // Right-click row selection.
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = gridView.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell && 
                    hitTest.RowIndex >= 0 && 
                    hitTest.ColumnIndex >= 0)
                {
                    var row = gridView.Rows[hitTest.RowIndex];
                    if (!row.Selected)
                    {
                        gridView.ClearSelection();
                        row.Selected = true;
                    }
                }
            }
        }

        private void OptionsMenuItemClick(object sender, EventArgs e)
        {
            using (var options = new OptionsForm())
                options.ShowDialog(this);
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // Upgrade settings from previous versions.
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }

            //ToolStripManager.LoadSettings(this);
            roundedEdgesMenuItem.Checked = Settings.Default.RoundedEdges;
        }

        private void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            //ToolStripManager.SaveSettings(this);
            Settings.Default.Save();
        }

        private void ToolStripCheckPreviewButtonCheckedChanged(object sender, EventArgs e)
        {
            toolStripCheckPreviewButton.Text = toolStripCheckPreviewButton.Checked ? 
                Resources.CheckedText : Resources.UncheckedText;
        }

        private void AboutMenuItemClick(object sender, EventArgs e)
        {
            using (var about = new AboutBox())
            {
                about.ShowDialog(this);
            }
        }

        private void MainFormActivated(object sender, EventArgs e)
        {
            UpdatePasteButton(false);
        }

        private void GridViewCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && gridView.SelectedRows.Count == 1)
            {
                EditRow(gridView.SelectedRows[0].Index);
            }
        }

        private void RoundedEdgesMenuItemCheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.RoundedEdges = roundedEdgesMenuItem.Checked;
            Renderer.RoundedEdges = roundedEdgesMenuItem.Checked;
            Renderer.RefreshToolStrips();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }

        private void FindMenuItemClick(object sender, EventArgs e)
        {
            searchTextBox.Focus();
        }

        private void SearchTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cancelButton.PerformClick();
                e.Handled = true;
            }
        }

        private void SearchTextBoxTextChanged(object sender, EventArgs e)
        {
            var isEmpty = string.IsNullOrEmpty(searchTextBox.Text);
            cancelButton.Enabled = !isEmpty;

            // Cancel current search.
            searchWorker.CancelAsync();
            while (searchWorker.IsBusy)
            {
                Application.DoEvents();
            }

            if (isEmpty)
            {
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                searchWorker.RunWorkerAsync(searchTextBox.Text);
            }
        }

        private void GridViewEnter(object sender, EventArgs e)
        {
            clearMainMenuItem.Enabled = true;
        }

        private void GridViewLeave(object sender, EventArgs e)
        {
            clearMainMenuItem.Enabled = false;
        }

        private void OnSearchWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var args = (object[]) e.UserState;
            ((DataGridViewRow) args[0]).Visible = (bool) args[1];
        }

        private void SearchWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var text = (string) e.Argument;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                var value = row.Cells[ColorGroupColumnName].Value.ToString();
                var contains = value.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0;

                // Hide/show gridview row.
                searchWorker.ReportProgress(0, new object[] {row, contains});

                if (searchWorker.CancellationPending) break;
            }
        }

        private void ColorAdjustmentMenuItemClick(object sender, EventArgs e)
        {
            if (colorAdjustForm.ShowDialog() == DialogResult.OK)
            {
                UpdateRows(gridView.Rows);
            }

            Renderer.RefreshToolStrips();
        }

    #endregion

    private void screenColorMenuItem_Click(object sender, EventArgs e)
    {
      using (var form = new ScreenColorPickerForm{ ForeColor = this.ForeColor, BackColor = this.BackColor })
      try {
        this.WindowState = FormWindowState.Minimized;

        if (form.ShowDialog(this) == DialogResult.OK)
        {
          foreach (DataGridViewRow row in gridView.SelectedRows)
          {
            Color color = GetRowColor(row.Index);
            Color newColor = form.SelectedColor;
            var group = GetRowColorGroup(row.Index);
            SetRow(row.Index, group, newColor);
            Renderer.ColorTable[group] = newColor;
          }
        }
      }
      finally { 
        this.WindowState = FormWindowState.Normal;
        this.Activate();
      }
    }
  }
}
