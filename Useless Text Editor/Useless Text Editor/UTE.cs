using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Useless_Text_Editor
{
    public partial class UTE : Form
    {
        RichTextBox rtb;
        public UTE()
        {
            InitializeComponent();

            TabPage tp = new TabPage("Untitled");
            RichTextBox rtb = new RichTextBox(); 
            rtb.Dock = DockStyle.Fill;
            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }

        private RichTextBox GetRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabControl1.SelectedTab;
            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }
            return rtb;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Untitled");
            RichTextBox rtb = new RichTextBox(); 
            rtb.Dock = DockStyle.Fill;
            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string filename = openFileDialog1.FileName;
                    string readfiletext = File.ReadAllText(filename);
                    TabPage tp = new TabPage("New Document");
                    RichTextBox rtb = new RichTextBox();
                    rtb.Dock = DockStyle.Fill;
                    tp.Controls.Add(rtb);
                    tabControl1.TabPages.Add(tp);
                    rtb.Text = readfiletext;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "*.txt(textfile)|*.txt";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                rtb.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            if (tabControl1.SelectedTab == null)
            {
                Application.Exit();
            }
        }
    }
}
