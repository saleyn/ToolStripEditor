namespace ToolStripCustomizer
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.CheckBox headerCheckBox;
            System.Windows.Forms.Button cancelButton;
            System.Windows.Forms.Button okButton;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.namespaceTextBox = new System.Windows.Forms.TextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            headerCheckBox = new System.Windows.Forms.CheckBox();
            cancelButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(284, 308);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            tabPage1.Size = new System.Drawing.Size(276, 280);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Options";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(8, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            groupBox1.Size = new System.Drawing.Size(260, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Code generation";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(headerCheckBox, 0, 2);
            tableLayoutPanel1.Controls.Add(this.namespaceTextBox, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(5, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(250, 73);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "&Namespace:";
            // 
            // headerCheckBox
            // 
            headerCheckBox.AutoSize = true;
            headerCheckBox.Checked = global::ToolStripCustomizer.Properties.Settings.Default.IncludeHeader;
            headerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            headerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ToolStripCustomizer.Properties.Settings.Default, "IncludeHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            headerCheckBox.Location = new System.Drawing.Point(3, 51);
            headerCheckBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            headerCheckBox.Name = "headerCheckBox";
            headerCheckBox.Size = new System.Drawing.Size(196, 19);
            headerCheckBox.TabIndex = 4;
            headerCheckBox.Text = "Print <auto-generated/> header";
            headerCheckBox.UseVisualStyleBackColor = true;
            // 
            // namespaceTextBox
            // 
            this.namespaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.namespaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ToolStripCustomizer.Properties.Settings.Default, "DefaultNamespace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.namespaceTextBox.Location = new System.Drawing.Point(3, 18);
            this.namespaceTextBox.Name = "namespaceTextBox";
            this.namespaceTextBox.Size = new System.Drawing.Size(244, 23);
            this.namespaceTextBox.TabIndex = 1;
            this.namespaceTextBox.Text = global::ToolStripCustomizer.Properties.Settings.Default.DefaultNamespace;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cancelButton.Location = new System.Drawing.Point(206, 8);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            okButton.Location = new System.Drawing.Point(125, 8);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(cancelButton);
            flowLayoutPanel1.Controls.Add(okButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(5, 313);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(284, 34);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // OptionsForm
            // 
            this.AcceptButton = okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = cancelButton;
            this.ClientSize = new System.Drawing.Size(294, 352);
            this.Controls.Add(tabControl1);
            this.Controls.Add(flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsFormFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsFormFormClosed);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namespaceTextBox;



    }
}