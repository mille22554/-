using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW02_3A713135
{
    public partial class Form1 : Form
    {
        int x = 0;
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "抽過的卡:";
            label2.Text = "作者:Moro";
            this.Text = "抽卡";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            a = a + x + ":\r\n";
            textBox1.Text = a;
        }
    }
}
