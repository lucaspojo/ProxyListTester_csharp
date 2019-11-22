using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProxyListTester;

namespace ProxyListTester
{
    public partial class MainForm : Form
    {

        public static List<IpPortStruct> ListIpPort = new List<IpPortStruct>();
        public static List<TestUrlStruct> ListTestUrl = new List<TestUrlStruct>();

        public MainForm()
        {
            InitializeComponent();
            comboBox_Timeout.SelectedIndex = 9;
        }

        public void button_LoadProxyList_Click(object sender, EventArgs e)
        {
            ProxyFile.OpenFileDialog();

            if (ProxyFile.ListIpPort.Count != 0)
            {
                Label_ProxyCount.Text = "Proxy : " + ProxyFile.ListIpPort.Count;
                foreach (ProxyFile.IpPortStruct el in ProxyFile.ListIpPort)
                {
                    ListIpPort.Add(new IpPortStruct { Ip = el.Ip, Port = el.Port });
                    Listbox_ConsoleIpPort.Items.Add(el.Ip + ":" + el.Port);
                }
            }
        }

        // New form for input new url
        private void button1_AddNewUrlTesting(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            listBox_urlToTest.Items.Add( form2.textBox_url.Text );
        }

        // Remove url from listbox
        private void button_removeUrlTesting_Click(object sender, EventArgs e)
        {
            listBox_urlToTest.Items.Remove(listBox_urlToTest.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var listBoxItem in listBox_urlToTest.Items)
            {
                ListTestUrl.Add(new TestUrlStruct { Url = listBoxItem.ToString() });
            }

            if (ListIpPort.Count == 0)
            {
                MessageBox.Show("Add a Valid ProxyList.");
                return;
            }

            if (ListTestUrl.Count == 0)
            {
                MessageBox.Show("You must have at least one valid url.");
                return;
            }

            var timeoutMax = comboBox_Timeout.Text;
            Form3 form3 = new Form3(numericUpDown1.Value, listBox_urlToTest, timeoutMax);
            form3.ShowDialog();
        }

        public class IpPortStruct
        {
            public string Ip { get; set; }
            public string Port { get; set; }
        };

        public class TestUrlStruct
        {
            public string Url { get; set; }
        };

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nulled.to/user/3077136-redpeace63");
        }
    }
}
