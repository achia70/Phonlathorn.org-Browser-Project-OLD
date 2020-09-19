using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {

                webBrowser1.GoBack();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {

                webBrowser1.GoForward();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string WebPage = textBox1.Text.Trim();
            webBrowser1.Navigate("http://" + textBox1.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ourWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit_mnustripitem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void undo_mnustripitem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {

                textBox1.Undo();
                textBox1.ClearUndo();

            }
        }

        private void cut_mnustripitem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {

                textBox1.Cut();

            }
        }

        private void copy_mnustripitem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {

                textBox1.Copy();

            }
        }

        private void paste_mnustripitem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                textBox1.Paste();
                Clipboard.Clear();

            }
        }

        private void newwindow_mnustripitem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void open_mnustripitem_Click(object sender, EventArgs e)
        {

        }

        private void openhtmlfile_mnustripsubitem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open HTML File";
            theDialog.Filter = "HTML files|*.html";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(theDialog.FileName.ToString());
            }
        }

        private void file_mnustrip_Click(object sender, EventArgs e)
        {

        }

        private void openhtmfile_mnustripsubitem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open HTM File";
            theDialog.Filter = "HTM files|*.htm";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(theDialog.FileName.ToString());
            }
        }

        private void about_mnustripitem_Click(object sender, EventArgs e)
        {
            RunBrowser.AboutBox1 aboutBox = new RunBrowser.AboutBox1();
            aboutBox.ShowDialog();
        }

        private void home_mnustripitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com");
        }

        private void back_mnustripitem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {

                webBrowser1.GoBack();
            }
        }

        private void forward_mnustripitem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {

                webBrowser1.GoForward();
            }
        }

        private void refresh_mnustripitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stop_mnustripitem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void go_menustripitem_Click(object sender, EventArgs e)
        {
            string WebPage = textBox1.Text.Trim();
            webBrowser1.Navigate("http://"+textBox1.Text);
        }

        MyUserSettings mus;

        private void Form1_Load(object sender, EventArgs e)
        {
            mus = new MyUserSettings();
            mus.BackgroundColor = Color.Azure;
            this.DataBindings.Add(new Binding("BackColor", mus, "BackgroundColor"));
        }

        //Make sure to hook up this event handler in the constructor!
        //this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mus.Save();
        }
        public override System.Drawing.Size MaximumSize { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = "" + webBrowser1.Url;
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void composer_mnustripitem_Click(object sender, EventArgs e)
        {
            RunBrowser.Composer composer = new RunBrowser.Composer();
            composer.Show();
        }
    }
}
