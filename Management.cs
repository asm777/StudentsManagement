using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement
{
    class Management
    {
        public Management(string path)
        {
            SQLiteConnection connection = null;
            try
            {
                connection = ConnectionsKeeper.getConnection(path);
            }
            catch (Exception ex1)
            {
                try
                {
                    CreateDB(path);
                }
                catch (Exception ex2)
                {
                    throw new Exception("No data base and can not to create it: " + path);
                }
                connection = ConnectionsKeeper.getConnection(path);
            }
        }

        public static void CreateDB(string path)
        {
            SQLiteConnection.CreateFile(path);
            SQLiteConnection connection = new SQLiteConnection($"Data Source={path}; Version=3;");
            connection.Open(); // открыть соединение

            string commandText = "PRAGMA foreign_keys = ON;";
            SQLiteCommand Command = new SQLiteCommand(commandText, connection);
            Command.ExecuteNonQuery();

            commandText = "CREATE TABLE IF NOT EXISTS students (" + // создать таблицу, если её нет
                     "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                     "name VARCHAR(50)," +
                     "picture BLOB," +
                     "birthDay VARCHAR(50)," +
                     "phone1 VARCHAR(50)," +
                     "phone2 VARCHAR(50)," +
                     "phone3 VARCHAR(50)," +
                     "phone4 VARCHAR(50)," +
                     "phone5 VARCHAR(50)," +
                     "address VARCHAR(50)," +
                     "email1 VARCHAR(50)," +
                     "email2 VARCHAR(50)," +
                     "Remark VARCHAR(50)" +
                     ")";
            Command = new SQLiteCommand(commandText, connection);
            Command.ExecuteNonQuery(); // выполнить запрос

            

            commandText = "CREATE TABLE IF NOT EXISTS subjects (" + // создать таблицу, если её нет
                     "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                     "name VARCHAR(50)," +
                     "Remark VARCHAR(50)" +
                     ")";
            Command = new SQLiteCommand(commandText, connection);
            Command.ExecuteNonQuery(); // выполнить запрос


            commandText = "CREATE TABLE IF NOT EXISTS lessons (" + // создать таблицу, если её нет
                     "id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                     "DateAndTime VARCHAR(50)," + //Когда запланирован и проведён урок
                     "duration INTEGER," + //измеряется в юнитах по 15 минут
                     "student_id INTEGER," +
                     "subject_id INTEGER," +
                     "topic VARCHAR(50)," +
                     "done INTEGER," + //  0/1 - состоялся ли урок(по умолчанию - 0)
                     "price INTEGER," + //за юнит (берём из предыдущего занятия этого студента либо назначается явным образом и все следующие будут уже такими)
                     "paid INTEGER," + //  0/1 - заплачено ли за урок(по умолчанию - 0)
                     "remark VARCHAR(50)," +
                     "FOREIGN KEY (student_id) REFERENCES students(id)," +
                     "FOREIGN KEY (subject_id) REFERENCES subjects(id)" +
                     ")";
            Command = new SQLiteCommand(commandText, connection);
            Command.ExecuteNonQuery(); // выполнить запрос
            connection.Close(); // закрыть соединение
        }
    }
}
