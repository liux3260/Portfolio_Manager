namespace My_Portfolio_Manager
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTradesFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricingBookUsingSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceAnalasisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2189, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.refreshTradesFromDatabaseToolStripMenuItem,
            this.pricingBookUsingSimulationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(78, 48);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentTypeToolStripMenuItem,
            this.instrumentToolStripMenuItem,
            this.tradeToolStripMenuItem,
            this.interestRateToolStripMenuItem,
            this.historicalPriceToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(554, 46);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // instrumentTypeToolStripMenuItem
            // 
            this.instrumentTypeToolStripMenuItem.Name = "instrumentTypeToolStripMenuItem";
            this.instrumentTypeToolStripMenuItem.Size = new System.Drawing.Size(358, 46);
            this.instrumentTypeToolStripMenuItem.Text = "Instrument type";
            this.instrumentTypeToolStripMenuItem.Click += new System.EventHandler(this.instrumentTypeToolStripMenuItem_Click);
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            this.instrumentToolStripMenuItem.Size = new System.Drawing.Size(358, 46);
            this.instrumentToolStripMenuItem.Text = "Instrument";
            this.instrumentToolStripMenuItem.Click += new System.EventHandler(this.instrumentToolStripMenuItem_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(358, 46);
            this.tradeToolStripMenuItem.Text = "Trade";
            this.tradeToolStripMenuItem.Click += new System.EventHandler(this.tradeToolStripMenuItem_Click);
            // 
            // interestRateToolStripMenuItem
            // 
            this.interestRateToolStripMenuItem.Name = "interestRateToolStripMenuItem";
            this.interestRateToolStripMenuItem.Size = new System.Drawing.Size(358, 46);
            this.interestRateToolStripMenuItem.Text = "Interest rate";
            this.interestRateToolStripMenuItem.Click += new System.EventHandler(this.interestRateToolStripMenuItem_Click);
            // 
            // historicalPriceToolStripMenuItem
            // 
            this.historicalPriceToolStripMenuItem.Name = "historicalPriceToolStripMenuItem";
            this.historicalPriceToolStripMenuItem.Size = new System.Drawing.Size(358, 46);
            this.historicalPriceToolStripMenuItem.Text = "Historical Price";
            this.historicalPriceToolStripMenuItem.Click += new System.EventHandler(this.historicalPriceToolStripMenuItem_Click);
            // 
            // refreshTradesFromDatabaseToolStripMenuItem
            // 
            this.refreshTradesFromDatabaseToolStripMenuItem.Name = "refreshTradesFromDatabaseToolStripMenuItem";
            this.refreshTradesFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(554, 46);
            this.refreshTradesFromDatabaseToolStripMenuItem.Text = "&Refresh trades from database";
            this.refreshTradesFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.refreshTradesFromDatabaseToolStripMenuItem_Click);
            // 
            // pricingBookUsingSimulationToolStripMenuItem
            // 
            this.pricingBookUsingSimulationToolStripMenuItem.Name = "pricingBookUsingSimulationToolStripMenuItem";
            this.pricingBookUsingSimulationToolStripMenuItem.Size = new System.Drawing.Size(554, 46);
            this.pricingBookUsingSimulationToolStripMenuItem.Text = "Pricing book using simulation";
            this.pricingBookUsingSimulationToolStripMenuItem.Click += new System.EventHandler(this.pricingBookUsingSimulationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(554, 46);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceAnalasisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(145, 48);
            this.analysisToolStripMenuItem.Text = "&Analysis";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(130, 48);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0.5";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pricing volatility：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "All Trades";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(80, 232);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(2000, 324);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(80, 626);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(2000, 310);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Total P&L";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total Delta";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Gamma";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Vega";
            this.columnHeader4.Width = 206;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Theta";
            this.columnHeader5.Width = 199;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Rho";
            this.columnHeader6.Width = 203;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Direction";
            this.columnHeader8.Width = 177;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quantity";
            this.columnHeader9.Width = 174;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Instrument";
            this.columnHeader10.Width = 176;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Inst Type";
            this.columnHeader11.Width = 172;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Market Price";
            this.columnHeader12.Width = 189;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "P&L";
            this.columnHeader13.Width = 141;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Delta";
            this.columnHeader14.Width = 131;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Gamma";
            this.columnHeader15.Width = 168;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Vega";
            this.columnHeader16.Width = 136;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Theta";
            this.columnHeader17.Width = 146;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Rho";
            this.columnHeader18.Width = 177;
            // 
            // priceAnalasisToolStripMenuItem
            // 
            this.priceAnalasisToolStripMenuItem.Name = "priceAnalasisToolStripMenuItem";
            this.priceAnalasisToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.priceAnalasisToolStripMenuItem.Text = "Price Analasis";
            this.priceAnalasisToolStripMenuItem.Click += new System.EventHandler(this.priceAnalasisToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2189, 976);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "My Portfolio Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTradesFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricingBookUsingSimulationToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem historicalPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ToolStripMenuItem priceAnalasisToolStripMenuItem;
    }
}

