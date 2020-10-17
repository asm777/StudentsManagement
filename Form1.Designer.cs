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
            this.buttonScrollWeekBack = new System.Windows.Forms.Button();
            this.buttonScrollWeekForward = new System.Windows.Forms.Button();
            this.buttonScrollDayBack = new System.Windows.Forms.Button();
            this.buttonScrollDayForward = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(254, 12);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(75, 23);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonScrollWeekBack
            // 
            this.buttonScrollWeekBack.Location = new System.Drawing.Point(13, 13);
            this.buttonScrollWeekBack.Name = "buttonScrollWeekBack";
            this.buttonScrollWeekBack.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollWeekBack.TabIndex = 2;
            this.buttonScrollWeekBack.Text = "<<";
            this.buttonScrollWeekBack.UseVisualStyleBackColor = true;
            // 
            // buttonScrollWeekForward
            // 
            this.buttonScrollWeekForward.Location = new System.Drawing.Point(899, 13);
            this.buttonScrollWeekForward.Name = "buttonScrollWeekForward";
            this.buttonScrollWeekForward.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollWeekForward.TabIndex = 3;
            this.buttonScrollWeekForward.Text = ">>";
            this.buttonScrollWeekForward.UseVisualStyleBackColor = true;
            // 
            // buttonScrollDayBack
            // 
            this.buttonScrollDayBack.Location = new System.Drawing.Point(94, 13);
            this.buttonScrollDayBack.Name = "buttonScrollDayBack";
            this.buttonScrollDayBack.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollDayBack.TabIndex = 4;
            this.buttonScrollDayBack.Text = "<";
            this.buttonScrollDayBack.UseVisualStyleBackColor = true;
            // 
            // buttonScrollDayForward
            // 
            this.buttonScrollDayForward.Location = new System.Drawing.Point(818, 13);
            this.buttonScrollDayForward.Name = "buttonScrollDayForward";
            this.buttonScrollDayForward.Size = new System.Drawing.Size(75, 23);
            this.buttonScrollDayForward.TabIndex = 5;
            this.buttonScrollDayForward.Text = ">";
            this.buttonScrollDayForward.UseVisualStyleBackColor = true;
            this.buttonScrollDayForward.Click += new System.EventHandler(this.buttonScrollDayForward_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Location = new System.Drawing.Point(335, 12);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(75, 23);
            this.buttonSubjects.TabIndex = 7;
            this.buttonSubjects.Text = "Subjects";
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Location = new System.Drawing.Point(416, 12);
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
            this.ClientSize = new System.Drawing.Size(989, 621);
            this.Controls.Add(this.buttonLessons);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonScrollDayForward);
            this.Controls.Add(this.buttonScrollDayBack);
            this.Controls.Add(this.buttonScrollWeekForward);
            this.Controls.Add(this.buttonScrollWeekBack);
            this.Controls.Add(this.buttonStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonScrollWeekBack;
        private System.Windows.Forms.Button buttonScrollWeekForward;
        private System.Windows.Forms.Button buttonScrollDayBack;
        private System.Windows.Forms.Button buttonScrollDayForward;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonLessons;
    }
}

