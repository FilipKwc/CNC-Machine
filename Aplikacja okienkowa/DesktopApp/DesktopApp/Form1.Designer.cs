namespace ServoKontroler
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.COM_PORT = new System.Windows.Forms.Label();
            this.BAUD_RATE = new System.Windows.Forms.Label();
            this.DATA_BITS = new System.Windows.Forms.Label();
            this.STOP_BITS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxParitybits = new System.Windows.Forms.ComboBox();
            this.PARITY_BITS = new System.Windows.Forms.Label();
            this.CboxStopbits = new System.Windows.Forms.ComboBox();
            this.CboxDatabits = new System.Windows.Forms.ComboBox();
            this.CboxBaudRate = new System.Windows.Forms.ComboBox();
            this.CboxCport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CLOSE = new System.Windows.Forms.Button();
            this.OPEN = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // COM_PORT
            // 
            this.COM_PORT.AutoSize = true;
            this.COM_PORT.Location = new System.Drawing.Point(11, 31);
            this.COM_PORT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.COM_PORT.Name = "COM_PORT";
            this.COM_PORT.Size = new System.Drawing.Size(82, 16);
            this.COM_PORT.TabIndex = 2;
            this.COM_PORT.Text = "COM_PORT";
            this.COM_PORT.Click += new System.EventHandler(this.COM_PORT_Click);
            // 
            // BAUD_RATE
            // 
            this.BAUD_RATE.AutoSize = true;
            this.BAUD_RATE.Location = new System.Drawing.Point(4, 70);
            this.BAUD_RATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAUD_RATE.Name = "BAUD_RATE";
            this.BAUD_RATE.Size = new System.Drawing.Size(89, 16);
            this.BAUD_RATE.TabIndex = 3;
            this.BAUD_RATE.Text = "BAUD_RATE";
            // 
            // DATA_BITS
            // 
            this.DATA_BITS.AutoSize = true;
            this.DATA_BITS.Location = new System.Drawing.Point(8, 100);
            this.DATA_BITS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DATA_BITS.Name = "DATA_BITS";
            this.DATA_BITS.Size = new System.Drawing.Size(81, 16);
            this.DATA_BITS.TabIndex = 4;
            this.DATA_BITS.Text = "DATA_BITS";
            // 
            // STOP_BITS
            // 
            this.STOP_BITS.AutoSize = true;
            this.STOP_BITS.Location = new System.Drawing.Point(8, 137);
            this.STOP_BITS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STOP_BITS.Name = "STOP_BITS";
            this.STOP_BITS.Size = new System.Drawing.Size(81, 16);
            this.STOP_BITS.TabIndex = 5;
            this.STOP_BITS.Text = "STOP_BITS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxParitybits);
            this.groupBox1.Controls.Add(this.PARITY_BITS);
            this.groupBox1.Controls.Add(this.CboxStopbits);
            this.groupBox1.Controls.Add(this.CboxDatabits);
            this.groupBox1.Controls.Add(this.CboxBaudRate);
            this.groupBox1.Controls.Add(this.CboxCport);
            this.groupBox1.Controls.Add(this.BAUD_RATE);
            this.groupBox1.Controls.Add(this.STOP_BITS);
            this.groupBox1.Controls.Add(this.COM_PORT);
            this.groupBox1.Controls.Add(this.DATA_BITS);
            this.groupBox1.Location = new System.Drawing.Point(57, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(285, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com port control";
            // 
            // CboxParitybits
            // 
            this.CboxParitybits.FormattingEnabled = true;
            this.CboxParitybits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CboxParitybits.Location = new System.Drawing.Point(108, 166);
            this.CboxParitybits.Margin = new System.Windows.Forms.Padding(4);
            this.CboxParitybits.Name = "CboxParitybits";
            this.CboxParitybits.Size = new System.Drawing.Size(160, 24);
            this.CboxParitybits.TabIndex = 12;
            this.CboxParitybits.Text = "None";
            // 
            // PARITY_BITS
            // 
            this.PARITY_BITS.AutoSize = true;
            this.PARITY_BITS.Location = new System.Drawing.Point(4, 166);
            this.PARITY_BITS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PARITY_BITS.Name = "PARITY_BITS";
            this.PARITY_BITS.Size = new System.Drawing.Size(93, 16);
            this.PARITY_BITS.TabIndex = 11;
            this.PARITY_BITS.Text = "PARITY_BITS";
            // 
            // CboxStopbits
            // 
            this.CboxStopbits.FormattingEnabled = true;
            this.CboxStopbits.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.CboxStopbits.Location = new System.Drawing.Point(108, 133);
            this.CboxStopbits.Margin = new System.Windows.Forms.Padding(4);
            this.CboxStopbits.Name = "CboxStopbits";
            this.CboxStopbits.Size = new System.Drawing.Size(160, 24);
            this.CboxStopbits.TabIndex = 10;
            this.CboxStopbits.Text = "One";
            // 
            // CboxDatabits
            // 
            this.CboxDatabits.FormattingEnabled = true;
            this.CboxDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CboxDatabits.Location = new System.Drawing.Point(108, 100);
            this.CboxDatabits.Margin = new System.Windows.Forms.Padding(4);
            this.CboxDatabits.Name = "CboxDatabits";
            this.CboxDatabits.Size = new System.Drawing.Size(160, 24);
            this.CboxDatabits.TabIndex = 9;
            this.CboxDatabits.Text = "8";
            // 
            // CboxBaudRate
            // 
            this.CboxBaudRate.FormattingEnabled = true;
            this.CboxBaudRate.Items.AddRange(new object[] {
            "115200",
            "9600",
            "57600"});
            this.CboxBaudRate.Location = new System.Drawing.Point(108, 66);
            this.CboxBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.CboxBaudRate.Name = "CboxBaudRate";
            this.CboxBaudRate.Size = new System.Drawing.Size(160, 24);
            this.CboxBaudRate.TabIndex = 8;
            this.CboxBaudRate.Text = "115200";
            // 
            // CboxCport
            // 
            this.CboxCport.FormattingEnabled = true;
            this.CboxCport.Location = new System.Drawing.Point(108, 31);
            this.CboxCport.Margin = new System.Windows.Forms.Padding(4);
            this.CboxCport.Name = "CboxCport";
            this.CboxCport.Size = new System.Drawing.Size(160, 24);
            this.CboxCport.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.CLOSE);
            this.groupBox2.Controls.Add(this.OPEN);
            this.groupBox2.Location = new System.Drawing.Point(393, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(239, 150);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open port";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 97);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 28);
            this.progressBar1.TabIndex = 10;
            // 
            // CLOSE
            // 
            this.CLOSE.Location = new System.Drawing.Point(116, 42);
            this.CLOSE.Margin = new System.Windows.Forms.Padding(4);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(100, 28);
            this.CLOSE.TabIndex = 9;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.UseVisualStyleBackColor = true;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(8, 42);
            this.OPEN.Margin = new System.Windows.Forms.Padding(4);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(100, 28);
            this.OPEN.TabIndex = 8;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(639, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 96);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Prawo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(756, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 96);
            this.button3.TabIndex = 15;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(756, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Dół";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(476, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Góra";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "STEROWANIE RĘCZNE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "OŚ Z";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "OŚ X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "OŚ Y";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(613, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Lewo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(756, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Góra";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(476, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 24;
            this.button8.Text = "Dół";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(996, 530);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Praca inżynierska Filip Kwecień";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label COM_PORT;
        private System.Windows.Forms.Label BAUD_RATE;
        private System.Windows.Forms.Label DATA_BITS;
        private System.Windows.Forms.Label STOP_BITS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboxStopbits;
        private System.Windows.Forms.ComboBox CboxDatabits;
        private System.Windows.Forms.ComboBox CboxBaudRate;
        private System.Windows.Forms.ComboBox CboxCport;
        private System.Windows.Forms.ComboBox CboxParitybits;
        private System.Windows.Forms.Label PARITY_BITS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Button OPEN;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

