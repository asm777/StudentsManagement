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
    public partial class SubjectsForm : Form
    {
        private SubjectsListManager subjectsList;
        public SubjectsForm(string dbPath)
        {
            subjectsList = new SubjectsListManager(dbPath);
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int idx = listBox1.SelectedIndex;
                SubjectInfo subjectInfo = subjectsList[idx];
                int id = subjectInfo.id;
                subjectsList.DelSubject(id);
                showSubjectsList();
                showSubjectInfo();
            }
        }

        private void showSubjectsList()
        {
            try
            {
                listBox1.Items.Clear();
                int n = subjectsList.Count;
                for (int i = 0; i < n; i++)
                {SubjectInfo subjectInfo = subjectsList[i];
                    listBox1.Items.Add(subjectInfo.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showSubjectInfo()
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    int idx = listBox1.SelectedIndex;
                    SubjectInfo subjectInfo = subjectsList[idx];
                    textBoxName.Text = subjectInfo.name;
                    textBoxRemark.Text = subjectInfo.remark;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBoxName.Text = "";
                textBoxRemark.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SubjectInfo subjectInfo = new SubjectInfo();
            subjectInfo.name = textBoxName.Text;
            subjectInfo.remark = textBoxRemark.Text;

            try
            {
                subjectsList.AddSubject(subjectInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showSubjectsList();
            showSubjectInfo();
        }

        private void buttonDelAll_Click(object sender, EventArgs e)
        {
            subjectsList.DelAll();
            showSubjectsList();
        }

        private void SubjectsForm_Activated(object sender, EventArgs e)
        {
            showSubjectsList();
            showSubjectInfo();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSubjectInfo();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                //---------------------------------
                int idx = listBox1.SelectedIndex;
                SubjectInfo subjectInfo = subjectsList[idx];
                int id = subjectInfo.id;

                //---------------------------------
                subjectInfo.name = textBoxName.Text;
                subjectInfo.remark = textBoxRemark.Text;

                //---------------------------------
                try
                {
                    subjectsList.UpdateSubject(subjectInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                showSubjectsList();
                showSubjectInfo();
            }
        }
    }
}
