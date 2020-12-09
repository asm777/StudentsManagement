namespace StudentsManagement
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
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonScrollMonthBack = new System.Windows.Forms.Button();
            this.buttonScrollMonthForward = new System.Windows.Forms.Button();
            this.buttonScrollWeekBack = new System.Windows.Forms.Button();
            this.buttonScrollWeekForward = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(363, 11);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(75, 23);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonScrollMonthBack
            // 
            this.buttonScrollMonthBack.Location = new System.Drawing.Point(45, 12);
            this.buttonScrollMonthBack.Name = "buttonScrollMonthBack";
            this.buttonScrollMonthBack.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollMonthBack.TabIndex = 2;
            this.buttonScrollMonthBack.Text = "<<";
            this.buttonScrollMonthBack.UseVisualStyleBackColor = true;
            this.buttonScrollMonthBack.Click += new System.EventHandler(this.buttonScrollMonthBack_Click);
            // 
            // buttonScrollMonthForward
            // 
            this.buttonScrollMonthForward.Location = new System.Drawing.Point(1116, 12);
            this.buttonScrollMonthForward.Name = "buttonScrollMonthForward";
            this.buttonScrollMonthForward.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollMonthForward.TabIndex = 3;
            this.buttonScrollMonthForward.Text = ">>";
            this.buttonScrollMonthForward.UseVisualStyleBackColor = true;
            this.buttonScrollMonthForward.Click += new System.EventHandler(this.buttonScrollMonthForward_Click);
            // 
            // buttonScrollWeekBack
            // 
            this.buttonScrollWeekBack.Location = new System.Drawing.Point(126, 12);
            this.buttonScrollWeekBack.Name = "buttonScrollWeekBack";
            this.buttonScrollWeekBack.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollWeekBack.TabIndex = 4;
            this.buttonScrollWeekBack.Text = "<";
            this.buttonScrollWeekBack.UseVisualStyleBackColor = true;
            this.buttonScrollWeekBack.Click += new System.EventHandler(this.buttonScrollWeekBack_Click);
            // 
            // buttonScrollWeekForward
            // 
            this.buttonScrollWeekForward.Location = new System.Drawing.Point(1035, 12);
            this.buttonScrollWeekForward.Name = "buttonScrollWeekForward";
            this.buttonScrollWeekForward.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollWeekForward.TabIndex = 5;
            this.buttonScrollWeekForward.Text = ">";
            this.buttonScrollWeekForward.UseVisualStyleBackColor = true;
            this.buttonScrollWeekForward.Click += new System.EventHandler(this.buttonScrollDayForward_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Location = new System.Drawing.Point(444, 11);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(75, 23);
            this.buttonSubjects.TabIndex = 7;
            this.buttonSubjects.Text = "Subjects";
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Location = new System.Drawing.Point(525, 11);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(75, 23);
            this.buttonLessons.TabIndex = 8;
            this.buttonLessons.Text = "Lessons";
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 779);
            this.Controls.Add(this.buttonLessons);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonScrollWeekForward);
            this.Controls.Add(this.buttonScrollWeekBack);
            this.Controls.Add(this.buttonScrollMonthForward);
            this.Controls.Add(this.buttonScrollMonthBack);
            this.Controls.Add(this.buttonStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonScrollMonthBack;
        private System.Windows.Forms.Button buttonScrollMonthForward;
        private System.Windows.Forms.Button buttonScrollWeekBack;
        private System.Windows.Forms.Button buttonScrollWeekForward;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonLessons;
    }
}

