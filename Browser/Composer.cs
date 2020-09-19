using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBrowser
{
    public partial class Composer : Form
    {

        public Composer()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = richTextBox1.Text;
        }

        private void open_mnustripitem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Filter = "HTML files|*.html|HTM files|*.htm|TXT files|*.txt|All files|*.*";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(theDialog.FileName.ToString());
                richTextBox1.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Filter = "HTML files|*.html|HTM files|*.htm|TXT files|*.txt|All files|*.*";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(theDialog.FileName.ToString());
                write.WriteLine(richTextBox1.Text);
                write.Close();
            }
        }

        private void Composer_Load(object sender, EventArgs e)
        {

        }
    }
}
