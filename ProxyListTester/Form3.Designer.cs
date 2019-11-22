namespace ProxyListTester
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CountProxyRemaining = new System.Windows.Forms.Label();
            this.label_CountInvalidProxy = new System.Windows.Forms.Label();
            this.label_CountValidProxy = new System.Windows.Forms.Label();
            this.label_CountCurrentTesting = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_percentageProgress = new System.Windows.Forms.Label();
            this.buttonSaveWorkingList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proxy remaining :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invalid proxy :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_CountProxyRemaining, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CountInvalidProxy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_CountValidProxy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_CountCurrentTesting, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 76);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Testing :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valid proxy :";
            // 
            // label_CountProxyRemaining
            // 
            this.label_CountProxyRemaining.Location = new System.Drawing.Point(128, 0);
            this.label_CountProxyRemaining.Name = "label_CountProxyRemaining";
            this.label_CountProxyRemaining.Size = new System.Drawing.Size(69, 13);
            this.label_CountProxyRemaining.TabIndex = 4;
            this.label_CountProxyRemaining.Text = "0";
            this.label_CountProxyRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CountInvalidProxy
            // 
            this.label_CountInvalidProxy.Location = new System.Drawing.Point(128, 18);
            this.label_CountInvalidProxy.Name = "label_CountInvalidProxy";
            this.label_CountInvalidProxy.Size = new System.Drawing.Size(69, 13);
            this.label_CountInvalidProxy.TabIndex = 5;
            this.label_CountInvalidProxy.Text = "0";
            this.label_CountInvalidProxy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_CountValidProxy
            // 
            this.label_CountValidProxy.Location = new System.Drawing.Point(128, 36);
            this.label_CountValidProxy.Name = "label_CountValidProxy";
            this.label_CountValidProxy.Size = new System.Drawing.Size(69, 13);
            this.label_CountValidProxy.TabIndex = 6;
            this.label_CountValidProxy.Text = "0";
            this.label_CountValidProxy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_CountCurrentTesting
            // 
            this.label_CountCurrentTesting.Location = new System.Drawing.Point(128, 54);
            this.label_CountCurrentTesting.Name = "label_CountCurrentTesting";
            this.label_CountCurrentTesting.Size = new System.Drawing.Size(69, 22);
            this.label_CountCurrentTesting.TabIndex = 8;
            this.label_CountCurrentTesting.Text = "0";
            this.label_CountCurrentTesting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label_percentageProgress
            // 
            this.label_percentageProgress.Location = new System.Drawing.Point(173, 94);
            this.label_percentageProgress.Name = "label_percentageProgress";
            this.label_percentageProgress.Size = new System.Drawing.Size(39, 23);
            this.label_percentageProgress.TabIndex = 5;
            this.label_percentageProgress.Text = "0%";
            this.label_percentageProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSaveWorkingList
            // 
            this.buttonSaveWorkingList.Enabled = false;
            this.buttonSaveWorkingList.Location = new System.Drawing.Point(12, 123);
            this.buttonSaveWorkingList.Name = "buttonSaveWorkingList";
            this.buttonSaveWorkingList.Size = new System.Drawing.Size(200, 23);
            this.buttonSaveWorkingList.TabIndex = 6;
            this.buttonSaveWorkingList.Text = "Save Wroking List";
            this.buttonSaveWorkingList.UseVisualStyleBackColor = true;
            this.buttonSaveWorkingList.Click += new System.EventHandler(this.buttonSaveWorkingList_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 152);
            this.Controls.Add(this.buttonSaveWorkingList);
            this.Controls.Add(this.label_percentageProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing..";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_percentageProgress;
        private System.Windows.Forms.Button buttonSaveWorkingList;
        private System.Windows.Forms.Label label_CountProxyRemaining;
        private System.Windows.Forms.Label label_CountInvalidProxy;
        private System.Windows.Forms.Label label_CountValidProxy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_CountCurrentTesting;
    }
}