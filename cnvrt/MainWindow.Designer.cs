namespace cnvrt
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.openfileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.analizareButton = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.cBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leftLabel = new System.Windows.Forms.Label();
            this.pascalBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfileButton
            // 
            this.openfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openfileButton.FlatAppearance.BorderSize = 0;
            this.openfileButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.openfileButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.openfileButton.Location = new System.Drawing.Point(16, 672);
            this.openfileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openfileButton.Name = "openfileButton";
            this.openfileButton.Size = new System.Drawing.Size(120, 31);
            this.openfileButton.TabIndex = 1;
            this.openfileButton.Text = "Открыть";
            this.toolTip1.SetToolTip(this.openfileButton, "Откройте файл Pascal.");
            this.openfileButton.Click += new System.EventHandler(this.openFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // analizareButton
            // 
            this.analizareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analizareButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.analizareButton.Location = new System.Drawing.Point(567, 672);
            this.analizareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analizareButton.Name = "analizareButton";
            this.analizareButton.Size = new System.Drawing.Size(120, 31);
            this.analizareButton.TabIndex = 2;
            this.analizareButton.Text = "Анализ";
            this.toolTip1.SetToolTip(this.analizareButton, "Анализ кода Pascal и генерация на основе лексического анализа.");
            this.analizareButton.Click += new System.EventHandler(this.analizaCod);
            // 
            // compileButton
            // 
            this.compileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compileButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.compileButton.Location = new System.Drawing.Point(980, 672);
            this.compileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(120, 31);
            this.compileButton.TabIndex = 3;
            this.compileButton.Text = "Компиляция";
            this.toolTip1.SetToolTip(this.compileButton, "Компиляция кода Pascal в код C.");
            this.compileButton.Click += new System.EventHandler(this.compileCod);
            // 
            // cBox
            // 
            this.cBox.AcceptsTab = true;
            this.cBox.AllowDrop = true;
            this.cBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cBox.ContextMenuStrip = this.contextMenuStrip2;
            this.cBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBox.Location = new System.Drawing.Point(567, 33);
            this.cBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox.Multiline = true;
            this.cBox.Name = "cBox";
            this.cBox.ReadOnly = true;
            this.cBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cBox.Size = new System.Drawing.Size(532, 630);
            this.cBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cBox, "Раздел С\r\nОперации: Скопировать полученный код.\r\n");
            this.cBox.TextChanged += new System.EventHandler(this.cBox_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(204, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 24);
            this.toolStripMenuItem1.Text = "Copy";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.copytoolStripMenu2_Click);
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.leftLabel.Location = new System.Drawing.Point(12, 9);
            this.leftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(47, 16);
            this.leftLabel.TabIndex = 6;
            this.leftLabel.Text = "Pascal";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pascalBox
            // 
            this.pascalBox.AcceptsTab = true;
            this.pascalBox.AllowDrop = true;
            this.pascalBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pascalBox.CausesValidation = false;
            this.pascalBox.ContextMenuStrip = this.contextMenuStrip1;
            this.pascalBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pascalBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pascalBox.Location = new System.Drawing.Point(16, 33);
            this.pascalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pascalBox.Multiline = true;
            this.pascalBox.Name = "pascalBox";
            this.pascalBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pascalBox.Size = new System.Drawing.Size(532, 630);
            this.pascalBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.pascalBox, "Раздел Pascal\r\nОперации: Вставка или редактирование кода");
            this.pascalBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pascalBox_DragDrop);
            this.pascalBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragTo_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 76);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // rightLabel
            // 
            this.rightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rightLabel.Location = new System.Drawing.Point(563, 9);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(17, 16);
            this.rightLabel.TabIndex = 8;
            this.rightLabel.Text = "C";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1119, 709);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.pascalBox);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.openfileButton);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.analizareButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cnvrt - pas -> c";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button analizareButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.TextBox pascalBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

