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
    public partial class Instrument2 : Form
    {
        aaaContainer mc = new aaaContainer();
        public Instrument2()
        {
            InitializeComponent();
            foreach (InstType i in mc.InstTypeSet)
                InstType.Items.Add(i.TypeName);
            foreach (Instrument i in (from g in mc.InstrumentSet
                                      where g.InstType.TypeName.ToUpper() == "Stock"
                                      select g))
                Underlying.Items.Add(i.Ticker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstType t = (from p in mc.InstTypeSet
                          where p.TypeName == InstType.Text
                          select p).First();



            mc.InstrumentSet.Add(new Instrument()
            {
                CompanyName =( CompanyName.Text== string.Empty? null:CompanyName.Text),           
                Ticker =(Ticker.Text==string.Empty? null:Ticker.Text),              
                Exchange = (Exchange.Text==string.Empty? null:Exchange.Text),
                Underlying = (Underlying.Text == string.Empty ? null : Underlying.Text),
                Strike = (Strike.Text==string.Empty? 0.0:Convert.ToDouble(Strike.Text)),
                Tenor = (Tenor.Text == string.Empty ? 0.0 : Convert.ToDouble(Tenor.Text)),
                Barrier=(Barrier.Text==string.Empty? 0.0:Convert.ToDouble(Barrier.Text)),
                Rebate=(Rebate.Text==string.Empty?0.0:Convert.ToDouble(Rebate.Text)),
                BarrierType=(UpandIn.Checked?"Up and In":(UpandOut.Checked?"Up and Out":(DownandIn.Checked?"Down and In":(DownandOut.Checked?"Down and out":null)))),
                Iscall = (radioButton1.Checked?false:(Call.Checked?true:false)),
                InstTypeId = t.Id,
                InstType = t

            });
            mc.SaveChanges();
            MessageBox.Show("New instrument added successfully!");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstType.Text.ToUpper() == "Stock")
            {
                Underlying.Enabled = false;
                Strike.Enabled = false;
                Tenor.Enabled = false;
            }
            else
            {
                Underlying.Enabled = true;
                Strike.Enabled = true;
                Tenor.Enabled = true;
            }
            if (InstType.Text.ToUpper() == "Range")
            {
                radioButton1.Enabled = false;
                Call.Enabled = false;
                Put.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                Call.Enabled = true;
                Put.Enabled = true;
            }
            if (InstType.Text.ToUpper() == "Digital")
            {
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
            }
            if (InstType.Text.ToUpper() == "Barrier")
            {
                groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }
        }

        private void Underlying_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyName.Text = (from i in mc.InstrumentSet
                               where i.Ticker.ToUpper() == Underlying.Text
                               select i).First().CompanyName;
        }
    }
}
