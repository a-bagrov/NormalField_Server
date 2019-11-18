using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NormalField
{
    public static class ProcessingResponse
    {
        private static List<int> tryies_in_current_session = new List<int>();
        private static List<int> tryies_in_all_sessions = new List<int>();
        private static List<int> tryies_start_time = new List<int>();
        private static List<int> reboot_quantity = new List<int>();
        private static List<bool> is_passed = new List<bool>();

        public static int quantity_of_students = 0;
        private static int quantity_of_passed_students = 0;
        private static string[] responce_array;


        //все столбцы с 6 +1
        //все responce array c 3 +1

        //responce array
        //0 - имя
        //1 - 1 задание
        //2 - 2
        //3 - 3
        //4 - вариант 
        //5 - количество попыток
        //6 - помошь
        public static void Do(string data)
        {
            try
            {
                //MessageBox.Show(data);
                responce_array = data.Split('~');
                for (int i = 0; i < Form1.dataGridView.RowCount; i++)
                {

                    if (Form1.dataGridView[1, i].Value.ToString() == responce_array[0])//правим
                    {
                        if (is_passed[i] == true) return;

                        if (Int32.TryParse(responce_array[5], out int n) && tryies_in_current_session[i] < n)
                        {
                            tryies_start_time[i] = GetUnixTime.Do();
                            tryies_in_current_session[i] = n;
                        }
                        else
                        {
                            if (n < tryies_in_current_session[i])//перезапуск
                            {
                                reboot_quantity[i]++;
                                Form1.dataGridView[8, i].Value = reboot_quantity[i];
                                tryies_in_all_sessions[i] += tryies_in_current_session[i]-1;
                                tryies_in_current_session[i] = n;
                            }
                        }
                        
                        if (GetUnixTime.Do() - tryies_start_time[i] < 30 + (tryies_in_current_session[i] - 1) * 10)
                        {
                            Form1.dataGridView[3, i].Value = "ожидает " + (30 + (n - 2) * 10).ToString() + " сек.";
                            Form1.dataGridView[3, i].Style.BackColor = Color.Yellow;
                            Change_Style(3, i, Color.Yellow);
                            if (responce_array[1] == "0")
                            {
                                Form1.dataGridView[4, i].Value = "не выполнено";
                                Form1.dataGridView[5, i].Value = "не выполнено";
                                Form1.dataGridView[6, i].Value = "не выполнено";
                            }
                            else
                            {
                                Form1.dataGridView[4, i].Value = "выполнено";
                                if (responce_array[2]=="0")
                                {
                                    Form1.dataGridView[5, i].Value = "не выполнено";
                                    Form1.dataGridView[6, i].Value = "не выполнено";
                                }
                                else
                                {
                                    Form1.dataGridView[5, i].Value = "выполнено";
                                }
                            }
                            Form1.dataGridView[6, i].Value = "не выполнено";
                            Form1.dataGridView[7, i].Value = (tryies_in_current_session[i]+tryies_in_all_sessions[i]).ToString();
                            Form1.time_last_seen[i] = GetUnixTime.Do();
                        }
                        else
                        {
                            CheckAnswer(i);
                        }
                        return;
                    }
                    
                }

                //добавляем

                Form1.dataGridView.Rows.Add();
                if (Form1.dataGridView.RowCount > 1)
                    Form1.dataGridView[0, Form1.dataGridView.RowCount - 1].Value = (Convert.ToInt32(Form1.dataGridView[0, Form1.dataGridView.RowCount - 2].Value.ToString()) + 1).ToString();
                else
                    Form1.dataGridView[0, Form1.dataGridView.RowCount - 1].Value = "1";
                Form1.dataGridView[1, Form1.dataGridView.RowCount - 1].Value = responce_array[0];
                Form1.dataGridView[2, Form1.dataGridView.RowCount - 1].Value = responce_array[4];
                Form1.dataGridView[3, Form1.dataGridView.RowCount - 1].Value = "в работе"; //состояние
                Form1.dataGridView[7, Form1.dataGridView.RowCount - 1].Value = "1"; //количество попыток
                Form1.dataGridView[8, Form1.dataGridView.RowCount - 1].Value = 0; //количество перезапусков
                Form1.dataGridView[9, Form1.dataGridView.RowCount - 1].Value = "не требуется"; //помощь
                Form1.dataGridView[10, Form1.dataGridView.RowCount - 1].Value = "тест еще не пройден"; //результат
                Form1.dataGridView[11, Form1.dataGridView.RowCount - 1].Value = "Удалить";

                if (CountWords(responce_array[0], "\n")>0)
                    quantity_of_students += 2;
                else
                    quantity_of_students++;
                Form1.label_all_students.Text = "Подключено тестируемых: " + quantity_of_students;

                Form1.time_last_seen.Add(GetUnixTime.Do());
                tryies_in_current_session.Add(1);
                tryies_in_all_sessions.Add(0);
                tryies_start_time.Add(1);
                is_passed.Add(false);
                reboot_quantity.Add(0);
                CheckAnswer(Form1.dataGridView.RowCount - 1);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void CheckAnswer(int i)
        {
            try
            {
                if (responce_array[1] == "0")
                {
                    Form1.dataGridView[4, i].Value = "выполняется";
                    Form1.dataGridView[5, i].Value = "не выполнено";
                    Form1.dataGridView[6, i].Value = "не выполнено";
                }
                else
                {
                    Form1.dataGridView[4, i].Value = "выполнено";
                    if (responce_array[2] == "0")
                    {
                        Form1.dataGridView[5, i].Value = "выполняется";
                        Form1.dataGridView[6, i].Value = "не выполнено";
                    }
                    else
                    {
                        Form1.dataGridView[5, i].Value = "выполнено";
                        if (responce_array[3] == "0")
                        {
                            Form1.dataGridView[6, i].Value = "выполняется";
                        }
                        else
                        {
                            Form1.dataGridView[6, i].Value = "выполнено";
                            Form1.dataGridView[10, i].Value = "З А Ч Е Т";
                            Form1.dataGridView[3, i].Value = "тест пройден";
                            if (CountWords(Form1.dataGridView[1, i].Value.ToString(), "\n") > 0)
                                quantity_of_passed_students += 2;
                            else
                                quantity_of_passed_students++;
                            Form1.label_passed_student.Text = "Всего сдавших тестирование: " + quantity_of_passed_students;

                            for (int j = 0; j < Form1.dataGridView.ColumnCount; j++)
                            {
                                Form1.dataGridView[j, i].Style.BackColor = Color.LightGreen;
                                Change_Style(j, i, Color.LightGreen);
                            }
                            Form1.time_last_seen[i] = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1969, 1, 1))).TotalSeconds;
                            is_passed[i] = true;
                            return;
                        }
                    }

                }
                if (responce_array[6] == "1")
                {
                    Form1.dataGridView[9, i].Value = "требуется";
                    Form1.dataGridView[9, i].Style.BackColor = Color.Yellow;
                    Change_Style(9, i, Color.Yellow);

                }
                else
                {
                    Form1.dataGridView[9, i].Value = "не требуется";
                    Form1.dataGridView[9, i].Style.BackColor = SystemColors.Window;
                    Change_Style(9, i, SystemColors.Window);

                }
                if (Form1.dataGridView[3, i].Style.BackColor == Color.Red)
                {
                    quantity_of_students += CountWords(Form1.dataGridView[1, i].Value.ToString(), "\n") + 1;
                    Form1.label_all_students.Text = "Подключено тестируемых: " + quantity_of_students;
                }
                Form1.time_last_seen[i] = GetUnixTime.Do();
                Form1.dataGridView[3, i].Value = "в работе";
                Form1.dataGridView[3, i].Style.BackColor = SystemColors.Window;
                Change_Style(3, i, SystemColors.Window);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && MessageBox.Show(
        "Вы хотите удалить строку? Если студент не закрыл программу, строка появится снова.",
        "Normal Field Server",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
       ) == DialogResult.Yes)
            {
                if (Form1.dataGridView[3, e.RowIndex].Style.BackColor != Color.Red)
                {
                    if (CountWords(Form1.dataGridView[1, e.RowIndex].Value.ToString(), "\n") > 0)
                    {
                        if (is_passed[e.RowIndex]) quantity_of_passed_students -= 2;
                        quantity_of_students -= 2;
                    }
                    else
                    {
                        if (is_passed[e.RowIndex]) quantity_of_passed_students--;
                        quantity_of_students--;
                    }
                }
                Form1.dataGridView.Rows.RemoveAt(e.RowIndex);
                tryies_in_current_session.RemoveAt(e.RowIndex);
                tryies_in_all_sessions.RemoveAt(e.RowIndex);
                tryies_start_time.RemoveAt(e.RowIndex);              
                is_passed.RemoveAt(e.RowIndex);
                reboot_quantity.RemoveAt(e.RowIndex);
                Form1.time_last_seen.RemoveAt(e.RowIndex);
                Form1.label_passed_student.Text = "Всего сдавших тестирование: " + quantity_of_passed_students;
                Form1.label_all_students.Text = "Подключено тестируемых: " + quantity_of_students;

                for (int i = 0; i < Form1.dataGridView.RowCount; i++)
                    Form1.dataGridView[0, i].Value = i + 1;
            }
        }

        public static void Change_Style(int i,int j, Color color)
        {
            Form1.dataGridView[i, j].Style.SelectionBackColor = color;
        }

        public static int CountWords(string s, string s0)
        {
            return Math.Max((s.Length - s.Replace(s0, "").Length) / s0.Length,(s.Length - s.Replace("\r", "").Length) / "\r".Length);
            
        }

    }
}


