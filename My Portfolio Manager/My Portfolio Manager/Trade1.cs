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
    public partial class Trade1 : Form
    {
        aaaContainer mc = new aaaContainer();
        public Trade1()
        {
            InitializeComponent();
            foreach (Instrument i in mc.InstrumentSet)
                Instrument.Items.Add(i.Ticker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrument t = (from p in mc.InstrumentSet
                            where p.Ticker == Instrument.Text
                            select p).First();



            mc.TradeSet.Add(new Trade()
            {
                Instrument = t,
                Isbuy = (Buy.Checked ? true : false),
                Price = Convert.ToDouble(Price.Text),
                Quantity = Convert.ToInt32(Quantity.Text),
                Timestamp = DateTime.Now
            });
            mc.SaveChanges();
            MessageBox.Show("New trade added successfully!");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
