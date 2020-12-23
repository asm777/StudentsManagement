namespace StudentsManagement
{
    partial class LessonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStudentsNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelLesson = new System.Windows.Forms.Button();
            this.buttonDelAllLessons = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of lessons";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(445, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(563, 139);
            this.numericUpDownDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownDuration.TabIndex = 3;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duration(15 min units):";
            // 
            // comboBoxStudentsNames
            // 
            this.comboBoxStudentsNames.FormattingEnabled = true;
            this.comboBoxStudentsNames.Location = new System.Drawing.Point(448, 177);
            this.comboBoxStudentsNames.Name = "comboBoxStudentsNames";
            this.comboBoxStudentsNames.Size = new System.Drawing.Size(197, 21);
            this.comboBoxStudentsNames.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject";
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(448, 217);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSubjects.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Topic";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(448, 257);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(197, 20);
            this.textBoxTopic.TabIndex = 10;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(448, 283);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPaid.TabIndex = 11;
            this.checkBoxPaid.Text = "Paid";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(593, 283);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDone.TabIndex = 12;
            this.checkBoxDone.Text = "Done";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price (for 15 min unit)";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(563, 306);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownPrice.TabIndex = 14;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(445, 406);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(445, 359);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(200, 20);
            this.textBoxRemark.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Remark";
            // 
            // buttonDelLesson
            // 
            this.buttonDelLesson.Location = new System.Drawing.Point(352, 406);
            this.buttonDelLesson.Name = "buttonDelLesson";
            this.buttonDelLesson.Size = new System.Drawing.Size(75, 23);
            this.buttonDelLesson.TabIndex = 18;
            this.buttonDelLesson.Text = "Del";
            this.buttonDelLesson.UseVisualStyleBackColor = true;
            this.buttonDelLesson.Click += new System.EventHandler(this.buttonDelLesson_Click);
            // 
            // buttonDelAllLessons
            // 
            this.buttonDelAllLessons.Location = new System.Drawing.Point(15, 406);
            this.buttonDelAllLessons.Name = "buttonDelAllLessons";
            this.buttonDelAllLessons.Size = new System.Drawing.Size(75, 23);
            this.buttonDelAllLessons.TabIndex = 19;
            this.buttonDelAllLessons.Text = "Del all";
            this.buttonDelAllLessons.UseVisualStyleBackColor = true;
            this.buttonDelAllLessons.Click += new System.EventHandler(this.buttonDelAllLessons_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(501, 406);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 20;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHour.Location = new System.Drawing.Point(445, 70);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(84, 21);
            this.comboBoxHour.TabIndex = 22;
            // 
            // comboBoxMin
            // 
            this.comboBoxMin.FormattingEnabled = true;
            this.comboBoxMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxMin.Location = new System.Drawing.Point(563, 70);
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(82, 21);
            this.comboBoxMin.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Min";
            // 
            // LessonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxMin);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelAllLessons);
            this.Controls.Add(this.buttonDelLesson);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.checkBoxPaid);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStudentsNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "LessonsForm";
            this.Text = "LessonsForm";
            this.Activated += new System.EventHandler(this.LessonsForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStudentsNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelLesson;
        private System.Windows.Forms.Button buttonDelAllLessons;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}