using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace タイピングソフト
{
    public partial class Form1 : Form
    {
        string[] array1 = new string[11] { "すじこ", "さーもん", "えび","いくら","いか" ,"かっぱまき","こうせん","まぐろ","うなぎ","たこ","なっとうまき"};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text)
            {
                Random r1 = new System.Random();
                label1.Text = array1[r1.Next(0, 11)];
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = ""; 
            }
        }
    }
}
