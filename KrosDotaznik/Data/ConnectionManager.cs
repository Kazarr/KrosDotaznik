using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConnectionManager
    {
        public DataTable GetAllAccessData(string command)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = Properties.SettingsAccess.Default.ConnString;
            connection.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.CommandText = command;
            dbCommand.Connection = connection;
            OleDbDataAdapter oleDbData = new OleDbDataAdapter(dbCommand);
            DataSet ds = new DataSet();
            oleDbData.Fill(ds);
            return ds.Tables[0];
        }
    }
}
