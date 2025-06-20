namespace AlarmV3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            alarmTimer = new System.Windows.Forms.Timer(components);
            alarmButonTimer = new System.Windows.Forms.Timer(components);
            btnAlarmKur = new Button();
            btnDurdur = new Button();
            btnSesSec = new Button();
            btnErtele = new Button();
            dateTimePicker1 = new DateTimePicker();
            trackBarSes = new TrackBar();
            textBox1 = new TextBox();
            label1 = new Label();
            kalanSureTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBarSes).BeginInit();
            SuspendLayout();
            // 
            // alarmTimer
            // 
            alarmTimer.Tick += alarmTimer_Tick;
            // 
            // alarmButonTimer
            // 
            alarmButonTimer.Tick += alarmButonTimer_Tick;
            // 
            // btnAlarmKur
            // 
            btnAlarmKur.BackColor = Color.Orange;
            btnAlarmKur.Cursor = Cursors.Hand;
            btnAlarmKur.FlatStyle = FlatStyle.Popup;
            btnAlarmKur.Location = new Point(172, 98);
            btnAlarmKur.Margin = new Padding(3, 2, 3, 2);
            btnAlarmKur.Name = "btnAlarmKur";
            btnAlarmKur.Size = new Size(69, 29);
            btnAlarmKur.TabIndex = 0;
            btnAlarmKur.Text = "Alarm Kur";
            btnAlarmKur.UseVisualStyleBackColor = false;
            btnAlarmKur.Click += btnAlarmKur_Click;
            // 
            // btnDurdur
            // 
            btnDurdur.BackColor = Color.Orange;
            btnDurdur.Cursor = Cursors.Hand;
            btnDurdur.FlatStyle = FlatStyle.Popup;
            btnDurdur.Location = new Point(259, 98);
            btnDurdur.Margin = new Padding(3, 2, 3, 2);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(64, 18);
            btnDurdur.TabIndex = 1;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = false;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // btnSesSec
            // 
            btnSesSec.BackColor = Color.Orange;
            btnSesSec.Cursor = Cursors.Hand;
            btnSesSec.FlatStyle = FlatStyle.Popup;
            btnSesSec.Location = new Point(40, 140);
            btnSesSec.Margin = new Padding(3, 2, 3, 2);
            btnSesSec.Name = "btnSesSec";
            btnSesSec.Size = new Size(64, 18);
            btnSesSec.TabIndex = 2;
            btnSesSec.Text = "Ses Sec";
            btnSesSec.UseVisualStyleBackColor = false;
            btnSesSec.Click += btnSesSec_Click;
            // 
            // btnErtele
            // 
            btnErtele.BackColor = Color.Orange;
            btnErtele.Cursor = Cursors.Hand;
            btnErtele.FlatStyle = FlatStyle.Popup;
            btnErtele.Location = new Point(261, 145);
            btnErtele.Margin = new Padding(3, 2, 3, 2);
            btnErtele.Name = "btnErtele";
            btnErtele.Size = new Size(64, 18);
            btnErtele.TabIndex = 3;
            btnErtele.Text = "Ertele";
            btnErtele.UseVisualStyleBackColor = false;
            btnErtele.Click += btnErtele_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Orange;
            dateTimePicker1.CalendarTitleBackColor = Color.Orange;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(152, 54);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 21);
            dateTimePicker1.TabIndex = 4;
            // 
            // trackBarSes
            // 
            trackBarSes.Cursor = Cursors.SizeWE;
            trackBarSes.Location = new Point(30, 178);
            trackBarSes.Margin = new Padding(3, 2, 3, 2);
            trackBarSes.Name = "trackBarSes";
            trackBarSes.Size = new Size(89, 45);
            trackBarSes.TabIndex = 6;
            trackBarSes.Scroll += trackBarSes_Scroll;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 143);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 21);
            textBox1.TabIndex = 7;
            textBox1.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 234);
            label1.Name = "label1";
            label1.Size = new Size(41, 12);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // kalanSureTimer
            // 
            kalanSureTimer.Tick += kalanSureTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(113, 12);
            label2.TabIndex = 9;
            label2.Text = "Alarm Saati Ayarla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 148);
            label3.Name = "label3";
            label3.Size = new Size(41, 12);
            label3.TabIndex = 10;
            label3.Text = "Dakika";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 164);
            label4.Name = "label4";
            label4.Size = new Size(119, 12);
            label4.TabIndex = 11;
            label4.Text = "Ses Seviyesi Ayarla";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 234);
            label5.Name = "label5";
            label5.Size = new Size(157, 12);
            label5.TabIndex = 12;
            label5.Text = "Alarm Çalmasına Kalan Süre";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(381, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(22, 19);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(358, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(22, 19);
            button2.TabIndex = 14;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(405, 270);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(trackBarSes);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnErtele);
            Controls.Add(btnSesSec);
            Controls.Add(btnDurdur);
            Controls.Add(btnAlarmKur);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Alarm V3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarSes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Timer alarmButonTimer;
        private Button btnAlarmKur;
        private Button btnDurdur;
        private Button btnSesSec;
        private Button btnErtele;
        private DateTimePicker dateTimePicker1;
        private TrackBar trackBarSes;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer kalanSureTimer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
