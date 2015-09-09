namespace Barcode_Keyence
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_dataport = new System.Windows.Forms.TextBox();
            this.textBox_communicationport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ipaddress4 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress3 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress2 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.barcodeReaderControl1 = new Keyence.AutoID.BarcodeReaderControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_close = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_dataport);
            this.groupBox2.Controls.Add(this.textBox_communicationport);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ipaddress4);
            this.groupBox2.Controls.Add(this.textBox_ipaddress3);
            this.groupBox2.Controls.Add(this.textBox_ipaddress2);
            this.groupBox2.Controls.Add(this.textBox_ipaddress1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // textBox_dataport
            // 
            this.textBox_dataport.Location = new System.Drawing.Point(320, 47);
            this.textBox_dataport.Multiline = true;
            this.textBox_dataport.Name = "textBox_dataport";
            this.textBox_dataport.Size = new System.Drawing.Size(70, 20);
            this.textBox_dataport.TabIndex = 16;
            // 
            // textBox_communicationport
            // 
            this.textBox_communicationport.Location = new System.Drawing.Point(228, 47);
            this.textBox_communicationport.Multiline = true;
            this.textBox_communicationport.Name = "textBox_communicationport";
            this.textBox_communicationport.Size = new System.Drawing.Size(70, 20);
            this.textBox_communicationport.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Communication and Data Port";
            // 
            // textBox_ipaddress4
            // 
            this.textBox_ipaddress4.Location = new System.Drawing.Point(141, 47);
            this.textBox_ipaddress4.Multiline = true;
            this.textBox_ipaddress4.Name = "textBox_ipaddress4";
            this.textBox_ipaddress4.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress4.TabIndex = 13;
            // 
            // textBox_ipaddress3
            // 
            this.textBox_ipaddress3.Location = new System.Drawing.Point(98, 47);
            this.textBox_ipaddress3.Multiline = true;
            this.textBox_ipaddress3.Name = "textBox_ipaddress3";
            this.textBox_ipaddress3.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress3.TabIndex = 12;
            // 
            // textBox_ipaddress2
            // 
            this.textBox_ipaddress2.Location = new System.Drawing.Point(55, 47);
            this.textBox_ipaddress2.Multiline = true;
            this.textBox_ipaddress2.Name = "textBox_ipaddress2";
            this.textBox_ipaddress2.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress2.TabIndex = 11;
            // 
            // textBox_ipaddress1
            // 
            this.textBox_ipaddress1.Location = new System.Drawing.Point(12, 47);
            this.textBox_ipaddress1.Multiline = true;
            this.textBox_ipaddress1.Name = "textBox_ipaddress1";
            this.textBox_ipaddress1.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter IP Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_status);
            this.groupBox4.Location = new System.Drawing.Point(13, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 106);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(8, 16);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(398, 81);
            this.textBox_status.TabIndex = 0;
            // 
            // barcodeReaderControl1
            // 
            this.barcodeReaderControl1.BackColor = System.Drawing.Color.Black;
            this.barcodeReaderControl1.Location = new System.Drawing.Point(8, 14);
            this.barcodeReaderControl1.Name = "barcodeReaderControl1";
            this.barcodeReaderControl1.Size = new System.Drawing.Size(100, 64);
            this.barcodeReaderControl1.TabIndex = 12;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(10, 58);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(96, 40);
            this.button_close.TabIndex = 14;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(10, 14);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(96, 40);
            this.button_connect.TabIndex = 13;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Location = new System.Drawing.Point(431, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 106);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.barcodeReaderControl1);
            this.groupBox3.Location = new System.Drawing.Point(431, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 84);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 211);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_dataport;
        private System.Windows.Forms.TextBox textBox_communicationport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ipaddress4;
        private System.Windows.Forms.TextBox textBox_ipaddress3;
        private System.Windows.Forms.TextBox textBox_ipaddress2;
        private System.Windows.Forms.TextBox textBox_ipaddress1;
        private System.Windows.Forms.Label label1;
        private Keyence.AutoID.BarcodeReaderControl barcodeReaderControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}

