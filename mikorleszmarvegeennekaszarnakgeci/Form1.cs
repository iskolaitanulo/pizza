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

namespace mikorleszmarvegeennekaszarnakgeci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 21; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ar = 2000;
            {
                if (radioButton1.Checked)
                {
                    ar = (ar - 300);
                }

                if (radioButton3.Checked)
                {
                    ar = (ar + 300);      // 1.sor
                }
                if (radioButton4.Checked)
                {
                    ar = (ar + 200);      // 1.sor
                }


                int darab = Convert.ToInt32(comboBox1.Text);

                int ujar = ar  * darab;
                listBox1.Items.Add("Ön ennyi pizzat rendelt: " + darab + " és ez ennyibe kerül: " + ujar + "ft");   // 2.sor
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton6.Checked = false;
            textBox1.Text = string.Empty;   
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = 0;   
            listBox1.Items.Clear();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Egyszerű szöveg(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
                StreamWriter iras = new StreamWriter(fs);
                
                
                
                

                iras.WriteLine("Neve: " + textBox1.Text + "; Lakcíme: "
                    + textBox2.Text + "; Telefonszáma: "
                    + textBox3.Text + "; Pizza darabja: "+comboBox1.Text+
                    "\n" +
                    listBox1.Items.ToString() + "\n---------------------------");

                iras.Flush(); fs.Flush();
                iras.Close(); fs.Close();
            }
        }
    }
}
