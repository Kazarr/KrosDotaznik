using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MainRepository
    {
        public Dictionary<TKey, TValue> GetAllAccessData<TKey, TValue>(string command,string cultureInfo)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Properties.SettingsAccess.Default.ConnString))
                {
                    connection.Open();
                    try
                    {
                        using(OleDbCommand dbCommand = new OleDbCommand(command,connection))
                        {
                            OleDbDataAdapter oleDbData = new OleDbDataAdapter(dbCommand);
                            DataSet ds = new DataSet();
                            oleDbData.Fill(ds);
                            if (cultureInfo == "sk")
                            {
                                return ds.Tables[0].AsEnumerable().ToDictionary<DataRow, TKey, TValue>(r => r.Field<TKey>(0), r => r.Field<TValue>(1));
                            }
                            else
                            {
                                return ds.Tables[0].AsEnumerable().ToDictionary<DataRow, TKey, TValue>(r => r.Field<TKey>(0), r => r.Field<TValue>(2));
                            }
                        }
                    }
                    catch (OleDbException)
                    {
                        throw;
                    }
                }
            }
            catch (OleDbException)
            {
                throw;
            }            
        }
    }
}
