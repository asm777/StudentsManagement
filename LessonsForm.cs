using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagement
{
    public partial class LessonsForm : Form
    {
        private string dbPath;
        private bool needRefresh = true;
        private LessonsListManager lessonsListManager;
        private StudentsListManager studentsListManager;
        private List<StudentInfo> studentInfos;
        private SubjectsListManager stubjectListManager;
        private List<SubjectInfo> subjectInfos;
        private List<LessonInfo> lessonInfos;

        public LessonsForm(string dbPath)
        {
            this.dbPath = dbPath;
            lessonsListManager = new LessonsListManager(dbPath);
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            //dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void RefreshAllInfo()
        {
            studentsListManager = new StudentsListManager(dbPath);
            studentInfos = studentsListManager.getAllStudentsInfo();
            List<string> stulentsNames = studentsListManager.getStudentsNames();
            comboBoxStudentsNames.Items.Clear();
            comboBoxStudentsNames.Text = "";
            comboBoxStudentsNames.Items.AddRange(stulentsNames.ToArray());
            //-------------------------------------------------------------
            stubjectListManager = new SubjectsListManager(dbPath);
            subjectInfos = stubjectListManager.getAllSubjectInfo();
            List<string> subjectsNames = stubjectListManager.getSubjectsNames();
            comboBoxSubjects.Items.Clear();
            comboBoxSubjects.Text = "";
            comboBoxSubjects.Items.AddRange(subjectsNames.ToArray());
            //-------------------------------------------------------------
            lessonInfos = lessonsListManager.getLessonsList();
            listBox1.Items.Clear();
            foreach (var lesInfo in lessonInfos)
            {
                string dateTime = lesInfo.DateAndTime.ToString();
                string studentName = lesInfo.studentInfo.name;
                string subjectName = lesInfo.subjectInfo.name;
                listBox1.Items.Add(dateTime + " " + studentName + " " + subjectName +" "+ lesInfo.done);
            }
            //-------------------------------------------------------------
            dateTimePicker.Value = DateTime.Now;
            numericUpDownDuration.Value = 4;
            comboBoxStudentsNames.SelectedIndex = -1;
            comboBoxSubjects.SelectedIndex = -1;
            textBoxTopic.Text = "";
            checkBoxPaid.Checked = false;
            checkBoxDone.Checked = false;
            numericUpDownPrice.Value = 80;
            textBoxRemark.Text = "";
        }

        private void LessonsForm_Activated(object sender, EventArgs e)
        {
            RefreshAllInfo();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStudentsNames.SelectedIndex == -1) return;
            if (comboBoxSubjects.SelectedIndex == -1) return;
            LessonInfo lessonInfo = new LessonInfo();

            lessonInfo.DateAndTime = dateTimePicker.Value;
            lessonInfo.duration = (int)numericUpDownDuration.Value;
            lessonInfo.studentInfo = studentInfos[comboBoxStudentsNames.SelectedIndex];
            lessonInfo.subjectInfo = subjectInfos[comboBoxSubjects.SelectedIndex];
            lessonInfo.topic = textBoxTopic.Text;
            lessonInfo.done = checkBoxDone.Checked;
            lessonInfo.price = (int)numericUpDownPrice.Value;
            lessonInfo.paid = checkBoxPaid.Checked;
            lessonInfo.remark = textBoxRemark.Text;

            lessonsListManager.AddLesson(lessonInfo);
            RefreshAllInfo();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                //Todo: Clear controls ==> it seems it is not nessesery
                return;
            }
            LessonInfo lessonInfo = lessonInfos[listBox1.SelectedIndex];
            dateTimePicker.Value = lessonInfo.DateAndTime;
            numericUpDownDuration.Value = lessonInfo.duration;
            //------------
            int student_id = lessonInfo.studentInfo.id;
            int idx_stud = -1;
            for (int i=0; i<studentInfos.Count; i++)
            {
                if (studentInfos[i].id == student_id)
                {
                    idx_stud = i;
                }
            }
            comboBoxStudentsNames.SelectedIndex = idx_stud;
            //------------
            int subject_id = lessonInfo.subjectInfo.id;
            int idx_subj = -1;
            for (int i = 0; i < subjectInfos.Count; i++)
            {
                if (subjectInfos[i].id == subject_id)
                {
                    idx_subj = i;
                }
            }
            comboBoxSubjects.SelectedIndex = idx_subj;
            //------------
            textBoxTopic.Text = lessonInfo.topic;
            checkBoxPaid.Checked = lessonInfo.paid;
            checkBoxDone.Checked = lessonInfo.done;
            numericUpDownPrice.Value = lessonInfo.price;
            textBoxRemark.Text = lessonInfo.remark;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelLesson_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) {
                return;
            }

            LessonInfo lessonInfo = lessonInfos[listBox1.SelectedIndex];
            lessonsListManager.DelLesson(lessonInfo);
            RefreshAllInfo();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int SelectedLessonIndex = listBox1.SelectedIndex;
            if (SelectedLessonIndex == -1) return;

            if (comboBoxStudentsNames.SelectedIndex == -1) return;
            if (comboBoxSubjects.SelectedIndex == -1) return;
            //LessonInfo lessonInfo = new LessonInfo();
            LessonInfo lessonInfo = lessonInfos[listBox1.SelectedIndex];

            lessonInfo.DateAndTime = dateTimePicker.Value;
            lessonInfo.duration = (int)numericUpDownDuration.Value;
            lessonInfo.studentInfo = studentInfos[comboBoxStudentsNames.SelectedIndex];
            lessonInfo.subjectInfo = subjectInfos[comboBoxSubjects.SelectedIndex];
            lessonInfo.topic = textBoxTopic.Text;
            lessonInfo.done = checkBoxDone.Checked;
            lessonInfo.price = (int)numericUpDownPrice.Value;
            lessonInfo.paid = checkBoxPaid.Checked;
            lessonInfo.remark = textBoxRemark.Text;

            lessonsListManager.ModifyLesson(lessonInfo);
            RefreshAllInfo();
            listBox1.SelectedIndex = SelectedLessonIndex;
        }

        private void buttonDelAllLessons_Click(object sender, EventArgs e)
        {
            lessonsListManager.DelAllLessons();
            RefreshAllInfo();
        }
    }
}
