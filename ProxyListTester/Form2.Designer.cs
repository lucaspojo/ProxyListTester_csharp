namespace ProxyListTester
{
    partial class Form2
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
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.button_addNewUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url :";
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(16, 30);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(320, 20);
            this.textBox_url.TabIndex = 1;
            // 
            // button_addNewUrl
            // 
            this.button_addNewUrl.Location = new System.Drawing.Point(261, 56);
            this.button_addNewUrl.Name = "button_addNewUrl";
            this.button_addNewUrl.Size = new System.Drawing.Size(75, 23);
            this.button_addNewUrl.TabIndex = 2;
            this.button_addNewUrl.Text = "Add";
            this.button_addNewUrl.UseVisualStyleBackColor = true;
            this.button_addNewUrl.Click += new System.EventHandler(this.button_addNewUrl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 89);
            this.Controls.Add(this.button_addNewUrl);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add URL for testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Button button_addNewUrl;
    }
}