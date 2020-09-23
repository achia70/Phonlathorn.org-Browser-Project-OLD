namespace RunBrowser
{
    partial class AboutBox1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showdescButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.label1.Location = new System.Drawing.Point(182, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Run Browser";
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(179, 204);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.ReadOnly = true;
            this.labelVersion.Size = new System.Drawing.Size(190, 22);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "--";
            this.labelVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelCopyright.Location = new System.Drawing.Point(179, 231);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.ReadOnly = true;
            this.labelCopyright.Size = new System.Drawing.Size(190, 22);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "--";
            this.labelCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelCompanyName.Location = new System.Drawing.Point(179, 258);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.ReadOnly = true;
            this.labelCompanyName.Size = new System.Drawing.Size(190, 22);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "--";
            this.labelCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 132);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // showdescButton
            // 
            this.showdescButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.showdescButton.Location = new System.Drawing.Point(179, 304);
            this.showdescButton.Name = "showdescButton";
            this.showdescButton.Size = new System.Drawing.Size(190, 23);
            this.showdescButton.TabIndex = 6;
            this.showdescButton.Text = "Show Desc";
            this.showdescButton.UseVisualStyleBackColor = true;
            this.showdescButton.Click += new System.EventHandler(this.showdescButton_Click);
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 339);
            this.Controls.Add(this.showdescButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutBox1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelVersion;
        private System.Windows.Forms.TextBox labelCopyright;
        private System.Windows.Forms.TextBox labelCompanyName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showdescButton;
    }
}