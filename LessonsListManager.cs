using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement
{
    class LessonsListManager
    {
        SQLiteConnection connection;
        string dbPath;
        public LessonsListManager(String dbPath)
        {
            connection = ConnectionsKeeper.getConnection(dbPath);
            this.dbPath = dbPath;
        }

        public List<LessonInfo> getLessonsList(DateTime from = new DateTime(), 
            DateTime to = new DateTime(), 
            StudentInfo studentInfo = new StudentInfo(), 
            SubjectInfo subjectInfo = new SubjectInfo())
        {
            List<LessonInfo> list = new List<LessonInfo>();

            //---------------------------------------------
            DateTime def = new DateTime();
            if (to == def)
            {
                to = new DateTime(9999, to.Month, to.Day); 
            }
            //---------------------------------------------

            SQLiteCommand cmd = connection.CreateCommand();
            string query = @"SELECT * FROM lessons WHERE @from <= DateAndTime and DateAndTime <= @to";
            //---------------------------------------------
            StudentInfo def_stud = new StudentInfo();
            if (!studentInfo.Equals(def_stud))
            {
                query += $" and student_id = {studentInfo.id}";
            }
            //---------------------------------------------
            SubjectInfo def_subj = new SubjectInfo();
            if (!subjectInfo.Equals(def_subj))
            {
                query += $" and subject_id = {subjectInfo.id}";
            }
            //---------------------------------------------
            query += ";";
            //---------------------------------------------

            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@from", from.ToString(@"yyyy/MM/dd/ hh:mm:ss"));
            cmd.Parameters.AddWithValue("@to", to.ToString(@"yyyy/MM/dd/ hh:mm:ss"));

            SQLiteDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                LessonInfo lessonInfo = new LessonInfo();

                lessonInfo.id = Convert.ToInt32(sqlReader["id"].ToString());
                //-------------
                string formatString = "yyyyMMddHHmmss";
                string sample = sqlReader["DateAndTime"].ToString();
                string[] words = sample.Split(new char[] {' ', '.', ':'});
                sample = string.Join("", words);
                lessonInfo.DateAndTime = DateTime.ParseExact(sample, formatString, null); 
                //-------------
                lessonInfo.duration = Int32.Parse(sqlReader["duration"].ToString());
                //-------------
                int student_id = Int32.Parse(sqlReader["student_id"].ToString());
                StudentsListManager studentsListManager = new StudentsListManager(dbPath);
                lessonInfo.studentInfo = studentsListManager.getStudentInfoById(student_id);
                //-------------
                int subject_id = Int32.Parse(sqlReader["subject_id"].ToString());
                SubjectsListManager subjectsListManager = new SubjectsListManager(dbPath);
                lessonInfo.subjectInfo = subjectsListManager.getSubjectInfoById(subject_id);
                //-------------
                lessonInfo.topic = sqlReader["topic"].ToString();
                lessonInfo.done = sqlReader["done"].ToString().Equals("0") ? false : true;
                lessonInfo.price = Int32.Parse(sqlReader["price"].ToString());
                lessonInfo.paid = sqlReader["paid"].ToString().Equals("0") ? false : true;
                lessonInfo.remark = sqlReader["remark"].ToString();

                list.Add(lessonInfo);
            }

            return list;
        }

        public void AddLesson(LessonInfo lessonInfo)
        {
            string commandText = "INSERT INTO lessons (id, DateAndTime, duration, student_id, subject_id," +
                                                                  "topic, done, price, paid, remark ) " +
                "VALUES (@id, @DateAndTime, @duration, @student_id, @subject_id, " +
                                                                  "@topic, @done, @price, @paid, @remark)";
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@id", null);
            Command.Parameters.AddWithValue("@DateAndTime", lessonInfo.DateAndTime.ToString(@"yyyy/MM/dd/ hh:mm:ss"));
            Command.Parameters.AddWithValue("@duration", lessonInfo.duration);
            Command.Parameters.AddWithValue("@student_id", lessonInfo.studentInfo.id);
            Command.Parameters.AddWithValue("@subject_id", lessonInfo.subjectInfo.id);
            Command.Parameters.AddWithValue("@topic", lessonInfo.topic);
            Command.Parameters.AddWithValue("@done", lessonInfo.done);
            Command.Parameters.AddWithValue("@price", lessonInfo.price);
            Command.Parameters.AddWithValue("@paid", lessonInfo.paid);
            Command.Parameters.AddWithValue("@remark", lessonInfo.remark);

            Command.ExecuteNonQuery();
        }

        public void DelLesson(LessonInfo lessonInfo)
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM lessons WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", lessonInfo.id);
            cmd.ExecuteNonQuery(); // выполнить запрос;
        }

        public void DelAllLessons()
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM lessons";
            cmd.ExecuteNonQuery(); // выполнить запрос;
        }

        public void ModifyLesson(LessonInfo lessonInfo)
        {
            string commandText = "UPDATE lessons SET DateAndTime=@DateAndTime, " +
                "duration=@duration, student_id=@student_id, subject_id=@subject_id, " +
                "topic=@topic, done=@done, price=@price, paid=@paid, remark=@remark " +
                "WHERE id=@id;";
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@id", lessonInfo.id);
            Command.Parameters.AddWithValue("@DateAndTime", lessonInfo.DateAndTime.ToString(@"yyyy/MM/dd/ hh:mm:ss"));
            Command.Parameters.AddWithValue("@duration", lessonInfo.duration);
            Command.Parameters.AddWithValue("@student_id", lessonInfo.studentInfo.id);
            Command.Parameters.AddWithValue("@subject_id", lessonInfo.subjectInfo.id);
            Command.Parameters.AddWithValue("@topic", lessonInfo.topic);
            Command.Parameters.AddWithValue("@done", lessonInfo.done);
            Command.Parameters.AddWithValue("@price", lessonInfo.price);
            Command.Parameters.AddWithValue("@paid", lessonInfo.paid);
            Command.Parameters.AddWithValue("@remark", lessonInfo.remark);

            Command.ExecuteNonQuery();
        }
    }

    class LessonInfo
    {
        public int id { set; get; }
        public DateTime DateAndTime { set; get; }
        public int duration { set; get; }
        public StudentInfo studentInfo { set; get; }
        public SubjectInfo subjectInfo { set; get; }
        public string topic { set; get; }
        public bool done { set; get; }
        public int price { set; get; }
        public bool paid { set; get; }
        public string remark { set; get; }
    }
}
