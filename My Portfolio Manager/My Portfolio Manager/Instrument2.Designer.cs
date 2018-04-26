namespace My_Portfolio_Manager
{
    partial class Instrument2
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
            this.Underlying = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Barrier = new System.Windows.Forms.TextBox();
            this.DownandOut = new System.Windows.Forms.RadioButton();
            this.DownandIn = new System.Windows.Forms.RadioButton();
            this.UpandOut = new System.Windows.Forms.RadioButton();
            this.UpandIn = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.InstType = new System.Windows.Forms.ComboBox();
            this.Put = new System.Windows.Forms.RadioButton();
            this.Call = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Tenor = new System.Windows.Forms.TextBox();
            this.Strike = new System.Windows.Forms.TextBox();
            this.Exchange = new System.Windows.Forms.TextBox();
            this.Ticker = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Rebate = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Underlying
            // 
            this.Underlying.DisplayMember = "Ticker";
            this.Underlying.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Underlying.FormattingEnabled = true;
            this.Underlying.Location = new System.Drawing.Point(304, 281);
            this.Underlying.Margin = new System.Windows.Forms.Padding(8);
            this.Underlying.Name = "Underlying";
            this.Underlying.Size = new System.Drawing.Size(316, 39);
            this.Underlying.TabIndex = 71;
            this.Underlying.SelectedIndexChanged += new System.EventHandler(this.Underlying_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.Barrier);
            this.groupBox4.Controls.Add(this.DownandOut);
            this.groupBox4.Controls.Add(this.DownandIn);
            this.groupBox4.Controls.Add(this.UpandOut);
            this.groupBox4.Controls.Add(this.UpandIn);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(858, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox4.Size = new System.Drawing.Size(368, 356);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Barrier Settings";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(21, 276);
            this.label23.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 32);
            this.label23.TabIndex = 5;
            this.label23.Text = "Barrier:";
            // 
            // Barrier
            // 
            this.Barrier.Location = new System.Drawing.Point(179, 269);
            this.Barrier.Margin = new System.Windows.Forms.Padding(8);
            this.Barrier.Name = "Barrier";
            this.Barrier.Size = new System.Drawing.Size(167, 38);
            this.Barrier.TabIndex = 4;
            // 
            // DownandOut
            // 
            this.DownandOut.AutoSize = true;
            this.DownandOut.BackColor = System.Drawing.Color.Transparent;
            this.DownandOut.Location = new System.Drawing.Point(21, 189);
            this.DownandOut.Margin = new System.Windows.Forms.Padding(8);
            this.DownandOut.Name = "DownandOut";
            this.DownandOut.Size = new System.Drawing.Size(232, 36);
            this.DownandOut.TabIndex = 3;
            this.DownandOut.Text = "Down and Out";
            this.DownandOut.UseVisualStyleBackColor = false;
            // 
            // DownandIn
            // 
            this.DownandIn.AutoSize = true;
            this.DownandIn.BackColor = System.Drawing.Color.Transparent;
            this.DownandIn.Location = new System.Drawing.Point(21, 142);
            this.DownandIn.Margin = new System.Windows.Forms.Padding(8);
            this.DownandIn.Name = "DownandIn";
            this.DownandIn.Size = new System.Drawing.Size(209, 36);
            this.DownandIn.TabIndex = 2;
            this.DownandIn.Text = "Down and In";
            this.DownandIn.UseVisualStyleBackColor = false;
            // 
            // UpandOut
            // 
            this.UpandOut.AutoSize = true;
            this.UpandOut.BackColor = System.Drawing.Color.Transparent;
            this.UpandOut.Location = new System.Drawing.Point(21, 90);
            this.UpandOut.Margin = new System.Windows.Forms.Padding(8);
            this.UpandOut.Name = "UpandOut";
            this.UpandOut.Size = new System.Drawing.Size(196, 36);
            this.UpandOut.TabIndex = 1;
            this.UpandOut.Text = "Up and Out";
            this.UpandOut.UseVisualStyleBackColor = false;
            // 
            // UpandIn
            // 
            this.UpandIn.AutoSize = true;
            this.UpandIn.BackColor = System.Drawing.Color.Transparent;
            this.UpandIn.Checked = true;
            this.UpandIn.Location = new System.Drawing.Point(21, 39);
            this.UpandIn.Margin = new System.Windows.Forms.Padding(8);
            this.UpandIn.Name = "UpandIn";
            this.UpandIn.Size = new System.Drawing.Size(173, 36);
            this.UpandIn.TabIndex = 0;
            this.UpandIn.TabStop = true;
            this.UpandIn.Text = "Up and In";
            this.UpandIn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1085, 832);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 59);
            this.button2.TabIndex = 69;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1085, 619);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 68;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstType
            // 
            this.InstType.DisplayMember = "TypeName";
            this.InstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstType.FormattingEnabled = true;
            this.InstType.Location = new System.Drawing.Point(304, 852);
            this.InstType.Margin = new System.Windows.Forms.Padding(8);
            this.InstType.Name = "InstType";
            this.InstType.Size = new System.Drawing.Size(316, 39);
            this.InstType.TabIndex = 67;
            this.InstType.SelectedIndexChanged += new System.EventHandler(this.InstType_SelectedIndexChanged);
            // 
            // Put
            // 
            this.Put.AutoSize = true;
            this.Put.Location = new System.Drawing.Point(304, 734);
            this.Put.Margin = new System.Windows.Forms.Padding(8);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(95, 36);
            this.Put.TabIndex = 66;
            this.Put.TabStop = true;
            this.Put.Text = "Put";
            this.Put.UseVisualStyleBackColor = true;
            // 
            // Call
            // 
            this.Call.AutoSize = true;
            this.Call.Location = new System.Drawing.Point(304, 619);
            this.Call.Margin = new System.Windows.Forms.Padding(8);
            this.Call.Name = "Call";
            this.Call.Size = new System.Drawing.Size(102, 36);
            this.Call.TabIndex = 65;
            this.Call.TabStop = true;
            this.Call.Text = "Call";
            this.Call.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(542, 608);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(283, 36);
            this.radioButton1.TabIndex = 64;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Neither Call or Put";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Tenor
            // 
            this.Tenor.Location = new System.Drawing.Point(304, 481);
            this.Tenor.Margin = new System.Windows.Forms.Padding(8);
            this.Tenor.Name = "Tenor";
            this.Tenor.Size = new System.Drawing.Size(260, 38);
            this.Tenor.TabIndex = 63;
            // 
            // Strike
            // 
            this.Strike.Location = new System.Drawing.Point(304, 398);
            this.Strike.Margin = new System.Windows.Forms.Padding(8);
            this.Strike.Name = "Strike";
            this.Strike.Size = new System.Drawing.Size(260, 38);
            this.Strike.TabIndex = 62;
            // 
            // Exchange
            // 
            this.Exchange.Location = new System.Drawing.Point(304, 195);
            this.Exchange.Margin = new System.Windows.Forms.Padding(8);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(260, 38);
            this.Exchange.TabIndex = 61;
            // 
            // Ticker
            // 
            this.Ticker.Location = new System.Drawing.Point(304, 108);
            this.Ticker.Margin = new System.Windows.Forms.Padding(8);
            this.Ticker.Name = "Ticker";
            this.Ticker.Size = new System.Drawing.Size(260, 38);
            this.Ticker.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, -119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 38);
            this.textBox1.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 855);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 32);
            this.label8.TabIndex = 58;
            this.label8.Text = "Inst Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 608);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 32);
            this.label7.TabIndex = 57;
            this.label7.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tenor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 55;
            this.label5.Text = "Strike:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Underlying:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "Exchange:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, -134);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 55);
            this.label1.TabIndex = 51;
            this.label1.Text = "Company Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Rebate);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(858, 398);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox5.Size = new System.Drawing.Size(917, 132);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Digital Settings";
            // 
            // Rebate
            // 
            this.Rebate.Location = new System.Drawing.Point(227, 49);
            this.Rebate.Margin = new System.Windows.Forms.Padding(8);
            this.Rebate.Name = "Rebate";
            this.Rebate.Size = new System.Drawing.Size(300, 38);
            this.Rebate.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 57);
            this.label24.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 32);
            this.label24.TabIndex = 0;
            this.label24.Text = "Rebate:";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(304, 21);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(8);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(260, 38);
            this.CompanyName.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 38);
            this.label2.TabIndex = 75;
            this.label2.Text = "Ticker:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(60, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 38);
            this.label9.TabIndex = 76;
            this.label9.Text = "Company Name";
            // 
            // Instrument2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 1373);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Underlying);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstType);
            this.Controls.Add(this.Put);
            this.Controls.Add(this.Call);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Tenor);
            this.Controls.Add(this.Strike);
            this.Controls.Add(this.Exchange);
            this.Controls.Add(this.Ticker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Instrument2";
            this.Text = "Instrument2";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Underlying;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Barrier;
        private System.Windows.Forms.RadioButton DownandOut;
        private System.Windows.Forms.RadioButton DownandIn;
        private System.Windows.Forms.RadioButton UpandOut;
        private System.Windows.Forms.RadioButton UpandIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox InstType;
        private System.Windows.Forms.RadioButton Put;
        private System.Windows.Forms.RadioButton Call;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox Tenor;
        private System.Windows.Forms.TextBox Strike;
        private System.Windows.Forms.TextBox Exchange;
        private System.Windows.Forms.TextBox Ticker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Rebate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}