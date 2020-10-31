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
        List<Button> tilesButtons;
        List<Label> datesLabels;
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
            tilesButtons = getTilesButtonsList();
            datesLabels = getDatesLabels();
        }

        private List<Label> getDatesLabels()
        {
            List<Label> datesLabels = new List<Label>();
            int n = this.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                Control control = this.Controls[i];
                if (control is Label)
                {
                    Label label = (Label)control;
                    if (label.Text.Equals("*"))
                    {
                        datesLabels.Add(label);
                    }
                }
            }

            List<Label> SortedList = datesLabels.OrderBy(l => l.Left).ToList();

            return SortedList;
        }

        private List<Button> getTilesButtonsList()
        {
            List<Button> tilesButtons = new List<Button>();
            int n = this.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                Control control = this.Controls[i];
                if (control is Button)
                {
                    Button button = (Button)control;
                    if (button.Text.Equals("*"))
                    {
                        tilesButtons.Add(button);
                    }
                }
            }
            return tilesButtons;
        }

        private void RefreshTilesTimeTable()
        {
            TimeTableActiveTilesManager timeTableActiveTilesManager = new TimeTableActiveTilesManager(dateTimePicker1.Value);

            int n = timeTableActiveTilesManager.tiles.Count;
            //TODO
            //for (int i=0; i<n; i++)
            //{
            //    Tile tile = timeTableActiveTilesManager.tiles[i];
            //    Button tileButton = tilesButtons[i];
            //    tileButton.Text = tile.text;
            //    tileButton.Top = tile.top;
            //    tileButton.Left = tile.left;
            //    tileButton.Width = tile.width;
            //    tileButton.Height = tile.height;
            //}

            Diapazon diapazon = new Diapazon(dateTimePicker1.Value);
            for (int i = 0; i < datesLabels.Count; i++)
            {
                DateTime current = diapazon[i];
                string s = current.ToString("dd/MM");
                datesLabels[i].Text = s;
                datesLabels[i].ForeColor = Color.Black;
                if (current.Day== dateTimePicker1.Value.Day)
                {
                    datesLabels[i].ForeColor = Color.DarkOrange;
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshTilesTimeTable();
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
            DateTime current = dateTimePicker1.Value.AddDays(-7);
            dateTimePicker1.Value = current;
        }

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            LessonsForm form = new LessonsForm(dbPath);
            form.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshTilesTimeTable();
        }

        private void buttonScrollWeekBack_Click(object sender, EventArgs e)
        {
            DateTime current = dateTimePicker1.Value.AddDays(-7);
            dateTimePicker1.Value = current;
        }

        private void buttonScrollMonthBack_Click(object sender, EventArgs e)
        {
            DateTime current = dateTimePicker1.Value.AddMonths(-1);
            dateTimePicker1.Value = current;
        }

        private void buttonScrollMonthForward_Click(object sender, EventArgs e)
        {
            DateTime current = dateTimePicker1.Value.AddMonths(1);
            dateTimePicker1.Value = current;
        }
    }
}


