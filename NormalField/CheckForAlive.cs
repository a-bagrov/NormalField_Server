using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalField
{
    public static class CheckForAlive
    {
        private static int time;
        public static void Do()
        {
            for (int i=0;i<Form1.time_last_seen.Count;i++)
            {
                time = GetUnixTime.Do() - Form1.time_last_seen[i];
                if (time>30)
                {
                    Form1.dataGridView[3, i].Value = "не в сети "+((time / 60 > 0) ? (time/60).ToString()+" мин." : time.ToString().Substring(0, time.ToString().Length - 1) + "0" + " c.");
                    
                    if (Form1.dataGridView[3, i].Style.BackColor != Color.Red)
                    {
                        ProcessingResponse.Change_Style(3, i, Color.Red);
                        ProcessingResponse.quantity_of_students -= ProcessingResponse.CountWords(Form1.dataGridView[1, i].Value.ToString(), "\n") + 1;
                    }
                    Form1.dataGridView[3, i].Style.BackColor = Color.Red;
                    Form1.label_all_students.Text = "Подключено тестируемых: " + ProcessingResponse.quantity_of_students;

                }
            }
        }
    }
}
