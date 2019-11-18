using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Linq;

namespace NormalField
{
    public class UdpServer
    {
        public static string ip = null;
        private static string SubnetMask;
        private static BackgroundWorker backgroundWorker = new System.ComponentModel.BackgroundWorker();
        public static ToolStripLabel toolStripLabel;
        private static void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (toolStripLabel.Text)
            {
                case "Сервер работает   ":
                    toolStripLabel.Text = "Cервер работает.  ";
                    break;
                case "Cервер работает.  ":
                    toolStripLabel.Text = "Cервер работает.. ";
                    break;
                case "Cервер работает.. ":
                    toolStripLabel.Text = "Cервер работает...";
                    break;
                default:
                    toolStripLabel.Text = "Сервер работает   ";
                    break;
            }
            CheckForAlive.Do();
        }
        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Byte[] bytes;
                EndPoint endPoint;


                NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface Interface in Interfaces)
                {
                    if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                    Console.WriteLine(Interface.Description);
                    UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
                    foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
                    {
                        if (UnicatIPInfo.Address.ToString() == ip)
                            SubnetMask=UnicatIPInfo.IPv4Mask.ToString();
                    }
                }

                endPoint = new IPEndPoint(GetBroadcastAddress.Do(IPAddress.Parse(ip), IPAddress.Parse(SubnetMask)), 32177);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                while (true)
                {
                    bytes = Encoding.UTF8.GetBytes(Form1.data_to_send);
                    socket.SendTo(bytes, endPoint);
                    backgroundWorker.ReportProgress(0);
                    Thread.Sleep(5000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ошибка3\n" + ex.Message, "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Do()
        {
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerAsyn​c();
        }


    }
}