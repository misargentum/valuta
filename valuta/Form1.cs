using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dollar = 68;
        int Euro = 67;
        int Frank = 60;
        int x;
        int z;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                x = Convert.ToInt32(textBox3.Text);
                z = Dollar * x;
                textBox1.Text = z.ToString();
            }


            else if (this.radioButton2.Checked)
            {
                x = Convert.ToInt32(textBox3.Text);
                z = Euro * x;
                textBox1.Text = z.ToString();

            }

            else if (this.radioButton3.Checked)
            {
                x = Convert.ToInt32(textBox3.Text);
                z = Frank * x;
                textBox1.Text = z.ToString();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
