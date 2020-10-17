using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace StudentsManagement
{
    class ConnectionsKeeper
    {
        private static Dictionary<string, SQLiteConnection> connections;

        public static SQLiteConnection getConnection(string path)
        {
            if (connections == null)
            {
                connections = new Dictionary<string, SQLiteConnection>();
            }

            SQLiteConnection connection = null;
            try
            {
                connection = connections[path];
            }
            catch (KeyNotFoundException ex)
            {

                if (!File.Exists(path))
                {
                    throw new Exception("Database not found");
                }
                connection = new SQLiteConnection($"Data Source={path}; Version=3;");
                connection.Open();
                connections.Add(path, connection);
            }

            return connection;
        }
    }
}
