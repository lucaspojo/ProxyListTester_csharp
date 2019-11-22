using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyListTester
{
    public partial class Form3 : Form
    {

        public static List<IpPortStruct> ListIpPort = new List<IpPortStruct>();
        public static List<TestUrlStruct> ListTestUrl = new List<TestUrlStruct>();
        public static List<IpPortStruct> ListIpPortValide = new List<IpPortStruct>();

        public static int processingCount = 0;
        public static int proxyProcessedCount = 0;
        public static int proxyFailCount = 0;
        public static int proxyDoneCount = 0;
        public static bool allProxyTest = false;
        public static int proxyProcessedEndCount = 0;

        public static string httptimeout = null;

        public Thread t;


        public Form3(decimal maxRequestInSameTime, ListBox urlToTest, string timeout)
        {
            InitializeComponent();

            httptimeout = timeout;

            foreach (var listBoxItem in urlToTest.Items)
            {
                ListTestUrl.Add(new TestUrlStruct { Url = listBoxItem.ToString() });
            }

            foreach (ProxyFile.IpPortStruct el in ProxyFile.ListIpPort)
            {
                ListIpPort.Add(new IpPortStruct { Ip = el.Ip, Port = el.Port });
            }

            t = new Thread(() => ProcessQueue(maxRequestInSameTime, proxyProcessedCount));
            t.Start();

            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }


        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }


        public void ProcessQueue(decimal maxRequestInSameTime, int VariableDeTest)
        {


            while ( true )
            {

                if (processingCount < maxRequestInSameTime && proxyProcessedCount < ListIpPort.Count())
                {

                    processingCount++;
                    proxyProcessedCount++;

                    Thread GUIoptions = new Thread(() =>
                    {

                        try
                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                label_CountCurrentTesting.Text = "" + processingCount;
                            });
                        } catch(Exception e) { };

                        Random random = new Random();
                        int randomNumber = random.Next(0, ListTestUrl.Count);
                        var el2 = ListTestUrl.ElementAt(randomNumber);

                        var el = ListIpPort.ElementAt(proxyProcessedCount-1);
                        Int32 ProxyPort = int.Parse(el.Port);
                        string ProxyIp = el.Ip;


                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(el2.Url);
                        request.Timeout = Int32.Parse(httptimeout);
                        WebProxy myproxy = new WebProxy(ProxyIp, ProxyPort);
                        myproxy.BypassProxyOnLocal = false;
                        request.Proxy = myproxy;
                        request.Method = "GET";
                        try
                        {
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                proxyDoneCount++;
                                proxyProcessedEndCount++;

                                ListIpPortValide.Add(new IpPortStruct { Ip = el.Ip, Port = el.Port });
                            }
                            else
                            {
                                proxyFailCount++;
                                proxyProcessedEndCount++;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            proxyFailCount++;
                            proxyProcessedEndCount++;
                        }

                        try
                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                            
                                label_CountProxyRemaining.Text = " " + (ListIpPort.Count() - proxyProcessedEndCount);
                                label_CountInvalidProxy.Text = " " + proxyFailCount;
                                label_CountValidProxy.Text = " " + proxyDoneCount;

                                progressBar1.Maximum = 100;
                                int percentComplete = (int)Math.Round((double)(100 * proxyProcessedEndCount) / ListIpPort.Count());
                                if (percentComplete > 100) { percentComplete = 100; };
                                progressBar1.Value = percentComplete;
                                label_percentageProgress.Text = percentComplete.ToString() + "%";
                            
                            });
                        }
                        catch (Exception e) { };

                        //Thread.Sleep(1000);
                        processingCount--;
                    });

                    GUIoptions.IsBackground = true;
                    GUIoptions.Start();
                }

                if(proxyProcessedCount == ListIpPort.Count() && processingCount == 0 && allProxyTest == false)
                {
                    allProxyTest = true;
                    MessageBox.Show("All proxy have been tested");

                    try
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            buttonSaveWorkingList.Enabled = true;
                        });
                    }
                    catch (Exception e) { };
                }

                Thread.Sleep(100);
            }

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

        private void buttonSaveWorkingList_Click(object sender, EventArgs e)
        {

            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string file_name = path+"\\proxy_list_tested_"+ unixTimestamp + ".txt";

            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(file_name);

            for (int i = 0; i < ListIpPortValide.Count; i += 1) 
            {
                var el = ListIpPortValide.ElementAt(i);
                string lineIpPort = el.Ip + ":" + el.Port;
                objWriter.WriteLine(lineIpPort);
            }

            objWriter.Close();
            MessageBox.Show("File saved on desktop !");
        }
    }
}
