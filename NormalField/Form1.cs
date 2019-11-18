using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace NormalField
{

    public partial class Form1 : Form
    {

        public static string data_to_send;
        public static DataGridView dataGridView;
        public static ToolStripLabel label_all_students,label_passed_student;
        public static List<int> time_last_seen = new List<int>();

        public Form1()
        {
            InitializeComponent();
            if (System.Diagnostics.Process.GetProcessesByName(Application.ProductName).Length > 1)
            {
                MessageBox.Show(null, "Приложение уже запущено.", "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            toolStripButton1.Image = Properties.Resources.file_explorer_icon.ToBitmap();
            Icon = Properties.Resources.icon;
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            if (toolStripLabel2.Text == "Файл открыт")
            {

                if (MessageBox.Show(
        "Файл с фамилиями уже открыт. Вы хотите открыть другой файл?",
        "Normal Field Server",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
       ) == DialogResult.No)
                    return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            if (new FileInfo(filename).Length > 1024 * 32)
            {
                MessageBox.Show(null, "Файл слишком большой. Выберите файл меньшего размера.", "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // читаем файл в строку
            try
            {

                dataGridView = dataGridView1;

                System.IO.StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8);
                string file = sr.ReadToEnd();
                sr.Close();
                if (file.Length == 0)
                {
                    MessageBox.Show(null, "Выбран пустой файл.", "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string k="";
                int quantity_of_non_empty_rows = 0;
                foreach(string s in file.Split('\n'))
                {
                    if (s != "\r"&&s!="")
                    {
                        k = k + s + '\n';
                        quantity_of_non_empty_rows++;
                    }
                }
                toolStripLabel2.ToolTipText = k;
                //var result = file.Split('\n').Where(x => x != "");

                //file=String.Join("\n",result);
                //                ProcessingResponse.quantity_of_students= ProcessingResponse.CountWords(file, "\n");
                foreach (IPAddress ip in System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        UdpServer.ip = ip.ToString();
                    }
                }

                if (UdpServer.ip == null)
                    throw new Exception();

                k = k + UdpServer.ip;
                data_to_send = k;

                if (toolStripLabel2.ForeColor != Color.DarkGreen)
                {
                    UdpServer.Do();
                    UDPClient.Do();
                }
                toolStripLabel1.Text = "Сервер работает   ";
                toolStripLabel1.ForeColor = Color.DarkGreen;
                toolStripLabel2.Text = "Всего тестируемых: "+quantity_of_non_empty_rows;
                toolStripLabel2.ForeColor = Color.DarkGreen;
                toolStripLabel3.Visible = true;
                toolStripLabel4.Visible = true;
                toolStripSeparator5.Visible = true; ;
                toolStripSeparator6.Visible = true;
            }

            catch (Exception ex)
            {
                toolStripLabel1.Text = "Сервер выключен";
                toolStripLabel1.ForeColor = Color.FromArgb(255, 128, 128);
                toolStripLabel2.Text = "Файл не открыт";
                toolStripLabel2.ForeColor = Color.FromArgb(255, 128, 128);
                MessageBox.Show(null, "Ошибка\n"+ex.Message, "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UdpServer.toolStripLabel = toolStripLabel1;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.CellClick += ProcessingResponse.dataGridView1_CellContentClick;
            label_all_students = toolStripLabel3;
            label_passed_student = toolStripLabel4;

            this.Size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            this.WindowState = FormWindowState.Maximized;
            toolStripSeparator6.Visible = false;

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (toolStripLabel2.ForeColor == Color.DarkGreen && (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.UserClosing))
                if (MessageBox.Show(
            "Вы хотите закрыть программу?",
            "Normal Field Server",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,

            MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Нет данных для сохранения.", "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                        for (int j = 0; j < dataGridView1.ColumnCount-1; j++)
                            sw.Write(dataGridView1.Columns[j].HeaderText + "\t");
                        sw.WriteLine();
                        for (int i = 0; i < dataGridView.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount-1; j++)
                                sw.Write(dataGridView1[j, i].Value.ToString().Replace('\r', ' ').Replace('\n', ' ') + '\t');
                            sw.WriteLine();
                        }
                        sw.Close();
                        MessageBox.Show("Файл успешно сохранен!\nПуть: " + saveFileDialog1.FileName, "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось сохранить файл.\nОшибка: " + ex.Message, "Normal Field Server", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        
    }
}

