using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonlathorn.org_Browser
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
        }

        private void backRibbonButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipTitle = "Can't Go Back";
                notifyIcon1.BalloonTipText = "It might probably reached the limit or no previous document";
                notifyIcon1.ShowBalloonTip(30000);
            }
        }

        private void forwardRibbonButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipTitle = "Can't Go Forward";
                notifyIcon1.BalloonTipText = "It might probably reached the limit or no next document";
                notifyIcon1.ShowBalloonTip(30000);
            }
        }

        private void refreshRibbonButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stopRibbonButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void googleRibbonButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://search.google.com");
        }

        private void bingRibbonButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://search.bing.com");
        }

        private void yahooRibbonButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://search.yahoo.com");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string WebPage = textBox1.Text.Trim();
            _ = this.Text.Trim();
            webBrowser1.Navigate("http://" + textBox1.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = "" + webBrowser1.Url;
            this.Text = webBrowser1.DocumentTitle + " (" + webBrowser1.Url + ")" + " - Phonlathorn.org Browser";
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "Navigating..." + " - Phonlathorn.org Browser";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle + " (" + webBrowser1.Url + ")" + " - Phonlathorn.org Browser";
        }

        private void composerRibbonButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
