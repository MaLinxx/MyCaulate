using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.OP1.Text);
            var y = int.Parse(this.OP2.Text);
            if (y != 0)
            {
                var z = x / y;
                this.labelruselt.Text = z.ToString();
            }
            else
                this.labelruselt.Text = "0不能作为除数";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.OP1.Text);
            var y = int.Parse(this.OP2.Text);
            var z = x + y;
            this.labelruselt.Text = z.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.OP1.Text);
            var y = int.Parse(this.OP2.Text);
            var z = x - y;
            this.labelruselt.Text = z.ToString();
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.OP1.Text);
            var y = int.Parse(this.OP2.Text);
            var z = x * y;
            this.labelruselt.Text = z.ToString();
        }
    }
}
