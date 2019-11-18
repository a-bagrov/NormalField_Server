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

namespace NormalField
{
    public class UDPClient
    {
        private static BackgroundWorker backgroundWorker = new System.ComponentModel.BackgroundWorker();

        private static int localPort = 32176;
        private static UdpClient receivingUdpClient = new UdpClient(localPort);
        private static Byte[] receiveBytes = new Byte[0];
        private static IPEndPoint RemoteIpEndPoint = null;
        private static void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            ProcessingResponse.Do(Encoding.UTF8.GetString(receiveBytes, 0, receiveBytes.Length));

            //здесь можно работать с полученными данными
        }
        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {

                    // Получаем файл
                    receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);
                    backgroundWorker.ReportProgress(0);
                    // Преобразуем и отображаем данные
                    //MessageBox.Show(Encoding.Default.GetString(receiveBytes, 0, receiveBytes.Length));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ошибка1\n" + ex.Message, "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Do()
        {
            try
            {
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.WorkerSupportsCancellation = true;
                backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_DoWork);
                backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                backgroundWorker.RunWorkerAsyn​c();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ошибка2\n" + ex.Message, "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Stop()
        {

        }
    }
}