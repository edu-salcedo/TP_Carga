using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace DBConnection
{
    public class DBConnection
    {
        private readonly static DBConnection _instance = new DBConnection();
        internal OdbcConnection odbcConnection;
        private OdbcCommand command;
        private OdbcDataReader readed;

        private DBConnection()
        {
            odbcConnection = new OdbcConnection("DSN=DATA");
            odbcConnection.Open();
        }

        public static DBConnection getInstance()
        {
            return _instance;
        }

        public void setComand(String query)
        {
            command = new OdbcCommand(query, odbcConnection);
        }

        public OdbcCommand getComand()
        {
            return command;
        }

        public void ExecuteReader()
        {
            readed = command.ExecuteReader();
        }

        public OdbcDataReader getReaded()
        {
            return readed;
        }
    }
}
