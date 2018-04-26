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
    public partial class PriceAnalysis : Form
    {
        aaaContainer mc = new aaaContainer();
        public PriceAnalysis()
        {
            InitializeComponent();
            foreach (Instrument i in mc.InstrumentSet)
                comboBox1.Items.Add(i.Ticker);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //var q = (from i in mc.PriceSet
            //         where i.Instrument.Ticker.ToUpper() == comboBox1.Text
            //         select i);
            //ListViewItem j;
            //foreach(Price p in q)
            //{
            //    j = new ListViewItem();
            //    j.SubItems.Add(p.Date.ToShortDateString());
            //    j.SubItems.Add(p.ClosingPrice.ToString());
            //    listView1.Items.Add(j);
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Instrument t = (from p in mc.InstrumentSet
                            where p.Ticker == comboBox1.Text
                            select p).First();

            mc.PriceSet.Add(new Price()
            {
                ClosingPrice = Convert.ToDouble(textBox1.Text),
                Date = DateTime.Now,
                InstrumentId = t.Id
            });
            mc.SaveChanges();
            MessageBox.Show("New Closing Price added successfully!");
            this.Dispose();
        }
    }
}
