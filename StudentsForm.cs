using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;
//using iGridTreeHelperMethods; // !! <-- Import this namespace to enable the tree helper methods

namespace StudentsManagement
{
    
    public partial class StudentsForm : Form
    {
        bool needRefresh = true;
        private StudentsListManager studentsList;

        public StudentsForm(string dbPath)
        {
            studentsList = new StudentsListManager(dbPath);
            InitializeComponent();
        }

        private void StudentsForm_Activated(object sender, EventArgs e)
        {
            if (needRefresh)
            {
                showStudentsList();
                showStudentInfo();
            }
            needRefresh = true;
        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            int idx = listBox1.SelectedIndex;
            needRefresh = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxStudent.Image = new Bitmap(open.FileName);
                listBox1.SelectedIndex = idx;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            //var col = new DataGridViewMergedTextBoxColumn();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.name = textBoxName.Text;
            studentInfo.birthday = dateTimePickerBirthday.Value;
            studentInfo.phone1 = textBoxPhone1.Text;
            studentInfo.phone2 = textBoxPhone2.Text;
            studentInfo.phone3 = textBoxPhone3.Text;
            studentInfo.phone4 = textBoxPhone4.Text;
            studentInfo.phone5 = textBoxPhone5.Text;
            studentInfo.email1 = textBoxEmail1.Text;
            studentInfo.email2 = textBoxEmail2.Text;
            studentInfo.address = textBoxAddress.Text;
            studentInfo.remark = textBoxRemark.Text;

            if (pictureBoxStudent.Image != null)
            {
                studentInfo.picture = new Bitmap(pictureBoxStudent.Image);
            }

            try
            {
                studentsList.AddStudent(studentInfo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showStudentsList();
        }

        private void buttonDelAll_Click(object sender, EventArgs e)
        {
            studentsList.DelAll();
            showStudentsList();
        }

        private void buttonClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxStudent.Image = null;
        }

        private void showStudentsList()
        {
            try
            {
                listBox1.Items.Clear();
                int n = studentsList.Count;
                for (int i = 0; i < n; i++)
                {
                    StudentInfo studentInfo = studentsList[i];  //!!!!!!!!! 
                    listBox1.Items.Add(studentInfo.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                //---------------------------------
                int idx = listBox1.SelectedIndex;
                StudentInfo studentInfo = studentsList[idx];
                int id = studentInfo.id;

                //---------------------------------
                studentInfo.name = textBoxName.Text;
                studentInfo.birthday = dateTimePickerBirthday.Value;
                studentInfo.phone1 = textBoxPhone1.Text;
                studentInfo.phone2 = textBoxPhone2.Text;
                studentInfo.phone3 = textBoxPhone3.Text;
                studentInfo.phone4 = textBoxPhone4.Text;
                studentInfo.phone5 = textBoxPhone5.Text;
                studentInfo.email1 = textBoxEmail1.Text;
                studentInfo.email2 = textBoxEmail2.Text;
                studentInfo.address = textBoxAddress.Text;
                studentInfo.remark = textBoxRemark.Text;
                if (pictureBoxStudent.Image != null)
                {
                    studentInfo.picture = new Bitmap(pictureBoxStudent.Image);
                }
                else
                {
                    studentInfo.picture = null;
                }

                //---------------------------------
                try
                {
                    studentsList.UpdateStudent(studentInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                showStudentsList();
                showStudentInfo();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int idx = listBox1.SelectedIndex;
                StudentInfo studentInfo = studentsList[idx];
                int id = studentInfo.id;
                studentsList.DelStudent(id);
                showStudentsList();
                showStudentInfo();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStudentInfo();
        }

        private void showStudentInfo()
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    int idx = listBox1.SelectedIndex;
                    StudentInfo studentInfo = studentsList[idx];
                    textBoxName.Text = studentInfo.name;
                    dateTimePickerBirthday.Value = studentInfo.birthday;
                    textBoxPhone1.Text = studentInfo.phone1;
                    textBoxPhone2.Text = studentInfo.phone2;
                    textBoxPhone3.Text = studentInfo.phone3;
                    textBoxPhone4.Text = studentInfo.phone4;
                    textBoxPhone5.Text = studentInfo.phone5;
                    textBoxEmail1.Text = studentInfo.email1;
                    textBoxEmail2.Text = studentInfo.email2;
                    textBoxAddress.Text = studentInfo.address;
                    textBoxRemark.Text = studentInfo.remark;
                    if (studentInfo.picture != null)
                    {
                        pictureBoxStudent.Image = studentInfo.picture;
                    }
                    else
                    {
                        pictureBoxStudent.Image = new Bitmap("cat.png");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBoxName.Text = "";
                dateTimePickerBirthday.Value = DateTime.Now;
                textBoxPhone1.Text = "";
                textBoxPhone2.Text = "";
                textBoxPhone3.Text = "";
                textBoxPhone4.Text = "";
                textBoxPhone5.Text = "";
                textBoxEmail1.Text = "";
                textBoxEmail2.Text = "";
                textBoxAddress.Text = "";
                textBoxRemark.Text = "";
                //string dir = Directory.GetCurrentDirectory();
                pictureBoxStudent.Image = null;
                if (File.Exists("cat.png"))
                {
                    pictureBoxStudent.Image = new Bitmap("cat.png");
                }
            }
        }
    }
}

