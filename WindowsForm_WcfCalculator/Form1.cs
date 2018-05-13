using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_WcfCalculator
{
    public partial class Form1 : Form
    {
        ReferenciaWeb.Service1Client svc;


        public Form1()
        {
            InitializeComponent();

            svc = new ReferenciaWeb.Service1Client("Http");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(svc.Sum(4, 2).ToString());
        }

        private void bt_Sum_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = svc.Sum
                (Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text)).ToString();
        }

        private void bt_Substract_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = svc.Substract
                (Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text)).ToString();
        }

        private void bt_Multiply_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = svc.Multiply
                (Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text)).ToString();
        }

        private void bt_Divide_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = svc.Divide
                (Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text)).ToString();
        }
    }
}
