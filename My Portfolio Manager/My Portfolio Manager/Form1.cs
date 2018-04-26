using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using _5092_1_HW;

namespace My_Portfolio_Manager
{
    public partial class Mainform : Form
    {
        aaaContainer mc = new aaaContainer();
       
        
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void instrumentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstrumentType newform = new InstrumentType();
            newform.ShowDialog();
        }

        private void instrumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instrument2 newform = new Instrument2();
            newform.ShowDialog();
        }

        private void tradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trade1 newform = new Trade1();
            newform.ShowDialog();
            refreshTrades();
        }

        private void interestRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntrestRate newform = new IntrestRate();
            newform.ShowDialog();
        }

        private void historicalPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricalPrice newform = new HistoricalPrice();
            newform.ShowDialog();
        }

        private void refreshTradesFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTrades();
        }
        private void refreshTrades()
        {
            listView2.Items.Clear();
            ListViewItem i;
           
            foreach (Trade t in mc.TradeSet)
            {
                i = new ListViewItem();
                i.Text = t.Id.ToString();
                i.SubItems.Add(t.Isbuy ? "BUY" : "SELL");
                i.SubItems.Add(t.Quantity.ToString());
                i.SubItems.Add(t.Instrument.Ticker);
                i.SubItems.Add(t.Instrument.InstType.TypeName);
                i.SubItems.Add(t.Price.ToString());
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                listView2.Items.Add(i);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pricingBookUsingSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceusingsim();
        }
        private void priceusingsim()
        { 
            foreach (ListViewItem i in listView2.Items)
            {
                Trade tt = (from q in mc.TradeSet
                            where q.Id.ToString() == i.Text
                            select q).FirstOrDefault();
                _5092_1_HW.Form1 a = new _5092_1_HW.Form1();
                
                _5092_1_HW.Form1.k = Convert.ToDouble(tt.Instrument.Strike);
                _5092_1_HW.Form1.t = Convert.ToDouble(tt.Instrument.Tenor);
                _5092_1_HW.Form1.sigma = Convert.ToDouble(textBox1.Text);
                _5092_1_HW.Form1.M = 100;
                _5092_1_HW.Form1.simulation = 10000;
                _5092_1_HW.Form1.check1 = 1;
                _5092_1_HW.Form1.r = 0.05;
                _5092_1_HW.Form1.check1 = 1;
                _5092_1_HW.Form1.check2 = 0;
                _5092_1_HW.Form1.check3 = 1;
                switch (tt.Instrument.InstType.TypeName)
                {
                    case "European":
                        //var n = (from g in mc.InstrumentSet
                        //         where g.Ticker == tt.Instrument.Underlying
                        //         select g).First();

                        //_5092_1_HW.Form1.s = n.Price.Last().ClosingPrice;
                        _5092_1_HW.Form1.s = getunderlying(tt.Instrument);
                        _5092_1_HW.Form1.checkbarrier = 0.0;
                _5092_1_HW.Form1.checkrebate = 0.0;
                        _5092_1_HW.Form1.Type = "European";
                        
                        a.Cal();
                        if (tt.Instrument.Iscall == true)
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[0].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[0]*(double)tt.Quantity*(tt.Isbuy?1:-1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[2] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[6] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[8] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }
                        else
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[1].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[1] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[3] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[7] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[9] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }

                        i.SubItems[6].Text = (tt.Isbuy?((Convert.ToDouble(i.SubItems[5].Text)-tt.Price)*(double)tt.Quantity):((tt.Price- Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();
                        break;
                    case "Barrier":
                        _5092_1_HW.Form1.s = getunderlying(tt.Instrument);
                        _5092_1_HW.Form1.checkbarrier = Convert.ToDouble(tt.Instrument.Barrier);
                        _5092_1_HW.Form1.checkrebate = 0.0;
                        _5092_1_HW.Form1.Type = "Barrier";
                        if(tt.Instrument.BarrierType=="Up and In")
                        {
                            _5092_1_HW.Form1.upandin = 1;
                        }
                        else if(tt.Instrument.BarrierType == "Up and Out")
                        {
                            _5092_1_HW.Form1.upandout = 1;
                        }
                        else if(tt.Instrument.BarrierType == "Down and In")
                        {
                            _5092_1_HW.Form1.downandin = 1;
                        }
                        else if(tt.Instrument.BarrierType == "Down and Out")
                        {
                            _5092_1_HW.Form1.downandout = 1;
                        }
                        else { }

                        a.Cal();
                        if (tt.Instrument.Iscall == true)
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[0].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[0] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[2] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[6] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[8] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }
                        else
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[1].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[1] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[3] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[7] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[9] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }

                        i.SubItems[6].Text = (tt.Isbuy ? ((Convert.ToDouble(i.SubItems[5].Text) - tt.Price) * (double)tt.Quantity) : ((tt.Price - Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();
                        
                        break;
                    case "Range":
                        _5092_1_HW.Form1.s = getunderlying(tt.Instrument);
                        _5092_1_HW.Form1.checkbarrier = 0.0;
                        _5092_1_HW.Form1.checkrebate = 0.0;
                        _5092_1_HW.Form1.Type = "Range";

                        a.Cal();
                        if (tt.Instrument.Iscall == true)
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[0].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[0] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[2] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[6] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[8] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }
                        else
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[1].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[1] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[3] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[7] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[9] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }

                        i.SubItems[6].Text = (tt.Isbuy ? ((Convert.ToDouble(i.SubItems[5].Text) - tt.Price) * (double)tt.Quantity) : ((tt.Price - Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();


                        break;
                    case "Lookback":
                        _5092_1_HW.Form1.s = getunderlying(tt.Instrument);
                        _5092_1_HW.Form1.checkbarrier = 0.0;
                        _5092_1_HW.Form1.checkrebate = 0.0;
                        _5092_1_HW.Form1.Type = "Lookback";

                        a.Cal();
                        if (tt.Instrument.Iscall == true)
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[0].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[0] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[2] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[6] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[8] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }
                        else
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[1].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[1] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[3] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[7] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[9] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }

                        i.SubItems[6].Text = (tt.Isbuy ? ((Convert.ToDouble(i.SubItems[5].Text) - tt.Price) * (double)tt.Quantity) : ((tt.Price - Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();

                        break;
                    case "Aisan":
                        _5092_1_HW.Form1.s = getunderlying(tt.Instrument);
                        _5092_1_HW.Form1.checkbarrier = 0.0;
                        _5092_1_HW.Form1.checkrebate = 0.0;
                        _5092_1_HW.Form1.Type = "Asian";

                        a.Cal();
                        if (tt.Instrument.Iscall == true)
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[0].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[0] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[2] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[6] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[8] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }
                        else
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[1].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[1] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[3] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[7] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[9] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }

                        i.SubItems[6].Text = (tt.Isbuy ? ((Convert.ToDouble(i.SubItems[5].Text) - tt.Price) * (double)tt.Quantity) : ((tt.Price - Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();

                        break;
                    case "Digital":
                        _5092_1_HW.Form1.s = getunderlying(tt.Instrument);
                        _5092_1_HW.Form1.checkbarrier = 0.0;
                        _5092_1_HW.Form1.checkrebate = Convert.ToDouble(tt.Instrument.Rebate);
                        _5092_1_HW.Form1.Type = "Digital";

                        a.Cal();
                        if (tt.Instrument.Iscall == true)
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[0].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[0] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[2] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[6] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[8] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }
                        else
                        {
                            i.SubItems[5].Text = _5092_1_HW.Form1.P[1].ToString();
                            i.SubItems[7].Text = (_5092_1_HW.Form1.greeks[1] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[8].Text = (_5092_1_HW.Form1.greeks[3] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[9].Text = (_5092_1_HW.Form1.greeks[4] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[10].Text = (_5092_1_HW.Form1.greeks[7] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                            i.SubItems[11].Text = (_5092_1_HW.Form1.greeks[9] * (double)tt.Quantity * (tt.Isbuy ? 1 : -1)).ToString();
                        }

                        i.SubItems[6].Text = (tt.Isbuy ? ((Convert.ToDouble(i.SubItems[5].Text) - tt.Price) * (double)tt.Quantity) : ((tt.Price - Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();

                        break;
                    case "Stock":

                        var q = (from g in mc.PriceSet
                                 where g.InstrumentId == tt.Instrument.Id
                                 orderby g.Date descending
                                 select g).FirstOrDefault();
                        i.SubItems[5].Text = (q==null? 0 :q.ClosingPrice).ToString();
                        i.SubItems[6].Text = (tt.Isbuy ? ((Convert.ToDouble(i.SubItems[5].Text) - tt.Price) * (double)tt.Quantity) : ((tt.Price - Convert.ToDouble(i.SubItems[5].Text)) * (double)tt.Quantity)).ToString();
                        i.SubItems[7].Text = (tt.Isbuy ? tt.Quantity.ToString() : (tt.Quantity * -1).ToString());
                        break;


                }
            
            }
        }

        private double getunderlying(Instrument i)
        {
            if(i.InstType.TypeName.ToUpper()=="Stock")
            {
                var q = (from g in mc.PriceSet
                         where g.InstrumentId == i.Id
                         orderby g.Date descending
                         select g).FirstOrDefault();
                return (q == null ? 0.0 : q.ClosingPrice);
            }
            var n = (from g in mc.InstrumentSet
                     where g.Ticker == i.Underlying
                     select g).FirstOrDefault();

            var k = (from g in mc.PriceSet
                     where g.InstrumentId == n.Id
                     orderby g.Date descending
                     select g);

            return (n == null ? 0.0 : n.Price.FirstOrDefault().ClosingPrice);
                  
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem i = new ListViewItem();
            int t = listView2.SelectedItems.Count;
            int[] looping = new int[t];
            for (int k = 0; k < t; k++)
            {
                looping[k] = listView2.SelectedIndices[k];
            }
            double a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0;
            foreach (int k in looping)
            {
                a1 = a1 + Convert.ToDouble(listView2.Items[k].SubItems[6].Text);
                a2 = a2 + Convert.ToDouble(listView2.Items[k].SubItems[7].Text);
                a3 = a3 + Convert.ToDouble(listView2.Items[k].SubItems[8].Text);
                a4 = a4 + Convert.ToDouble(listView2.Items[k].SubItems[9].Text);
                a5 = a5 + Convert.ToDouble(listView2.Items[k].SubItems[10].Text);
                a6 = a6 + Convert.ToDouble(listView2.Items[k].SubItems[11].Text);
            }
            i.Text = a1.ToString();
            i.SubItems.Add(a2.ToString());
            i.SubItems.Add(a3.ToString());
            i.SubItems.Add(a4.ToString());
            i.SubItems.Add(a5.ToString());
            i.SubItems.Add(a6.ToString());

            listView1.Items.Add(i);
        }

        private void priceAnalasisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceAnalysis newform = new PriceAnalysis();
            newform.ShowDialog();
        }
    }
}
