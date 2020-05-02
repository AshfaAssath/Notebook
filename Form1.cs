using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Choosen_File = "";

            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:";
            op.Title = "Open a Text File";
            op.FileName = "";
            op.Filter = "Text Files|*.txt| Word Documents| *.doc";

            if(op.ShowDialog()==DialogResult.OK)
            {
                Choosen_File = op.FileName;
                richTextBox1.LoadFile(Choosen_File, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Saved_File = "";
            
            SaveFileDialog sv = new SaveFileDialog();
            sv.InitialDirectory = "C:";
            sv.Title = "Save a Text File";
            sv.FileName = "";

            sv.Filter = "Text Files|*.txt |All Files|*.*";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                Saved_File = sv.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pr = new PrintDialog();
            pr.ShowDialog();
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            richTextBox1.ForeColor = cd.Color;
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            richTextBox1.Font = fd.Font;
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Label l = new Label();
            l.Text = "Notepad for Assignment";
            l.Font = new Font("Arial", 20);
            l.Dock = DockStyle.Fill;
            f.Controls.Add(l);
            f.Show();
        }
    }
}
