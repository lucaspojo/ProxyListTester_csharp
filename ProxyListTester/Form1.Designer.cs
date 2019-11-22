namespace ProxyListTester
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_LoadProxyList = new System.Windows.Forms.Button();
            this.Listbox_ConsoleIpPort = new System.Windows.Forms.ListBox();
            this.Label_ProxyCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Timeout = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_removeUrlTesting = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_urlToTest = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LoadProxyList
            // 
            this.button_LoadProxyList.Location = new System.Drawing.Point(8, 8);
            this.button_LoadProxyList.Name = "button_LoadProxyList";
            this.button_LoadProxyList.Size = new System.Drawing.Size(112, 23);
            this.button_LoadProxyList.TabIndex = 0;
            this.button_LoadProxyList.Text = "Load Proxy List";
            this.button_LoadProxyList.UseVisualStyleBackColor = true;
            this.button_LoadProxyList.Click += new System.EventHandler(this.button_LoadProxyList_Click);
            // 
            // Listbox_ConsoleIpPort
            // 
            this.Listbox_ConsoleIpPort.FormattingEnabled = true;
            this.Listbox_ConsoleIpPort.Location = new System.Drawing.Point(8, 37);
            this.Listbox_ConsoleIpPort.Name = "Listbox_ConsoleIpPort";
            this.Listbox_ConsoleIpPort.Size = new System.Drawing.Size(312, 95);
            this.Listbox_ConsoleIpPort.TabIndex = 1;
            // 
            // Label_ProxyCount
            // 
            this.Label_ProxyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ProxyCount.Location = new System.Drawing.Point(136, 16);
            this.Label_ProxyCount.Name = "Label_ProxyCount";
            this.Label_ProxyCount.Size = new System.Drawing.Size(186, 16);
            this.Label_ProxyCount.TabIndex = 2;
            this.Label_ProxyCount.Text = "Proxy : 0";
            this.Label_ProxyCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 2);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Timeout ms :";
            // 
            // comboBox_Timeout
            // 
            this.comboBox_Timeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Timeout.FormattingEnabled = true;
            this.comboBox_Timeout.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000",
            "16000",
            "17000",
            "18000",
            "19000",
            "20000"});
            this.comboBox_Timeout.Location = new System.Drawing.Point(8, 165);
            this.comboBox_Timeout.Name = "comboBox_Timeout";
            this.comboBox_Timeout.Size = new System.Drawing.Size(313, 21);
            this.comboBox_Timeout.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Testing URL :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_AddNewUrlTesting);
            // 
            // button_removeUrlTesting
            // 
            this.button_removeUrlTesting.Location = new System.Drawing.Point(8, 296);
            this.button_removeUrlTesting.Name = "button_removeUrlTesting";
            this.button_removeUrlTesting.Size = new System.Drawing.Size(75, 23);
            this.button_removeUrlTesting.TabIndex = 11;
            this.button_removeUrlTesting.Text = "Remove";
            this.button_removeUrlTesting.UseVisualStyleBackColor = true;
            this.button_removeUrlTesting.Click += new System.EventHandler(this.button_removeUrlTesting_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(8, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 2);
            this.label6.TabIndex = 13;
            // 
            // listBox_urlToTest
            // 
            this.listBox_urlToTest.FormattingEnabled = true;
            this.listBox_urlToTest.Items.AddRange(new object[] {
            "http://www.mon-ip.com/",
            "http://monip.org/",
            "https://www.mon-ip.net/"});
            this.listBox_urlToTest.Location = new System.Drawing.Point(8, 221);
            this.listBox_urlToTest.Name = "listBox_urlToTest";
            this.listBox_urlToTest.Size = new System.Drawing.Size(312, 69);
            this.listBox_urlToTest.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(8, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 2);
            this.label5.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Number of tests at the same time :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 334);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(139, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 394);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Redpeace63 [NULLED.TO]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 412);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox_urlToTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_removeUrlTesting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Timeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_ProxyCount);
            this.Controls.Add(this.button_LoadProxyList);
            this.Controls.Add(this.Listbox_ConsoleIpPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProxyListTester";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadProxyList;
        private System.Windows.Forms.ListBox Listbox_ConsoleIpPort;
        private System.Windows.Forms.Label Label_ProxyCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Timeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_removeUrlTesting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_urlToTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

