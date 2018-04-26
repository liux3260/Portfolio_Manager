using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Portfolio_Manager
{
    public partial class IntrestRate : Form
    {
        aaaContainer mc = new aaaContainer();
        public IntrestRate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc.InterstRateSet.Add(new InterstRate()
            {
                Tenor = Convert.ToDouble(textBox1.Text),
                Rate = Convert.ToDouble(textBox2.Text)
            });
            mc.SaveChanges();
            MessageBox.Show("Add new Interest Rate successfully!");
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
