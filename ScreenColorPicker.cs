using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToolStripCustomizer
{
  /// <summary>
  /// Custom form that gives the user ability to pick a color on the screen.
  /// Sample usage:
  /// <code>
  /// Application.Run(new ScreenColorPickerForm() {ForeColor = Color.Black, BackColor = Color.LemonChiffon});
  /// </code>
  /// </summary>
  #region ScreenColorPickerForm
  public class ScreenColorPickerForm : Form
  {
    #region Ctor

    public ScreenColorPickerForm()
    {
      InitializeComponent();
      magnifyingGlass1.UpdateTimer.Start();
      magnifyingGlass1.MovingGlassForm.MagnifyingGlass.Click +=
        new EventHandler(MagnifyingGlass_Click);
      magnifyingGlass1.MovingGlassForm.VisibleChanged +=
        new EventHandler(MovingGlass_VisibleChanged);
      magnifyingGlass1.MovingGlassForm.MagnifyingGlass.BeforeMakingScreenshot +=
        new MagnifyingGlass.MakingScreenshotDelegate(
          MagnifyingGlass_BeforeMakingScreenshot);
      magnifyingGlass1.MovingGlassForm.MagnifyingGlass.AfterMakingScreenshot +=
        new MagnifyingGlass.MakingScreenshotDelegate(MagnifyingGlass_AfterMakingScreenshot);

      SelectedColor = panel2.BackColor;
    }

    private bool m_Stopped = false;

    protected override void OnClosed(EventArgs e)
    {
      m_Stopped = true;
      base.OnClosed(e);
    }

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
        components.Dispose();
      base.Dispose(disposing);
    }

    #endregion Ctor

    #region Fields

    public new Color ForeColor
    {
      get { return base.ForeColor; }
      set
      {
        base.ForeColor = value;
        this.groupBox1.ForeColor = value;
        btnOk.ForeColor = value;
        btnCancel.ForeColor = value;
      }
    }

    public new Color BackColor
    {
      get { return base.BackColor; }
      set
      {
        base.BackColor = value;
        btnOk.BackColor = value;
        btnCancel.BackColor = value;
      }
    }

    /// <summary>
    /// Color selected by user
    /// </summary>
    public Color SelectedColor { get; private set; }

    #endregion Fields

    #region Initialization

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.magnifyingGlass1 = new ToolStripCustomizer.MagnifyingGlass();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      //
      // panel1
      //
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Location = new System.Drawing.Point(123, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(105, 105);
      this.panel1.TabIndex = 1;
      //
      // checkBox1
      //
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(12, 123);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(131, 17);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "Show the current pixel";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      //
      // checkBox2
      //
      this.checkBox2.AutoSize = true;
      this.checkBox2.Checked = true;
      this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox2.Location = new System.Drawing.Point(12, 146);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(178, 17);
      this.checkBox2.TabIndex = 3;
      this.checkBox2.Text = "Show the current cursor position";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
      //
      // groupBox1
      //
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.panel2);
      this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
      this.groupBox1.Location = new System.Drawing.Point(12, 169);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(216, 73);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Last selected color";
      //
      // label3
      //
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 45);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(0, 13);
      this.label3.TabIndex = 3;
      //
      // label2
      //
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 13);
      this.label2.TabIndex = 2;
      //
      // label1
      //
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 13);
      this.label1.TabIndex = 1;
      //
      // panel2
      //
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Location = new System.Drawing.Point(111, 19);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(99, 39);
      this.panel2.TabIndex = 0;
      //
      // magnifyingGlass1
      //
      this.magnifyingGlass1.BackColor = System.Drawing.Color.Black;
      this.magnifyingGlass1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.magnifyingGlass1.Cursor = System.Windows.Forms.Cursors.SizeAll;
      this.magnifyingGlass1.ForeColor = System.Drawing.Color.Gray;
      this.magnifyingGlass1.Location = new System.Drawing.Point(12, 12);
      this.magnifyingGlass1.Name = "magnifyingGlass1";
      this.magnifyingGlass1.PixelRange = 10;
      this.magnifyingGlass1.PixelSize = 5;
      this.magnifyingGlass1.PosAlign = System.Drawing.ContentAlignment.TopLeft;
      this.magnifyingGlass1.PosFormat = "#x ; #y";
      this.magnifyingGlass1.ShowPixel = true;
      this.magnifyingGlass1.ShowPosition = true;
      this.magnifyingGlass1.Size = new System.Drawing.Size(105, 105);
      this.magnifyingGlass1.TabIndex = 0;
      this.magnifyingGlass1.UseMovingGlass = true;
      this.magnifyingGlass1.DisplayUpdated += new ToolStripCustomizer.MagnifyingGlass.DisplayUpdatedDelegate(this.magnifyingGlass1_DisplayUpdated);
      //
      // btnOk
      //
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOk.ForeColor = System.Drawing.Color.LightGray;
      this.btnOk.Location = new System.Drawing.Point(27, 255);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(85, 23);
      this.btnOk.TabIndex = 5;
      this.btnOk.Text = "&Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      //
      // btnCancel
      //
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
      this.btnCancel.Location = new System.Drawing.Point(129, 255);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(85, 23);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      //
      // ScreenColorPickerForm
      //
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(240, 290);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.magnifyingGlass1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.BackColor = Color.FromArgb(255, 45, 45, 48);
      this.ForeColor = Color.LightGray;
      this.MinimizeBox = false;
      this.Name = "ScreenColorPickerForm";
      this.ShowIcon = false;
      this.Text = "Desktop Color Picker";
      this.TopMost = true;
      this.Deactivate += new System.EventHandler(this.GUI_Deactivate);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion Initialization

    #region Private

    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private MagnifyingGlass magnifyingGlass1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private Button btnOk;
    private Button btnCancel;
    private System.Windows.Forms.Panel panel2;

    private void MovingGlass_VisibleChanged(object sender, EventArgs e)
    {
      // Make this not the top window if the moving glass is shown because it will hide the glass display otherwise
      TopMost = !magnifyingGlass1.MovingGlassForm.Visible;
    }

    private void MagnifyingGlass_Click(object sender, EventArgs e)
    {
      // Select the color trough the moving glass
      SelectColor();
    }

    private void magnifyingGlass1_DisplayUpdated(MagnifyingGlass sender)
    {
      // Update the current color preview panels background color
      panel1.BackColor = magnifyingGlass1.PixelColor;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      // Troggle the pixel view
      magnifyingGlass1.ShowPixel = checkBox1.Checked;
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      // Troggle the position view
      magnifyingGlass1.ShowPosition = checkBox2.Checked;
    }

    private void GUI_Deactivate(object sender, EventArgs e)
    {
      // Select the current color if the form lost the focus
      if (!magnifyingGlass1.MovingGlassForm.Visible)
      {
        SelectColor();
      }
    }

    private void SelectColor()
    {
      // Memorize the selection if we are still capturing the color off the screen
      if (!m_Stopped)
        SelectedColor = panel1.BackColor;
      // Show the selected color and properties
      panel2.BackColor = panel1.BackColor;
      label1.Text = "R: " + panel2.BackColor.R.ToString();
      label2.Text = "G: " + panel2.BackColor.G.ToString();
      label3.Text = "B: " + panel2.BackColor.B.ToString();
      // Try to activate the form after selecting a color because we lost the focus for sure
      Activate();
    }

    private void MagnifyingGlass_AfterMakingScreenshot(object sender)
    {
      // Show this again after the screenshot has been taken
      Show();
    }

    private void MagnifyingGlass_BeforeMakingScreenshot(object sender)
    {
      // Hide this before the moving glass will take thescreenshot for working with it as screen image
      Hide();
    }

    #endregion Private
  }
  #endregion

  #region -- MagnifyingGlass User Control --

  /// <summary>
  /// A fixed magnifying glass for placing on a control
  /// </summary>
  public partial class MagnifyingGlass : UserControl
  {
    private System.Windows.Forms.Timer _UpdateTimer = new System.Windows.Forms.Timer();
    private int _PixelSize = 5;
    private int _PixelRange = 10;
    private bool _ShowPixel = true;
    private bool _ShowPosition = true;
    private string _PosFormat = "#x ; #y";
    private bool _FollowCursor = false;
    internal Bitmap _ScreenShot = null;
    internal MagnifyingGlassForm m_StationaryGlassForm = null;
    private Point _LastPosition = Point.Empty;
    private MagnifyingGlassForm m_MovingGlassForm = null;
    private ContentAlignment _PosAlign = ContentAlignment.TopLeft;
    private bool _UseMovingGlass = false;
    private static bool _UseWin32Api = false;

    /// <summary>
    /// Instance of the magnifying glass with moving glass, if the user clicks on this one
    /// </summary>
    public MagnifyingGlass()
        : this(true)
    {
    }

    /// <summary>
    /// Instance of the magnifying glass
    /// </summary>
    /// <param name="movingGlass">Create a moving glass if the user clicks on this one?</param>
    public MagnifyingGlass(bool movingGlass)
    {
      if (movingGlass)
      {
        // Moving glass is enabled
        m_MovingGlassForm = new MagnifyingGlassForm();
        MovingGlassForm.MagnifyingGlass.ShowPosition = false;
        MovingGlassForm.MagnifyingGlass.DisplayUpdated += new DisplayUpdatedDelegate(MagnifyingGlass_DisplayUpdated);
        MovingGlassForm.MagnifyingGlass.Click += new EventHandler(_MovingGlass_Click);
        MouseWheel += new MouseEventHandler(MagnifyingGlass_MouseWheel);
        Cursor = Cursors.SizeAll;
        UseMovingGlass = true;
      }
      _UpdateTimer.Tick += new System.EventHandler(_UpdateTimer_Tick);
      Click += new System.EventHandler(MagnifyingGlass_Click);
      CalculateSize();
    }

    #region Properties

    [Description("Magnifying ratio (calculate PixelRange*PixelSize*2+PixelSize for the final control size, min. 3)")]
    public int PixelSize
    {
      get
      {
        return _PixelSize;
      }
      set
      {
        int temp = value;
        if (temp < 3)
        {
          // Minimum size
          temp = 3;
        }
        if ((double)temp / 2 == (double)Math.Floor((double)temp / 2))
        {
          // Use only integers that can't be divided by 2
          temp++;
        }
        _PixelSize = temp;
        CalculateSize();
      }
    }

    [Description("Get/set if the moving glass feature should be used")]
    public bool UseMovingGlass
    {
      get
      {
        return _UseMovingGlass;
      }
      set
      {
        if (MovingGlassForm != null)
        {
          _UseMovingGlass = value;
        }
      }
    }

    [Description("Get/set the align of the position (choose everything, but not the middle")]
    public ContentAlignment PosAlign
    {
      get
      {
        return _PosAlign;
      }
      set
      {
        _PosAlign = (!value.ToString().ToLower().StartsWith("middle")) ? value : ContentAlignment.TopLeft;
      }
    }

    [Description("Get/set the position display string format (you have to use #x and #y for the corrdinates values)")]
    public string PosFormat
    {
      get
      {
        return _PosFormat;
      }
      set
      {
        // Settings without the #x and #y variables will be ignored
        _PosFormat = (value != null && value != "" && value.Contains("#x") && value.Contains("#y")) ? value : "#x ; #y";
        Invalidate();
      }
    }

    [Description("The moving glass, if the user clicks on this")]
    public MagnifyingGlassForm MovingGlassForm
    {
      get
      {
        return m_MovingGlassForm;
      }
    }

    /// <summary>
    /// Returns true, if enabled, visible and not in designer mode
    /// </summary>
    [Browsable(false)]
    public bool IsEnabled
    {
      get
      {
        return Visible && Enabled && !DesignMode;
      }
    }

    /// <summary>
    /// You may use the Win32 API to get screenshots with alpha / layered windows
    /// </summary>
    [Browsable(false)]
    public static bool UseWin32Api
    {
      get
      {
        return _UseWin32Api;
      }
      set
      {
        _UseWin32Api = value;
      }
    }

    [Browsable(false)]
    internal bool FollowCursor
    {
      get
      {
        return _FollowCursor;
      }
      set
      {
        if (!(_FollowCursor = value))
        {
          // Exit the following mode
          if (_ScreenShot != null)
          {
            _ScreenShot.Dispose();
            _ScreenShot = null;
          }
        }
      }
    }

    [Description("Get/set the pixel range (calculate PixelRange*PixelSize*2+PixelSize for the final control size, min. 1)")]
    public int PixelRange
    {
      get
      {
        return _PixelRange;
      }
      set
      {
        int temp = value;
        if (temp < 1)
        {
          // Minimum range is one pixel
          temp = 1;
        }
        _PixelRange = temp;
        CalculateSize();
      }
    }

    [Description("Get/set if the active pixel should be shown")]
    public bool ShowPixel
    {
      get
      {
        return _ShowPixel;
      }
      set
      {
        _ShowPixel = value;
        Invalidate();
      }
    }

    [Description("Get/set if the current cursor position should be shown")]
    public bool ShowPosition
    {
      get
      {
        return _ShowPosition;
      }
      set
      {
        _ShowPosition = value;
        Invalidate();
      }
    }

    [Description("Get the control size (settings will be ignored)")]
    new public Size Size
    {
      get { return base.Size; }
      set
      {
        // Settings will be ignored 'cause size will be calculated internal
      }
    }

    [Description("Get the timer that updates the display in an interval")]
    public Timer UpdateTimer
    {
      get
      {
        return _UpdateTimer;
      }
    }

    [Description("Get the color of the current pixel")]
    public Color PixelColor
    {
      get
      {
        Bitmap bmp = null;
        try
        {
          // Make a screenshot of the pixel from the current cursor position
          bmp = new Bitmap(1, 1);
          using (Graphics g = Graphics.FromImage(bmp))
          {
            bool makeScreenshot = !FollowCursor;// Make a real screenshot?
            if (makeScreenshot)
            {
              if (MovingGlassForm != null)
              {
                //Only make a real screenshot if the moving glass is inactive
                makeScreenshot &= !MovingGlassForm.Visible;
              }
            }
            if (!FollowCursor)
            {
              // Make a real screenshot
              g.DrawImage(MakeScreenshot(new Rectangle(Cursor.Position, bmp.Size)), new Point(0, 0));
            }
            else
            {
              // Use the screen image for the screenshot
              bool createScreenshot = false;// Did we create a screenshot for this?
              if (FollowCursor)
              {
                // Create the screenshot only if it wasn't done yet
                createScreenshot = _ScreenShot == null;
              }
              else
              {
                // Create the screenshot only of the moving glass has not done it yet
                createScreenshot = MovingGlassForm.MagnifyingGlass._ScreenShot == null;
              }
              if (createScreenshot)
              {
                // Create a new screen image
                MakeScreenshot();
              }
              if (FollowCursor)
              {
                // We're the moving glass
                g.DrawImage(_ScreenShot, new Rectangle(new Point(0, 0), new Size(1, 1)), new Rectangle(Cursor.Position, new Size(1, 1)), GraphicsUnit.Pixel);
              }
              else
              {
                // Use the moving glasses screenshot
                g.DrawImage(MovingGlassForm.MagnifyingGlass._ScreenShot, new Rectangle(new Point(0, 0), new Size(1, 1)), new Rectangle(Cursor.Position, new Size(1, 1)), GraphicsUnit.Pixel);
              }
              if (createScreenshot)
              {
                // Destroy the screenshot if we only needed to create one for this
                _ScreenShot.Dispose();
              }
            }
          }
          // Return the pixel color
          return bmp.GetPixel(0, 0);
        }
        finally
        {
          bmp.Dispose();
        }
      }
    }

    #endregion Properties

    #region Painting

    protected override void OnPaintBackground(PaintEventArgs e)
    {
      // Only paint the background, if we're disabled or in DesignMode
      if (!IsEnabled)
      {
        base.OnPaintBackground(e);
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      if (!IsEnabled)
      {
        // Draw only if visible, enabled and not in DesignMode
        return;
      }
      // Set the InterpolationMode to NearestNeighbor to see the pixels clearly
      e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
      // Prepare some shortcut variables for a better overview
      Point pos = Cursor.Position;
      Rectangle scr = Screen.PrimaryScreen.Bounds;// The screen size
      Point zeroPoint = new Point(0, 0);
      #region Set the new display window location if we follow the cursor
      if (FollowCursor)
      {
        Point loc = new Point(Cursor.Position.X - PixelRange * PixelSize, Cursor.Position.Y - PixelRange * PixelSize);
        if (loc.X < 0)
        {
          loc = new Point(0, loc.Y);
        }
        if (loc.X + Width > Screen.PrimaryScreen.Bounds.Width)
        {
          loc = new Point(Screen.PrimaryScreen.Bounds.Width - Width, loc.Y);
        }
        if (loc.Y < 0)
        {
          loc = new Point(loc.X, 0);
        }
        if (loc.Y + Height > Screen.PrimaryScreen.Bounds.Height)
        {
          loc = new Point(loc.X, Screen.PrimaryScreen.Bounds.Height - Height);
        }
        m_StationaryGlassForm.Location = loc;
      }

      #endregion Set the new display window location if we follow the cursor

      #region Make the screenshot

      Rectangle shot = new Rectangle(zeroPoint, new Size(Size.Width / PixelSize, Size.Height / PixelSize));// The final screenshot size and position
      Point defaultLocation = new Point(pos.X - PixelRange, pos.Y - PixelRange);// The screenshot default location
      shot.Location = defaultLocation;
      if (shot.Location.X < 0)
      {
        // The area is going over the left screen border
        shot.Size = new Size(shot.Size.Width + shot.Location.X, shot.Size.Height);
        shot.Location = new Point(0, shot.Location.Y);
      }
      else if (shot.Location.X > scr.Width)
      {
        // The area is going over the right screen border
        shot.Size = new Size(shot.Location.X - scr.Width, shot.Size.Height);
      }
      if (shot.Location.Y < 0)
      {
        // The area is going over the upper screen border
        shot.Size = new Size(shot.Size.Width, shot.Size.Height + shot.Location.Y);
        shot.Location = new Point(shot.Location.X, 0);
      }
      else if (shot.Location.Y > scr.Height)
      {
        // The area is going over the bottom screen border
        shot.Size = new Size(shot.Size.Width, shot.Location.Y - scr.Height);
      }
      if (shot.Width < 0 || shot.Height < 0)
        return;

      Bitmap screenShot = new Bitmap(shot.Width, shot.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);// The screenshot imag;
      using (Graphics g = Graphics.FromImage(screenShot))
      {
        bool makeScreenshot = !FollowCursor;// Make areal screenshot?
        if (makeScreenshot)
        {
          if (MovingGlassForm != null)
          {
            // Only make a real screenshot if the moving glass is inactive
            makeScreenshot &= !MovingGlassForm.Visible;
          }
        }
        if (makeScreenshot)
        {
          // Make screenshot
          g.DrawImage(MakeScreenshot(shot), zeroPoint);
        }
        else
        {
          // Copy from work screenshot
          if (FollowCursor)
          {
            // We're the moving glass
            g.DrawImage(_ScreenShot, new Rectangle(zeroPoint, screenShot.Size), shot, GraphicsUnit.Pixel);
          }
          else
          {
            // We're not the moving glass, but we should use the work screenshot
            // of the moving glass, 'cause if it's fully visible we'd copy the
            // moving glass display area...
            g.DrawImage(MovingGlassForm.MagnifyingGlass._ScreenShot, new Rectangle(zeroPoint, screenShot.Size), shot, GraphicsUnit.Pixel);
          }
        }
      }

      #endregion Make the screenshot

      #region Paint the screenshot scaled to the display

      Rectangle display = new Rectangle(zeroPoint, Size);// The rectangle within the display to show the screenshot
      Size displaySize = new Size(shot.Width * PixelSize, shot.Height * PixelSize);// The default magnified screenshot size
      if (defaultLocation.X < 0 || defaultLocation.X > scr.Width)
      {
        if (defaultLocation.X < 0)
        {
          // Display the screenshot with right align
          display.Location = new Point(display.Width - displaySize.Width, display.Location.Y);
        }
        // Change the display area width to the width of the magnified screenshot
        display.Size = new Size(displaySize.Width, display.Size.Height);
      }
      if (defaultLocation.Y < 0 || defaultLocation.Y > scr.Height)
      {
        if (defaultLocation.Y < 0)
        {
          // Display the screenshot with bottom align
          display.Location = new Point(display.Location.X, display.Height - displaySize.Height);
        }
        // Change the display area height to the height of the magnified screenshot
        display.Size = new Size(display.Size.Width, displaySize.Height);
      }
      if (displaySize != Size)
      {
        // Paint the background 'cause the magnified screenshot size is different from the display size and we have a out-of-screen area
        e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(zeroPoint, Size));
      }
      // Scale and paint the screenshot
      e.Graphics.DrawImage(screenShot, display);
      screenShot.Dispose();

      #endregion Paint the screenshot scaled to the display

      #region Paint everything else to the display

      // Show the current pixel in a black/white bordered rectangle in the middle of the display
      if (ShowPixel)
      {
        int xy = PixelSize * PixelRange;
        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(new Point(xy, xy), new Size(PixelSize, PixelSize)));
        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White)), new Rectangle(new Point(xy + 1, xy + 1), new Size(PixelSize - 2, PixelSize - 2)));
      }
      // Show the cursor position coordinates on a fixed colored background rectangle in the display
      if (ShowPosition)
      {
        // Parse the format string
        string posText = PosFormat;
        posText = posText.Replace("#x", pos.X.ToString());
        posText = posText.Replace("#y", pos.Y.ToString());
        // Calculate where to paint
        Size textSize = e.Graphics.MeasureString(posText, Font).ToSize();
        if (textSize.Width + 6 <= Width && textSize.Height + 6 <= Height)// Continue only if the display is bigger or equal to the needed size
        {
          string posString = PosAlign.ToString().ToLower();// The align as text (for less code)
          Point posZero = Point.Empty;// The zero coordinates for the position display
          if (posString.StartsWith("top"))
          {
            posZero = new Point(0, 0);
          }
          else
          {
            posZero = new Point(0, Height - textSize.Height);
          }
          if (posString.Contains("center"))
          {
            posZero = new Point((int)Math.Ceiling((double)(Width - textSize.Width) / 2), posZero.Y);
          }
          else if (posString.Contains("right"))
          {
            posZero = new Point(Width - textSize.Width - 6, posZero.Y);
          }
          // Paint the text background rectangle and the text on it
          e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(posZero, new Size(textSize.Width + 6, textSize.Height + 6)));
          e.Graphics.DrawString(posText, Font, new SolidBrush(ForeColor), new PointF(posZero.X + 3, posZero.Y + 3));
        }
      }

      #endregion Paint everything else to the display
    }

    #endregion Painting

    /// <summary>
    /// Set a new size
    /// </summary>
    /// <param name="pixelSize">Pixel size value</param>
    /// <param name="pixelRange">Pixel range value</param>
    public void SetNewSize(int pixelSize, int pixelRange)
    {
      SuspendLayout();
      PixelSize = pixelSize;
      PixelRange = pixelRange;
      ResumeLayout(true);
    }

    private void CalculateSize()
    {
      // Calculate the new control size depending on the magnifying ratio and the pixel range to display
      int wh = PixelSize * (PixelRange * 2 + 1);
      base.Size = new Size(wh, wh);
    }

    private void _UpdateTimer_Tick(object sender, EventArgs e)
    {
      try
      {
        // Redraw and continue the timer if we're visible, enabled and not in DesignMode
        // The timer is also disabled here because the Timer component seems to have an error (it will crashafter a while!?). Restarting the timer is a workaround.
        UpdateTimer.Stop();
        if (IsEnabled)
        {
          if (_LastPosition == Cursor.Position)
          {
            // Refresh only if the position has changed
            return;
          }
          // Remember the current cursor position
          _LastPosition = Cursor.Position;
          // Repaint everything
          Invalidate();
          // Release the event after the display has been updated
          OnDisplayUpdated();
        }
      }
      finally
      {
        // Restart the timer
        UpdateTimer.Start();
      }
    }

    /// <summary>
    /// Delegate for the DisplayUpdated event
    /// </summary>
    /// <param name="sender">The sending MagnifyingGlass control</param>
    public delegate void DisplayUpdatedDelegate(MagnifyingGlass sender);

    /// <summary>
    /// Fired after the display has been refreshed by the UpdateTimer or the moving glass
    /// </summary>
    public event DisplayUpdatedDelegate DisplayUpdated;

    private void OnDisplayUpdated()
    {
      if (DisplayUpdated != null)
      {
        DisplayUpdated(this);
      }
    }

    private Bitmap MakeScreenshot(Rectangle rect)
    {
      // Capture an rectangle area from the screen
      Bitmap bmp = new Bitmap(rect.Width, rect.Height);
      using (Graphics g = Graphics.FromImage(bmp))
      {
        if (UseWin32Api)
        {
          // We're using BitBlt from the GDI API to copy alpha / layered screen regions also
          IntPtr gHdc = g.GetHdc();
          IntPtr dHdc = W32.GetDesktopWindow();
          IntPtr wHdc = W32.GetWindowDC(dHdc);
          W32.BitBlt(gHdc, 0, 0, bmp.Width, bmp.Height, wHdc, rect.X, rect.Y, W32.SRCCOPY | W32.CAPTUREBLT);
          W32.ReleaseDC(dHdc, wHdc);
          g.ReleaseHdc(gHdc);
          gHdc = IntPtr.Zero;
          dHdc = IntPtr.Zero;
          wHdc = IntPtr.Zero;
        }
        else
        {
          // The standard C# screen capturing
          g.CopyFromScreen(rect.Location, new Point(0, 0), bmp.Size);
        }
      }
      return bmp;
    }

    #region Moving glass related methods

    internal void MakeScreenshot()
    {
      // Copy the current screen without this control for the following glass
      OnBeforeMakingScreenshot();
      bool visible = m_StationaryGlassForm.Visible;
      if (visible)
      {
        m_StationaryGlassForm.Visible = false;
      }
      _ScreenShot = MakeScreenshot(new Rectangle(new Point(0, 0), Screen.PrimaryScreen.Bounds.Size));
      if (visible)
      {
        m_StationaryGlassForm.Visible = true;
      }
      OnAfterMakingScreenshot();
    }

    private void MagnifyingGlass_Click(object sender, EventArgs e)
    {
      // Show the moving glass
      if (MovingGlassForm != null && IsEnabled && UseMovingGlass)
      {
        MovingGlassForm.Show(MousePosition);
      }
    }

    private void MagnifyingGlass_MouseWheel(object sender, MouseEventArgs e)
    {
      // Resize on mouse wheel actions
      if (m_StationaryGlassForm != null && e.Delta != 0)
      {
        if (e.Delta > 0)
        {
          if ((PixelRange + 1) * PixelRange * 2 <= Screen.PrimaryScreen.Bounds.Width && (PixelRange + 1) * PixelRange * 2 <= Screen.PrimaryScreen.Bounds.Height)
          {
            PixelRange++;
            PixelSize += 2;
          }
        }
        else
        {
          if (PixelRange - 1 >= 5)
          {
            PixelRange--;
          }
          if (PixelSize > 3)
          {
            PixelSize -= 2;
          }
        }
      }
    }

    private void _MovingGlass_Click(object sender, EventArgs e)
    {
      // Hide the moving glass on mouse click
      MovingGlassForm.Hide();
    }

    private void MagnifyingGlass_DisplayUpdated(MagnifyingGlass sender)
    {
      // Refresh if the moving one has refreshed
      Invalidate();
      OnDisplayUpdated();
    }

    /// <summary>
    /// Delegate for the BeforeMakingScreenshot and the AfterMakingScreenshot events
    /// </summary>
    /// <param name="sender">The sending MagnifyingGlass object</param>
    public delegate void MakingScreenshotDelegate(object sender);

    /// <summary>
    /// Fired before making a screenshot
    /// </summary>
    public event MakingScreenshotDelegate BeforeMakingScreenshot;

    /// <summary>
    /// Fired after making a screenshot
    /// </summary>
    public event MakingScreenshotDelegate AfterMakingScreenshot;

    private void OnBeforeMakingScreenshot()
    {
      if (BeforeMakingScreenshot != null)
      {
        BeforeMakingScreenshot(this);
      }
    }

    private void OnAfterMakingScreenshot()
    {
      if (AfterMakingScreenshot != null)
      {
        AfterMakingScreenshot(this);
      }
    }

    #endregion Moving glass related methods

    #region Windows API

    /// <summary>
    /// This private class is holding all used Win32 API calls and constants
    /// </summary>
    private static class W32
    {
      /// <summary>
      /// Copy the source with BitBlt
      /// </summary>
      public const int SRCCOPY = 0x00CC0020;

      /// <summary>
      /// Copy alpha / layered with BitBlt
      /// </summary>
      public const int CAPTUREBLT = 0x40000000;

      /// <summary>
      /// BitBlt method from the GDI API
      /// </summary>
      /// <param name="hDestDC">Destination DC handle</param>
      /// <param name="x">Destination x</param>
      /// <param name="y">Destination y</param>
      /// <param name="nWidth">Destination width</param>
      /// <param name="nHeight">Destination height</param>
      /// <param name="hSrcDC">Source DC handle</param>
      /// <param name="xSrc">Source x</param>
      /// <param name="ySrc">Source y</param>
      /// <param name="dwRop">Options</param>
      /// <returns>Result</returns>
      [DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
      public static extern UInt64 BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, System.Int32 dwRop);

      /// <summary>
      /// Get the desktop window handle
      /// </summary>
      /// <returns>Desktop window handle</returns>
      [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
      public static extern IntPtr GetDesktopWindow();

      /// <summary>
      /// Get a window DC
      /// </summary>
      /// <param name="hwnd">Window handle</param>
      /// <returns>Window DC</returns>
      [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
      public static extern IntPtr GetWindowDC(IntPtr hwnd);

      /// <summary>
      /// Release a DC
      /// </summary>
      /// <param name="hwnd">Window handle</param>
      /// <param name="dc">Window DC</param>
      /// <returns>Result</returns>
      [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
      public static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);
    }

    #endregion Windows API
  }

  #endregion -- MagnifyingGlass User Control --

  #region -- MagnifyingGlassForm --

  /// <summary>
  /// A free magnifying glass that follows the cursor
  /// </summary>
  public class MagnifyingGlassForm : Form
  {
    private MagnifyingGlass m_MagnifyingGlass = new MagnifyingGlass(false);

    public MagnifyingGlassForm()
    {
      Opacity = .75; // Added because it makes things easier
      ShowInTaskbar = false;
      ShowIcon = false;
      FormBorderStyle = FormBorderStyle.None;
      MagnifyingGlass.PixelSize = 10;
      MagnifyingGlass.PixelRange = 5;
      MagnifyingGlass.BackColor = Color.Black;
      MagnifyingGlass.ForeColor = Color.White;
      MagnifyingGlass.UpdateTimer.Interval = 50;
      MagnifyingGlass.m_StationaryGlassForm = this;
      MagnifyingGlass.FollowCursor = true;
      MagnifyingGlass.BorderStyle = BorderStyle.FixedSingle;
      MagnifyingGlass.Resize += new EventHandler(MagnifyingGlass_Resize);
      MagnifyingGlass.Location = new Point(0, 0);
      Controls.Add(MagnifyingGlass);
      Size = MagnifyingGlass.Size;
      Text = "Magnifying Glass";
    }

    /// <summary>
    /// Show the window and enable the timer
    /// </summary>
    /// <param name="mousePosition"></param>
    public new void Show()
    {
      Show(new Point(0, 0));
    }

    public void Show(Point mousePosition)
    {
      MagnifyingGlass.MakeScreenshot();
      Cursor.Position = mousePosition;
      base.Show();
      MagnifyingGlass.UpdateTimer.Start();
      Cursor.Hide();
    }

    /// <summary>
    /// Hide the window and disable the timer
    /// </summary>
    public new void Hide()
    {
      base.Hide();
      MagnifyingGlass.UpdateTimer.Stop();
      Cursor.Show();
      if (MagnifyingGlass._ScreenShot == null)
      {
        MagnifyingGlass._ScreenShot.Dispose();
        MagnifyingGlass._ScreenShot = null;
      }
    }

    private void MagnifyingGlass_Resize(object sender, EventArgs e)
    {
      // Always stay as big as the glass
      Size = MagnifyingGlass.Size;
    }

    /// <summary>
    /// The magnifying glass object
    /// </summary>
    [Description("The magnifying glass object")]
    public MagnifyingGlass MagnifyingGlass { get { return m_MagnifyingGlass; } }

  }

  #endregion -- MagnifyingGlassForm --
}