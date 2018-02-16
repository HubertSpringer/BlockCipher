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

namespace Szyfrator
{
    public partial class Form1 : Form
    {
        Nihilist nihilist ;
        Options  options;
        public Form1()
        {
            InitializeComponent();
            nihilist = new Nihilist();
            options = new Options();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string load_File()
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            byte[] buffer = new byte[myStream.Length + 10];
                            myStream.Read(buffer, 0, (int)myStream.Length);

                            return System.Text.Encoding.Default.GetString(buffer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            return null;
        }

        private void save_File(String message)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                    File.WriteAllText(saveFileDialog.FileName,message);
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_box_keyword.Text = "WORDS";
            text_box_message.Text = "an example of transposition";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            //nie uzywane
        }

        private void keywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
        text_box_keyword.Text = load_File();  
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
        text_box_message.Text = load_File();
        }

        private void cryptogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
        text_box_cryptogram.Text = load_File();
        }

        private void keywordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save_File(text_box_keyword.Text);
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save_File(text_box_message.Text);
        }

        private void button_encrypt_Click_1(object sender, EventArgs e)
        {
            options_update();
            text_box_cryptogram.Text = nihilist.encrypt(text_box_keyword.Text, text_box_message.Text,options);

            label_cryptogram_2.Text = text_box_cryptogram.Text.Length.ToString();
        }

        private void button_decrypt_Click_1(object sender, EventArgs e)
        {
            options_update();
            text_box_message.Text = nihilist.decrypt(text_box_keyword.Text, text_box_cryptogram.Text, options);
            label_message_2.Text = text_box_message.Text.Length.ToString();
        }

        private void cryptogramToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            save_File(text_box_cryptogram.Text);
        }

        private void text_box_keyword_TextChanged(object sender, EventArgs e)
        {
            label_keyword_2.Text = text_box_keyword.Text.Length.ToString(); 
        }

        private void text_box_message_TextChanged(object sender, EventArgs e)
        {
            label_message_2.Text = text_box_message.Text.Length.ToString();
        }

        private void options_update()
        {
            options.update(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked,text_box_cryptogram_replace.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
