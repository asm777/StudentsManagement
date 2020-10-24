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

        private void RefreshTilesButtons()
        {
            TimeTableActiveTilesManager timeTableActiveTilesManager = new TimeTableActiveTilesManager();
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
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshTilesButtons();
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
