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
    public partial class Form1 : Form
    {
        LessonsListManager lessonsList;

        private string dbPath = @"C:\Users\user01\source\repos\StudentsManagement\students.db";
        Management management;
        public Form1()
        {
            try
            {
                management = new Management(dbPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Close();
            }
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RestructGreed();
        }

        private void RestructGreed()
        {
            //dataGridViewTimeTable.RowCount = 97;
            //dataGridViewTimeTable.ColumnCount = 22;
            //for (int i = 0; i< dataGridViewTimeTable.ColumnCount; i++)
            //{
            //    DataGridViewColumn column = dataGridViewTimeTable.Columns[i];
            //    column.Width = 50;
            //}
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridViewTimeTable.RowTemplate.Height = 7;
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            StudentsForm form = new StudentsForm(dbPath);
            form.ShowDialog();
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            SubjectsForm form = new SubjectsForm(dbPath);
            form.ShowDialog();
        }

        private void buttonScrollDayForward_Click(object sender, EventArgs e)
        {
            LessonsListManager lessonsListManager = new LessonsListManager(dbPath);
            lessonsListManager.getLessonsList();
        }

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            LessonsForm form = new LessonsForm(dbPath);
            form.ShowDialog();
        }
    }
}
