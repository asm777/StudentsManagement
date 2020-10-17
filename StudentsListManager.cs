using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace StudentsManagement
{
    class StudentsListManager
    {
        SQLiteConnection connection;

        public StudentsListManager(String dbPath)
        {
            connection = ConnectionsKeeper.getConnection(dbPath);
        }

        public StudentInfo this[int i]
        {
            get
            {
                List<StudentInfo> studentInfoList = getAllStudentsInfo();
                return studentInfoList[i];
            }
        }

        public int Count
        {
            get
            {
                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT count(id) FROM students";
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                mStream.Write(blob, 0, blob.Length);
                mStream.Seek(0, SeekOrigin.Begin);

                Bitmap bm = new Bitmap(mStream);
                return bm;
            }
        }
        public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public void AddStudent(StudentInfo studentInfo)
        {
            string commandText = "INSERT INTO students (id, name, birthDay, phone1, phone2, phone3, phone4, phone5," +
                                                        "email1, email2, address, remark, picture) " +
                "VALUES (@id, @name, @birthDay, @phone1, @phone2, @phone3, @phone4, @phone5, " +
                        "@email1, @email2, @address, @remark, @picture)";
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@id", null);
            Command.Parameters.AddWithValue("@name", studentInfo.name);
            Command.Parameters.AddWithValue("@birthDay", studentInfo.birthday.ToString());
            Command.Parameters.AddWithValue("@phone1", studentInfo.phone1);
            Command.Parameters.AddWithValue("@phone2", studentInfo.phone2);
            Command.Parameters.AddWithValue("@phone3", studentInfo.phone3);
            Command.Parameters.AddWithValue("@phone4", studentInfo.phone4);
            Command.Parameters.AddWithValue("@phone5", studentInfo.phone5);
            Command.Parameters.AddWithValue("@email1", studentInfo.email1);
            Command.Parameters.AddWithValue("@email2", studentInfo.email2);
            Command.Parameters.AddWithValue("@address", studentInfo.address);
            Command.Parameters.AddWithValue("@remark", studentInfo.remark);

            if (studentInfo.picture != null)
            {
                byte[] pic = ImageToByte(studentInfo.picture, System.Drawing.Imaging.ImageFormat.Jpeg);
                SQLiteParameter param = new SQLiteParameter("@picture", System.Data.DbType.Binary);
                param.Value = pic;
                Command.Parameters.Add(param);
            }
            else
            {
                Command.Parameters.AddWithValue("@picture", null);
            }

            Command.ExecuteNonQuery();
        }

        public void UpdateStudent(StudentInfo studentInfo)
        {
            //id=@id,
            string commandText = "UPDATE students SET name=@name, birthDay=@birthDay, " +
                "phone1=@phone1, phone2=@phone2, phone3=@phone3, phone4=@phone4, phone5=@phone5, " +
                "email1=@email1, email2=@email2, address=@address, remark=@remark, picture=@picture " +
                "WHERE id=@id;";

            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.Parameters.AddWithValue("@id", studentInfo.id);
            Command.Parameters.AddWithValue("@name", studentInfo.name);
            Command.Parameters.AddWithValue("@birthDay", studentInfo.birthday.ToString());
            Command.Parameters.AddWithValue("@phone1", studentInfo.phone1);
            Command.Parameters.AddWithValue("@phone2", studentInfo.phone2);
            Command.Parameters.AddWithValue("@phone3", studentInfo.phone3);
            Command.Parameters.AddWithValue("@phone4", studentInfo.phone4);
            Command.Parameters.AddWithValue("@phone5", studentInfo.phone5);
            Command.Parameters.AddWithValue("@email1", studentInfo.email1);
            Command.Parameters.AddWithValue("@email2", studentInfo.email2);
            Command.Parameters.AddWithValue("@address", studentInfo.address);
            Command.Parameters.AddWithValue("@remark", studentInfo.remark);

            if (studentInfo.picture != null)
            {
                byte[] pic = ImageToByte(studentInfo.picture, System.Drawing.Imaging.ImageFormat.Jpeg);
                SQLiteParameter param = new SQLiteParameter("@picture", System.Data.DbType.Binary);
                param.Value = pic;
                Command.Parameters.Add(param);
            }
            else
            {
                Command.Parameters.AddWithValue("@picture", null);
            }

            Command.ExecuteNonQuery();
        }

        public void DelStudent(int id)
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM students WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery(); // выполнить запрос;
        }

        public void DelAll()
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM students";
            cmd.ExecuteNonQuery(); // выполнить запрос;
        }

        public List<StudentInfo> getAllStudentsInfo()
        {
            List<StudentInfo> studentInfoList = new List<StudentInfo>();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM students;";
            SQLiteDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                StudentInfo studentInfo = new StudentInfo();
                studentInfo.id = Convert.ToInt32(sqlReader["id"].ToString());
                studentInfo.name = sqlReader["name"].ToString();

                var pictureRef = sqlReader["picture"];
                if (!(pictureRef is System.DBNull))
                {
                    byte[] bytImage = (byte[])sqlReader["picture"];
                    studentInfo.picture = ByteToImage(bytImage);
                }
                else
                {
                    studentInfo.picture = null;
                }

                string s = sqlReader["birthDay"].ToString();

                studentInfo.birthday = Convert.ToDateTime(sqlReader["birthDay"].ToString());

                studentInfo.phone1 = sqlReader["phone1"].ToString();
                studentInfo.phone2 = sqlReader["phone2"].ToString();
                studentInfo.phone3 = sqlReader["phone3"].ToString();
                studentInfo.phone4 = sqlReader["phone4"].ToString();
                studentInfo.phone5 = sqlReader["phone5"].ToString();

                studentInfo.address = sqlReader["address"].ToString();
                studentInfo.email1 = sqlReader["email1"].ToString();
                studentInfo.email2 = sqlReader["email2"].ToString();
                studentInfo.remark = sqlReader["remark"].ToString();

                studentInfoList.Add(studentInfo);
            }

            return studentInfoList;
        }

        public StudentInfo getStudentInfoById(int id)
        {
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM students WHERE id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                StudentInfo studentInfo = new StudentInfo();
                studentInfo.id = Convert.ToInt32(sqlReader["id"].ToString());
                studentInfo.name = sqlReader["name"].ToString();

                var pictureRef = sqlReader["picture"];
                if (!(pictureRef is System.DBNull))
                {
                    byte[] bytImage = (byte[])sqlReader["picture"];
                    studentInfo.picture = ByteToImage(bytImage);
                }
                else
                {
                    studentInfo.picture = null;
                }

                string s = sqlReader["birthDay"].ToString();

                studentInfo.birthday = Convert.ToDateTime(sqlReader["birthDay"].ToString());

                studentInfo.phone1 = sqlReader["phone1"].ToString();
                studentInfo.phone2 = sqlReader["phone2"].ToString();
                studentInfo.phone3 = sqlReader["phone3"].ToString();
                studentInfo.phone4 = sqlReader["phone4"].ToString();
                studentInfo.phone5 = sqlReader["phone5"].ToString();

                studentInfo.address = sqlReader["address"].ToString();
                studentInfo.email1 = sqlReader["email1"].ToString();
                studentInfo.email2 = sqlReader["email2"].ToString();
                studentInfo.remark = sqlReader["remark"].ToString();
                return studentInfo;
            }
            throw new Exception("StudentsManagement.getStudentInfoById(id) - Error: Unknown student id");
        }
        public List<string> getStudentsNames()
        {
            List<string> names = new List<string>();
            List<StudentInfo> studentInfos = getAllStudentsInfo();
            foreach (StudentInfo studentInfo in studentInfos)
            {
                names.Add(studentInfo.name);
            }
            return names;
        }
    }


    struct StudentInfo
    {
        public int id { set; get; }
        public string name { set; get; }
        public DateTime birthday { set; get; }
        public string phone1 { set; get; }
        public string phone2 { set; get; }
        public string phone3 { set; get; }
        public string phone4 { set; get; }
        public string phone5 { set; get; }
        public string email1 { set; get; }
        public string email2 { set; get; }
        public string address { set; get; }
        public string remark { set; get; }
        public Bitmap picture { set; get; }
    }
}


