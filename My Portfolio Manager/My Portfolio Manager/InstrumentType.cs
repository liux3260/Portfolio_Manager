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
    public partial class InstrumentType : Form
    {
        aaaContainer mc = new aaaContainer();
        public InstrumentType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mc.InstTypeSet.Add(new InstType()
            {
                TypeName = Convert.ToString(TypeName.Text)
            });
            mc.SaveChanges();
            MessageBox.Show("Add new instrument type successfully!");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
