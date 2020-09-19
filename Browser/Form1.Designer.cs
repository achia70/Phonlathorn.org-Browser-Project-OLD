namespace Browser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_mnustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newwindow_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.openhtmlfile_mnustripsubitem = new System.Windows.Forms.ToolStripMenuItem();
            this.openhtmfile_mnustripsubitem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_mnustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.cut_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.web_mnustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.home_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.back_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.forward_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.go_menustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_mnustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.composer_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_mnustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.about_mnustripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(977, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(995, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(66, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "This browser is still in development, and they will have alot of bugs. Visit at s" +
    "ites.google.com/site/runbrowserhome/ for more imformation.";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 53);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1018, 499);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated_1);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(116, 581);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Forward";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(184, 581);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(246, 581);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_mnustrip,
            this.edit_mnustrip,
            this.web_mnustrip,
            this.tools_mnustrip,
            this.help_mnustrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_mnustrip
            // 
            this.file_mnustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newwindow_mnustripitem,
            this.open_mnustripitem,
            this.toolStripSeparator1,
            this.exit_mnustripitem});
            this.file_mnustrip.ForeColor = System.Drawing.Color.White;
            this.file_mnustrip.Name = "file_mnustrip";
            this.file_mnustrip.Size = new System.Drawing.Size(37, 20);
            this.file_mnustrip.Text = "&File";
            this.file_mnustrip.Click += new System.EventHandler(this.file_mnustrip_Click);
            // 
            // newwindow_mnustripitem
            // 
            this.newwindow_mnustripitem.Name = "newwindow_mnustripitem";
            this.newwindow_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newwindow_mnustripitem.Size = new System.Drawing.Size(188, 22);
            this.newwindow_mnustripitem.Text = "&New Window";
            this.newwindow_mnustripitem.Click += new System.EventHandler(this.newwindow_mnustripitem_Click);
            // 
            // open_mnustripitem
            // 
            this.open_mnustripitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openhtmlfile_mnustripsubitem,
            this.openhtmfile_mnustripsubitem});
            this.open_mnustripitem.Name = "open_mnustripitem";
            this.open_mnustripitem.Size = new System.Drawing.Size(188, 22);
            this.open_mnustripitem.Text = "Open";
            this.open_mnustripitem.Click += new System.EventHandler(this.open_mnustripitem_Click);
            // 
            // openhtmlfile_mnustripsubitem
            // 
            this.openhtmlfile_mnustripsubitem.Name = "openhtmlfile_mnustripsubitem";
            this.openhtmlfile_mnustripsubitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openhtmlfile_mnustripsubitem.Size = new System.Drawing.Size(227, 22);
            this.openhtmlfile_mnustripsubitem.Text = "&Open HTML file";
            this.openhtmlfile_mnustripsubitem.Click += new System.EventHandler(this.openhtmlfile_mnustripsubitem_Click);
            // 
            // openhtmfile_mnustripsubitem
            // 
            this.openhtmfile_mnustripsubitem.Name = "openhtmfile_mnustripsubitem";
            this.openhtmfile_mnustripsubitem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openhtmfile_mnustripsubitem.Size = new System.Drawing.Size(227, 22);
            this.openhtmfile_mnustripsubitem.Text = "O&pen HTM file";
            this.openhtmfile_mnustripsubitem.Click += new System.EventHandler(this.openhtmfile_mnustripsubitem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // exit_mnustripitem
            // 
            this.exit_mnustripitem.Name = "exit_mnustripitem";
            this.exit_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit_mnustripitem.Size = new System.Drawing.Size(188, 22);
            this.exit_mnustripitem.Text = "E&xit";
            this.exit_mnustripitem.Click += new System.EventHandler(this.exit_mnustripitem_Click);
            // 
            // edit_mnustrip
            // 
            this.edit_mnustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo_mnustripitem,
            this.cut_mnustripitem,
            this.copy_mnustripitem,
            this.paste_mnustripitem});
            this.edit_mnustrip.ForeColor = System.Drawing.Color.White;
            this.edit_mnustrip.Name = "edit_mnustrip";
            this.edit_mnustrip.Size = new System.Drawing.Size(39, 20);
            this.edit_mnustrip.Text = "&Edit";
            // 
            // undo_mnustripitem
            // 
            this.undo_mnustripitem.Name = "undo_mnustripitem";
            this.undo_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.undo_mnustripitem.Text = "&Undo";
            this.undo_mnustripitem.Click += new System.EventHandler(this.undo_mnustripitem_Click);
            // 
            // cut_mnustripitem
            // 
            this.cut_mnustripitem.Name = "cut_mnustripitem";
            this.cut_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.cut_mnustripitem.Text = "&Cut";
            this.cut_mnustripitem.Click += new System.EventHandler(this.cut_mnustripitem_Click);
            // 
            // copy_mnustripitem
            // 
            this.copy_mnustripitem.Name = "copy_mnustripitem";
            this.copy_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.copy_mnustripitem.Text = "Cop&y";
            this.copy_mnustripitem.Click += new System.EventHandler(this.copy_mnustripitem_Click);
            // 
            // paste_mnustripitem
            // 
            this.paste_mnustripitem.Name = "paste_mnustripitem";
            this.paste_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.paste_mnustripitem.Text = "&Paste";
            this.paste_mnustripitem.Click += new System.EventHandler(this.paste_mnustripitem_Click);
            // 
            // web_mnustrip
            // 
            this.web_mnustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_mnustripitem,
            this.back_mnustripitem,
            this.forward_mnustripitem,
            this.refresh_mnustripitem,
            this.stop_mnustripitem,
            this.go_menustripitem,
            this.informationToolStripMenuItem});
            this.web_mnustrip.ForeColor = System.Drawing.Color.White;
            this.web_mnustrip.Name = "web_mnustrip";
            this.web_mnustrip.Size = new System.Drawing.Size(43, 20);
            this.web_mnustrip.Text = "&Web";
            // 
            // home_mnustripitem
            // 
            this.home_mnustripitem.Name = "home_mnustripitem";
            this.home_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.home_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.home_mnustripitem.Text = "&Home";
            this.home_mnustripitem.Click += new System.EventHandler(this.home_mnustripitem_Click);
            // 
            // back_mnustripitem
            // 
            this.back_mnustripitem.Name = "back_mnustripitem";
            this.back_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.back_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.back_mnustripitem.Text = "&Back";
            this.back_mnustripitem.Click += new System.EventHandler(this.back_mnustripitem_Click);
            // 
            // forward_mnustripitem
            // 
            this.forward_mnustripitem.Name = "forward_mnustripitem";
            this.forward_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.forward_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.forward_mnustripitem.Text = "&Forward";
            this.forward_mnustripitem.Click += new System.EventHandler(this.forward_mnustripitem_Click);
            // 
            // refresh_mnustripitem
            // 
            this.refresh_mnustripitem.Name = "refresh_mnustripitem";
            this.refresh_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refresh_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.refresh_mnustripitem.Text = "&Refresh";
            this.refresh_mnustripitem.Click += new System.EventHandler(this.refresh_mnustripitem_Click);
            // 
            // stop_mnustripitem
            // 
            this.stop_mnustripitem.Name = "stop_mnustripitem";
            this.stop_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stop_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.stop_mnustripitem.Text = "&Stop";
            this.stop_mnustripitem.Click += new System.EventHandler(this.stop_mnustripitem_Click);
            // 
            // go_menustripitem
            // 
            this.go_menustripitem.Name = "go_menustripitem";
            this.go_menustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.go_menustripitem.Size = new System.Drawing.Size(180, 22);
            this.go_menustripitem.Text = "Go!";
            this.go_menustripitem.Click += new System.EventHandler(this.go_menustripitem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // tools_mnustrip
            // 
            this.tools_mnustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.composer_mnustripitem});
            this.tools_mnustrip.ForeColor = System.Drawing.Color.White;
            this.tools_mnustrip.Name = "tools_mnustrip";
            this.tools_mnustrip.Size = new System.Drawing.Size(47, 20);
            this.tools_mnustrip.Text = "&Tools";
            this.tools_mnustrip.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // composer_mnustripitem
            // 
            this.composer_mnustripitem.Name = "composer_mnustripitem";
            this.composer_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.composer_mnustripitem.Text = "Composer";
            this.composer_mnustripitem.Click += new System.EventHandler(this.composer_mnustripitem_Click);
            // 
            // help_mnustrip
            // 
            this.help_mnustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_mnustripitem,
            this.experimentFeaturesToolStripMenuItem});
            this.help_mnustrip.ForeColor = System.Drawing.Color.White;
            this.help_mnustrip.Name = "help_mnustrip";
            this.help_mnustrip.Size = new System.Drawing.Size(44, 20);
            this.help_mnustrip.Text = "&Help";
            // 
            // about_mnustripitem
            // 
            this.about_mnustripitem.Name = "about_mnustripitem";
            this.about_mnustripitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.about_mnustripitem.Size = new System.Drawing.Size(180, 22);
            this.about_mnustripitem.Text = "&About";
            this.about_mnustripitem.Click += new System.EventHandler(this.about_mnustripitem_Click);
            // 
            // experimentFeaturesToolStripMenuItem
            // 
            this.experimentFeaturesToolStripMenuItem.Name = "experimentFeaturesToolStripMenuItem";
            this.experimentFeaturesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.experimentFeaturesToolStripMenuItem.Text = "Experiment Features";
            this.experimentFeaturesToolStripMenuItem.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1042, 616);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Run Browser Pre-Release";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_mnustrip;
        private System.Windows.Forms.ToolStripMenuItem edit_mnustrip;
        private System.Windows.Forms.ToolStripMenuItem newwindow_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem open_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem openhtmlfile_mnustripsubitem;
        private System.Windows.Forms.ToolStripMenuItem openhtmfile_mnustripsubitem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem undo_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem cut_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem copy_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem paste_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem help_mnustrip;
        private System.Windows.Forms.ToolStripMenuItem about_mnustripitem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem web_mnustrip;
        private System.Windows.Forms.ToolStripMenuItem home_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem back_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem forward_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem refresh_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem stop_mnustripitem;
        private System.Windows.Forms.ToolStripMenuItem go_menustripitem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experimentFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tools_mnustrip;
        private System.Windows.Forms.ToolStripMenuItem composer_mnustripitem;
    }
}

