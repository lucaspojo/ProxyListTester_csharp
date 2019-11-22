using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyListTester
{
    public class ProxyFile
    {

        public static OpenFileDialog ProxyFileDialog;
        public static ProxyFileStruct ProxyFileInfo;
        public static List<IpPortStruct> ListIpPort = new List<IpPortStruct>();

        public static void OpenFileDialog()
        {
            using (ProxyFileDialog = new OpenFileDialog())
            {
                if (ProxyFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProxyFileInfo.FileName = Path.GetFileNameWithoutExtension( ProxyFileDialog.FileName );
                    ProxyFileInfo.FileExt = Path.GetExtension( ProxyFileDialog.FileName ).Replace(".", "");
                    ProxyFileInfo.FilePath = Path.GetDirectoryName( ProxyFileDialog.FileName );

                    if (ProxyFileInfo.FileExt == "txt")
                    {
                        ReadProxyFile(ProxyFileInfo, ProxyFileDialog);
                    }
                    else
                    {
                        MessageBox.Show("The proxy list must be a.txt file in UTF8");
                    }
                }
            }
        }

        public static void ReadProxyFile(ProxyFileStruct FileInfo, OpenFileDialog FileDialog)
        {
            try
            {
                using (var fileStream = File.OpenRead(FileDialog.FileName))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, (Int32)128))
                    {
                        String line;
                        int lineCount = 0;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            lineCount++;
                            string[] s = line.Split(':');

                            if(s[0] == null || s[1] == null)
                            {
                                MessageBox.Show("The file format is invalid.");
                            }
                            else
                            {
                                string ip = s[0];
                                string port = s[1];

                                string[] ipFormat = ip.Split('.');
                                bool isNumeric = !string.IsNullOrEmpty(port) && port.All(Char.IsDigit);

                                if (ipFormat.Count() != 4 || isNumeric == false)
                                {
                                    Console.WriteLine("Format error : " + lineCount);
                                }
                                else
                                {
                                    ListIpPort.Add(new IpPortStruct { Ip = ip, Port = port });
                                }
                            }
                        }
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show("The file format is invalid.");
            }
        }

        public class IpPortStruct
        {
            public string Ip { get; set; }
            public string Port { get; set; }
        };

        public struct ProxyFileStruct
        {
            public string FileName;
            public string FilePath;
            public string FileExt;
        };
    }
}
