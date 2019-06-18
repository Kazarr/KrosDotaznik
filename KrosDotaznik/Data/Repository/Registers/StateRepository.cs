using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kros.KORM.MsAccess;
using System.Data.OleDb;
using Data.Properties;
using Kros.KORM;
using Kros.KORM.Query;
using Data.Models.Registers;
using System.Data;

namespace Data.Repository.Registers
{
    public class StateRepository
    {        
        public DataTable GetAllState()
        {            
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnString;
            connection.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.CommandText = "Select * from [State]";
            dbCommand.Connection = connection;
            OleDbDataAdapter oleDbData = new OleDbDataAdapter(dbCommand);
            DataSet ds = new DataSet();
            oleDbData.Fill(ds);
            return ds.Tables[0];
            
        }
    }
}
