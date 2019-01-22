using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int boyut;
        private void button1_Click(object sender, EventArgs e)
        {
             Anaform form = new Anaform();
            this.Hide();
            form.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 5;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 6;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 7;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 8;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }
    }
}
