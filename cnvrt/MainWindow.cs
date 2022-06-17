using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace cnvrt
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string[] pascalCode;
        
        private void openFile(object sender, EventArgs e)
        {
            pascalBox.Text = "";
            openFileDialog1.Filter = "Файл Pascal (*.pas)|*.pas";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                string line;
                using (StreamReader readfile = File.OpenText(openFileDialog1.FileName))
                {
                    while (readfile.EndOfStream == false)
                    {
                        line = readfile.ReadLine().Replace("\t", "");
                        line = line.Replace("\n", "");
                        line = line.Replace("\r", "");
                        pascalBox.Text += line + "\r\n";
                    }
                }
            }
        }

        private void analizaCod(object sender, EventArgs e)
        {
            if (pascalBox.Text != "")
            {
                cBox.Text = "";
                rightLabel.Text = "Идентификатор";
                pascalCode = pascalBox.Text.Split('\r');
                for (int i = 0; i < pascalCode.Length; i++)
                {
                    pascalCode[i] = pascalCode[i].Replace("\n", "");
                    pascalCode[i] = pascalCode[i].Replace("\r", "");
                }

                cBox.Text = "";
                Lexical lex = new Lexical(pascalCode);
                lex.Analizare();
                Atom get = lex.UrmatorAtom();
                while (get != null)
                {
                    cBox.Text += get.indice + "\t-\t" + get.valoare + "\r\n";
                    get = lex.UrmatorAtom();
                }
            }
        }

        private void compileCod(object sender, EventArgs e)
        {
            if (pascalBox.Text != "")
            {
                cBox.Text = "";
                rightLabel.Text = "C";
                pascalCode = pascalBox.Text.Split('\r');
                for (int i = 0; i < pascalCode.Length; i++)
                {
                    pascalCode[i] = pascalCode[i].Replace("\n", "");
                    pascalCode[i] = pascalCode[i].Replace("\r", "");
                }
                Sintactic sintactic = new Sintactic(pascalCode, cBox);
                sintactic.BeginTranslation();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pascalCode = pascalBox.Text.Split('\r');
            for (int i = 0; i < pascalCode.Length; i++)
            {
                pascalCode[i] = pascalCode[i].Replace("\n", "");
                pascalCode[i] = pascalCode[i].Replace("\r", "");
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pascalBox.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pascalBox.SelectedText);
            pascalBox.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pascalBox.Text = pascalBox.Text.Insert(pascalBox.SelectionStart, Clipboard.GetText());
        }

        private void DragTo_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);                            
                if (files[0].ToString().Substring(files[0].ToString().Length - 3, 3) == "pas")
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                    e.Effect = DragDropEffects.None;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void pascalBox_DragDrop(object sender, DragEventArgs e)
        {
            pascalBox.Text = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string line;
                
                    using (StreamReader readfile = File.OpenText(s[0].ToString()))
                    {
                        while (readfile.EndOfStream == false)
                        {
                            line = readfile.ReadLine().Replace("\t", "");
                            line = line.Replace("\n", "");
                            line = line.Replace("\r", "");
                            pascalBox.Text += line + "\r\n";
                        }
                
                }
            }
        }

        private void copytoolStripMenu2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cBox.Text);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void cBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}