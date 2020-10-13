namespace Phonlathorn.org_Browser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.homeRibbonTab = new System.Windows.Forms.RibbonTab();
            this.controlRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.backRibbonButton = new System.Windows.Forms.RibbonButton();
            this.forwardRibbonButton = new System.Windows.Forms.RibbonButton();
            this.refreshRibbonButton = new System.Windows.Forms.RibbonButton();
            this.stopRibbonButton = new System.Windows.Forms.RibbonButton();
            this.googleRibbonButton = new System.Windows.Forms.RibbonButton();
            this.bingRibbonButton = new System.Windows.Forms.RibbonButton();
            this.yahooRibbonButton = new System.Windows.Forms.RibbonButton();
            this.clipboardRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.copyRibbonButton = new System.Windows.Forms.RibbonButton();
            this.cutRibbonButton = new System.Windows.Forms.RibbonButton();
            this.pasteRibbonButton = new System.Windows.Forms.RibbonButton();
            this.toolRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Verdana", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010_Extended;
            this.ribbon1.OrbText = "File";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Verdana", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1370, 134);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.homeRibbonTab);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // homeRibbonTab
            // 
            this.homeRibbonTab.Name = "homeRibbonTab";
            this.homeRibbonTab.Panels.Add(this.controlRibbonPanel);
            this.homeRibbonTab.Panels.Add(this.clipboardRibbonPanel);
            this.homeRibbonTab.Panels.Add(this.toolRibbonPanel);
            this.homeRibbonTab.Text = "Home";
            // 
            // controlRibbonPanel
            // 
            this.controlRibbonPanel.Items.Add(this.backRibbonButton);
            this.controlRibbonPanel.Items.Add(this.forwardRibbonButton);
            this.controlRibbonPanel.Items.Add(this.refreshRibbonButton);
            this.controlRibbonPanel.Items.Add(this.stopRibbonButton);
            this.controlRibbonPanel.Items.Add(this.googleRibbonButton);
            this.controlRibbonPanel.Items.Add(this.bingRibbonButton);
            this.controlRibbonPanel.Items.Add(this.yahooRibbonButton);
            this.controlRibbonPanel.Name = "controlRibbonPanel";
            this.controlRibbonPanel.Text = "Control";
            // 
            // backRibbonButton
            // 
            this.backRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("backRibbonButton.Image")));
            this.backRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("backRibbonButton.LargeImage")));
            this.backRibbonButton.Name = "backRibbonButton";
            this.backRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("backRibbonButton.SmallImage")));
            this.backRibbonButton.Text = "Back";
            this.backRibbonButton.Click += new System.EventHandler(this.backRibbonButton_Click);
            // 
            // forwardRibbonButton
            // 
            this.forwardRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardRibbonButton.Image")));
            this.forwardRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("forwardRibbonButton.LargeImage")));
            this.forwardRibbonButton.Name = "forwardRibbonButton";
            this.forwardRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("forwardRibbonButton.SmallImage")));
            this.forwardRibbonButton.Text = "Forward";
            this.forwardRibbonButton.Click += new System.EventHandler(this.forwardRibbonButton_Click);
            // 
            // refreshRibbonButton
            // 
            this.refreshRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshRibbonButton.Image")));
            this.refreshRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshRibbonButton.LargeImage")));
            this.refreshRibbonButton.Name = "refreshRibbonButton";
            this.refreshRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("refreshRibbonButton.SmallImage")));
            this.refreshRibbonButton.Text = "Refresh";
            this.refreshRibbonButton.Click += new System.EventHandler(this.refreshRibbonButton_Click);
            // 
            // stopRibbonButton
            // 
            this.stopRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("stopRibbonButton.Image")));
            this.stopRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("stopRibbonButton.LargeImage")));
            this.stopRibbonButton.Name = "stopRibbonButton";
            this.stopRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("stopRibbonButton.SmallImage")));
            this.stopRibbonButton.Text = "Stop";
            this.stopRibbonButton.Click += new System.EventHandler(this.stopRibbonButton_Click);
            // 
            // googleRibbonButton
            // 
            this.googleRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("googleRibbonButton.Image")));
            this.googleRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("googleRibbonButton.LargeImage")));
            this.googleRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.googleRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.googleRibbonButton.Name = "googleRibbonButton";
            this.googleRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("googleRibbonButton.SmallImage")));
            this.googleRibbonButton.Text = "Google";
            this.googleRibbonButton.Click += new System.EventHandler(this.googleRibbonButton_Click);
            // 
            // bingRibbonButton
            // 
            this.bingRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("bingRibbonButton.Image")));
            this.bingRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("bingRibbonButton.LargeImage")));
            this.bingRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.bingRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.bingRibbonButton.Name = "bingRibbonButton";
            this.bingRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("bingRibbonButton.SmallImage")));
            this.bingRibbonButton.Text = "Bing";
            this.bingRibbonButton.Click += new System.EventHandler(this.bingRibbonButton_Click);
            // 
            // yahooRibbonButton
            // 
            this.yahooRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("yahooRibbonButton.Image")));
            this.yahooRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("yahooRibbonButton.LargeImage")));
            this.yahooRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.yahooRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.yahooRibbonButton.Name = "yahooRibbonButton";
            this.yahooRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("yahooRibbonButton.SmallImage")));
            this.yahooRibbonButton.Text = "Yahoo!";
            this.yahooRibbonButton.Click += new System.EventHandler(this.yahooRibbonButton_Click);
            // 
            // clipboardRibbonPanel
            // 
            this.clipboardRibbonPanel.Items.Add(this.copyRibbonButton);
            this.clipboardRibbonPanel.Items.Add(this.cutRibbonButton);
            this.clipboardRibbonPanel.Items.Add(this.pasteRibbonButton);
            this.clipboardRibbonPanel.Name = "clipboardRibbonPanel";
            this.clipboardRibbonPanel.Text = "Clipboard (WIP)";
            // 
            // copyRibbonButton
            // 
            this.copyRibbonButton.Enabled = false;
            this.copyRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("copyRibbonButton.Image")));
            this.copyRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("copyRibbonButton.LargeImage")));
            this.copyRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.copyRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.copyRibbonButton.Name = "copyRibbonButton";
            this.copyRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("copyRibbonButton.SmallImage")));
            this.copyRibbonButton.Text = "Copy";
            // 
            // cutRibbonButton
            // 
            this.cutRibbonButton.Enabled = false;
            this.cutRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("cutRibbonButton.Image")));
            this.cutRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("cutRibbonButton.LargeImage")));
            this.cutRibbonButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.cutRibbonButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.cutRibbonButton.Name = "cutRibbonButton";
            this.cutRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("cutRibbonButton.SmallImage")));
            this.cutRibbonButton.Text = "Cut";
            // 
            // pasteRibbonButton
            // 
            this.pasteRibbonButton.Enabled = false;
            this.pasteRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteRibbonButton.Image")));
            this.pasteRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("pasteRibbonButton.LargeImage")));
            this.pasteRibbonButton.Name = "pasteRibbonButton";
            this.pasteRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("pasteRibbonButton.SmallImage")));
            this.pasteRibbonButton.Text = "Paste";
            // 
            // toolRibbonPanel
            // 
            this.toolRibbonPanel.Name = "toolRibbonPanel";
            this.toolRibbonPanel.Text = "Tools";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.818182F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.goButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 491);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1364, 29);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1264, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // goButton
            // 
            this.goButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goButton.Location = new System.Drawing.Point(1273, 3);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(88, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1364, 482);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://example.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.webBrowser1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.40206F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.597938F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1370, 523);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab homeRibbonTab;
        private System.Windows.Forms.RibbonPanel controlRibbonPanel;
        private System.Windows.Forms.RibbonButton backRibbonButton;
        private System.Windows.Forms.RibbonButton forwardRibbonButton;
        private System.Windows.Forms.RibbonButton refreshRibbonButton;
        private System.Windows.Forms.RibbonButton stopRibbonButton;
        private System.Windows.Forms.RibbonPanel clipboardRibbonPanel;
        private System.Windows.Forms.RibbonButton copyRibbonButton;
        private System.Windows.Forms.RibbonButton cutRibbonButton;
        private System.Windows.Forms.RibbonButton googleRibbonButton;
        private System.Windows.Forms.RibbonButton bingRibbonButton;
        private System.Windows.Forms.RibbonButton yahooRibbonButton;
        private System.Windows.Forms.RibbonButton pasteRibbonButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RibbonPanel toolRibbonPanel;
    }
}

