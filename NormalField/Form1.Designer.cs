namespace NormalField
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_First_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Second_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ThirdTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Reboot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Help = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Is_Passed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.toolStripSeparator5,
            this.toolStripLabel4,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1678, 35);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(285, 32);
            this.toolStripButton1.Text = "Выбрать файл с фамилиями...";
            this.toolStripButton1.ToolTipText = "Выберите файл с \r\nфамилиями студентов. \r\nКаждая фамилия должна \r\nначинаться с нов" +
    "ой строки.";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::NormalField.Properties.Resources.save;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(256, 32);
            this.toolStripButton2.Text = "Сохранить результаты...";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(192, 32);
            this.toolStripLabel1.Text = "Сервер выключен";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(408, 32);
            this.toolStripLabel2.Text = "Откройте файл с фамилиями студентов";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(297, 32);
            this.toolStripLabel3.Text = "Подключено тестируемых: 0";
            this.toolStripLabel3.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            this.toolStripSeparator5.Visible = false;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(384, 32);
            this.toolStripLabel4.Text = "Количество сдавших тестирование: 0";
            this.toolStripLabel4.Visible = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.column_surname,
            this.Column_Variant,
            this.Column_State,
            this.Column_First_Task,
            this.Column_Second_Task,
            this.Column_ThirdTask,
            this.Column_Quantity,
            this.Column_Reboot,
            this.Column_Help,
            this.Column_Is_Passed,
            this.Column_Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1654, 895);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column_ID
            // 
            this.Column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ID.FillWeight = 20F;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // column_surname
            // 
            this.column_surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.column_surname.DefaultCellStyle = dataGridViewCellStyle2;
            this.column_surname.FillWeight = 150F;
            this.column_surname.HeaderText = "Фамилия";
            this.column_surname.Name = "column_surname";
            this.column_surname.ReadOnly = true;
            this.column_surname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column_surname.ToolTipText = "Фамилии одного студента или пары, выполняющих тест";
            // 
            // Column_Variant
            // 
            this.Column_Variant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Variant.FillWeight = 40F;
            this.Column_Variant.HeaderText = "Вариант";
            this.Column_Variant.Name = "Column_Variant";
            this.Column_Variant.ReadOnly = true;
            this.Column_Variant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_State
            // 
            this.Column_State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_State.FillWeight = 50F;
            this.Column_State.HeaderText = "Состояние";
            this.Column_State.Name = "Column_State";
            this.Column_State.ReadOnly = true;
            this.Column_State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_First_Task
            // 
            this.Column_First_Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_First_Task.FillWeight = 50F;
            this.Column_First_Task.HeaderText = "Первое задание";
            this.Column_First_Task.Name = "Column_First_Task";
            this.Column_First_Task.ReadOnly = true;
            this.Column_First_Task.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Second_Task
            // 
            this.Column_Second_Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Second_Task.FillWeight = 50F;
            this.Column_Second_Task.HeaderText = "Второе задание";
            this.Column_Second_Task.Name = "Column_Second_Task";
            this.Column_Second_Task.ReadOnly = true;
            this.Column_Second_Task.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_ThirdTask
            // 
            this.Column_ThirdTask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ThirdTask.FillWeight = 50F;
            this.Column_ThirdTask.HeaderText = "Третье задание";
            this.Column_ThirdTask.Name = "Column_ThirdTask";
            this.Column_ThirdTask.ReadOnly = true;
            this.Column_ThirdTask.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Quantity
            // 
            this.Column_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Quantity.FillWeight = 60F;
            this.Column_Quantity.HeaderText = "Количество попыток";
            this.Column_Quantity.Name = "Column_Quantity";
            this.Column_Quantity.ReadOnly = true;
            this.Column_Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Reboot
            // 
            this.Column_Reboot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Reboot.FillWeight = 60F;
            this.Column_Reboot.HeaderText = "Количество перезапусков";
            this.Column_Reboot.Name = "Column_Reboot";
            this.Column_Reboot.ReadOnly = true;
            this.Column_Reboot.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Help
            // 
            this.Column_Help.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Help.FillWeight = 50F;
            this.Column_Help.HeaderText = "Помощь";
            this.Column_Help.Name = "Column_Help";
            this.Column_Help.ReadOnly = true;
            this.Column_Help.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Is_Passed
            // 
            this.Column_Is_Passed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Is_Passed.FillWeight = 50F;
            this.Column_Is_Passed.HeaderText = "Результат";
            this.Column_Is_Passed.Name = "Column_Is_Passed";
            this.Column_Is_Passed.ReadOnly = true;
            this.Column_Is_Passed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Delete
            // 
            this.Column_Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Delete.FillWeight = 50F;
            this.Column_Delete.HeaderText = "Удалить строку";
            this.Column_Delete.Name = "Column_Delete";
            this.Column_Delete.ReadOnly = true;
            this.Column_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
            this.openFileDialog1.Title = "Открыть файл с фамилиями";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1678, 957);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Normal Field Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Variant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_First_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Second_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ThirdTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Reboot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Help;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Is_Passed;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Delete;
    }
}

