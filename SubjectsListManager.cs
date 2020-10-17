using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace StudentsManagement
{
    class SubjectsListManager
    {
        SQLiteConnection connection;

        public SubjectsListManager(String dbPath)
        {
            connection = ConnectionsKeeper.getConnection(dbPath);
        }

        public int Count
        {
            get
            {
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT count(id) FROM subjects";
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        public SubjectInfo this[int i]
        {
            get
            {
                List<SubjectInfo> subjectInfoList = getAllSubjectInfo();
                return subjectInfoList[i];
            }
        }

        public void AddSubject(SubjectInfo subjectInfo)
        {
            string commandText = "INSERT INTO subjects (id, name, remark) " +
                "VALUES (@id, @name, @remark)";
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@id", null);
            Command.Parameters.AddWithValue("@name", subjectInfo.name);
            Command.Parameters.AddWithValue("@remark", subjectInfo.remark);
            Command.ExecuteNonQuery();
        }

        public void UpdateSubject(SubjectInfo studentInfo)
        {
            //id=@id,
            string commandText = "UPDATE subjects SET name=@name, remark=@remark " +
                "WHERE id=@id;";

            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@id", studentInfo.id);
            Command.Parameters.AddWithValue("@name", studentInfo.name);
            Command.Parameters.AddWithValue("@remark", studentInfo.remark);
            
            Command.ExecuteNonQuery();
        }

        public void DelSubject(int id)
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM subjects WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery(); // выполнить запрос;
        }

        public void DelAll()
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM subjects";
            cmd.ExecuteNonQuery(); // выполнить запрос;
        }

        public List<SubjectInfo> getAllSubjectInfo()
        {
            List<SubjectInfo> subjectInfoList = new List<SubjectInfo>();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM subjects;";
            SQLiteDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                SubjectInfo subjectInfo = new SubjectInfo();

                subjectInfo.id = Convert.ToInt32(sqlReader["id"].ToString());
                subjectInfo.name = sqlReader["name"].ToString();
                subjectInfo.remark = sqlReader["remark"].ToString();

                subjectInfoList.Add(subjectInfo);
            }

            return subjectInfoList;
        }

        public SubjectInfo getSubjectInfoById(int id)
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM subjects WHERE id={id};";
            SQLiteDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                SubjectInfo subjectInfo = new SubjectInfo();

                subjectInfo.id = Convert.ToInt32(sqlReader["id"].ToString());
                subjectInfo.name = sqlReader["name"].ToString();
                subjectInfo.remark = sqlReader["remark"].ToString();

                return subjectInfo;
            }

            throw new Exception("SubjectsListManager.getAllSubjectInfo(id) - Error: Unknown subject id");
        }
        public List<string> getSubjectsNames()
        {
            List<string> names = new List<string>();
            List<SubjectInfo> subjectsInfos = getAllSubjectInfo();
            foreach (SubjectInfo subjectInfo in subjectsInfos)
            {
                names.Add(subjectInfo.name);
            }
            return names;
        }
    }

    struct SubjectInfo
    {
        public int id { set; get; }
        public string name { set; get; }
        public string remark { set; get; }
    }
}
