namespace My_Portfolio_Manager
{
    partial class Trade1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Instrument = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Sell = new System.Windows.Forms.RadioButton();
            this.Buy = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 568);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 59);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(288, 483);
            this.Price.Margin = new System.Windows.Forms.Padding(8);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(260, 38);
            this.Price.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 483);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price:";
            // 
            // Instrument
            // 
            this.Instrument.DisplayMember = "Ticker";
            this.Instrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Instrument.FormattingEnabled = true;
            this.Instrument.Location = new System.Drawing.Point(304, 369);
            this.Instrument.Margin = new System.Windows.Forms.Padding(8);
            this.Instrument.Name = "Instrument";
            this.Instrument.Size = new System.Drawing.Size(316, 39);
            this.Instrument.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Instrument:";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(288, 261);
            this.Quantity.Margin = new System.Windows.Forms.Padding(8);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(260, 38);
            this.Quantity.TabIndex = 15;
            // 
            // Sell
            // 
            this.Sell.AutoSize = true;
            this.Sell.Location = new System.Drawing.Point(595, 80);
            this.Sell.Margin = new System.Windows.Forms.Padding(8);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(101, 36);
            this.Sell.TabIndex = 14;
            this.Sell.TabStop = true;
            this.Sell.Text = "Sell";
            this.Sell.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            this.Buy.AutoSize = true;
            this.Buy.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Buy.Location = new System.Drawing.Point(325, 80);
            this.Buy.Margin = new System.Windows.Forms.Padding(8);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(101, 36);
            this.Buy.TabIndex = 13;
            this.Buy.TabStop = true;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Direction:";
            // 
            // Trade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 863);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Instrument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Trade1";
            this.Text = "Trade1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Instrument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.RadioButton Sell;
        private System.Windows.Forms.RadioButton Buy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}