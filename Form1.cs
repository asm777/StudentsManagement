﻿using System;
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
            button1.BackColor = Color.Yellow;
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
            //Менеджер плиток лезет в БД и получает список уроков за отображаемый период
            //Дальше менеджер настраивает плитки: нужным плиткам устанавливается размер в соотвествии
            //с длиной урока. В плитку вписывается имя студента. Цвет плитки выбирается в зависимости от
            //дополнительных условий(урок запланирован, проведён, оплачен)
            DateTime dateTime = dateTimePicker1.Value;
            TimeTableActiveTilesManager timeTableActiveTilesManager = new TimeTableActiveTilesManager(dateTime, dbPath);

            int n = timeTableActiveTilesManager.tiles.Count;
            //TODO
            for (int i = 0; i < n; i++)
            {
                //ToDO: работать только с теми плитками, кторіе изменились.
                Tile tile = timeTableActiveTilesManager.tiles[i];
                //TODO  Настройка кнопок, что бы их цвет, размеры и надписи соответствовали
                //соответствующим плиткам

                tilesButtons[i].Left = tile.left;
                tilesButtons[i].Height = tile.height;
                tilesButtons[i].BackColor = tile.color;
                tilesButtons[i].FlatStyle = FlatStyle.Flat;
                tilesButtons[i].FlatAppearance.BorderColor = tile.color;
                tilesButtons[i].Text = tile.text;

                if (!tile.free)
                {
                    tilesButtons[i].FlatStyle = FlatStyle.Flat;
                    tilesButtons[i].FlatAppearance.BorderColor = tile.color;
                    tilesButtons[i].BringToFront();
                }
            }

            //Проставляем вверху даты
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
            DateTime current = dateTimePicker1.Value.AddDays(+7);
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
            DateTime current = dateTimePicker1.Value.AddMonths(+1);
            dateTimePicker1.Value = current;
        }
    }
}


