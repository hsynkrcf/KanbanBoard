using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.DAL
{
    class Helper
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Helper()
        {
            conn = new SqlConnection(Properties.Settings.Default.KanbanBoardDB);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public void AddParametersToCommand(List<SqlParameter> paramList)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paramList.ToArray());
        }
        public int MyExecuteQuery(string query)
        {
            cmd.CommandText = query;
            int result = 0;
            try
            {
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = -1;
                string me = (ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public T MyExecuteScalar<T>(string query)
        {
            T returnValue;
            cmd.CommandText = query;
            conn.Open();
            returnValue = (T)cmd.ExecuteScalar();
            conn.Close();
            return returnValue;
        }
        public SqlDataReader MyExecuteReader(string query)
        {
            cmd.CommandText = query;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }
    }
}