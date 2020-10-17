namespace StudentsManagement
{
    partial class StudentsForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone1 = new System.Windows.Forms.TextBox();
            this.textBoxPhone2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhone5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhone4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelAll = new System.Windows.Forms.Button();
            this.buttonClearPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 589);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of students";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(365, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student name (and family name)";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(368, 101);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(259, 20);
            this.dateTimePickerBirthday.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthday";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxStudent.Location = new System.Drawing.Point(633, 26);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(155, 188);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 6;
            this.pictureBoxStudent.TabStop = false;
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Location = new System.Drawing.Point(633, 220);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(79, 23);
            this.buttonLoadPicture.TabIndex = 7;
            this.buttonLoadPicture.Text = "Load picture";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone 1";
            // 
            // textBoxPhone1
            // 
            this.textBoxPhone1.Location = new System.Drawing.Point(368, 154);
            this.textBoxPhone1.Name = "textBoxPhone1";
            this.textBoxPhone1.Size = new System.Drawing.Size(203, 20);
            this.textBoxPhone1.TabIndex = 9;
            // 
            // textBoxPhone2
            // 
            this.textBoxPhone2.Location = new System.Drawing.Point(368, 194);
            this.textBoxPhone2.Name = "textBoxPhone2";
            this.textBoxPhone2.Size = new System.Drawing.Size(203, 20);
            this.textBoxPhone2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone 2";
            // 
            // textBoxPhone3
            // 
            this.textBoxPhone3.Location = new System.Drawing.Point(368, 237);
            this.textBoxPhone3.Name = "textBoxPhone3";
            this.textBoxPhone3.Size = new System.Drawing.Size(203, 20);
            this.textBoxPhone3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone 3";
            // 
            // textBoxPhone5
            // 
            this.textBoxPhone5.Location = new System.Drawing.Point(368, 328);
            this.textBoxPhone5.Name = "textBoxPhone5";
            this.textBoxPhone5.Size = new System.Drawing.Size(203, 20);
            this.textBoxPhone5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone 5";
            // 
            // textBoxPhone4
            // 
            this.textBoxPhone4.Location = new System.Drawing.Point(368, 281);
            this.textBoxPhone4.Name = "textBoxPhone4";
            this.textBoxPhone4.Size = new System.Drawing.Size(203, 20);
            this.textBoxPhone4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Phone 4";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(368, 372);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(422, 20);
            this.textBoxAddress.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Address";
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Location = new System.Drawing.Point(585, 328);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmail2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "e-mail 2";
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Location = new System.Drawing.Point(585, 281);
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmail1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(585, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "e-mail 1";
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(365, 426);
            this.textBoxRemark.Multiline = true;
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(423, 189);
            this.textBoxRemark.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Remark";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(15, 622);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(371, 622);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(538, 622);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(715, 622);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 29;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelAll
            // 
            this.buttonDelAll.Location = new System.Drawing.Point(139, 622);
            this.buttonDelAll.Name = "buttonDelAll";
            this.buttonDelAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDelAll.TabIndex = 30;
            this.buttonDelAll.Text = "Del All";
            this.buttonDelAll.UseVisualStyleBackColor = true;
            this.buttonDelAll.Click += new System.EventHandler(this.buttonDelAll_Click);
            // 
            // buttonClearPicture
            // 
            this.buttonClearPicture.Location = new System.Drawing.Point(719, 221);
            this.buttonClearPicture.Name = "buttonClearPicture";
            this.buttonClearPicture.Size = new System.Drawing.Size(69, 23);
            this.buttonClearPicture.TabIndex = 31;
            this.buttonClearPicture.Text = "Clear pic";
            this.buttonClearPicture.UseVisualStyleBackColor = true;
            this.buttonClearPicture.Click += new System.EventHandler(this.buttonClearPicture_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.buttonClearPicture);
            this.Controls.Add(this.buttonDelAll);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.textBoxEmail2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEmail1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPhone5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPhone4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPhone3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPhone2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPhone1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLoadPicture);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "StudentsForm";
            this.Text = "Students Management";
            this.Activated += new System.EventHandler(this.StudentsForm_Activated);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhone1;
        private System.Windows.Forms.TextBox textBoxPhone2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhone5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhone4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEmail1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelAll;
        private System.Windows.Forms.Button buttonClearPicture;
    }
}