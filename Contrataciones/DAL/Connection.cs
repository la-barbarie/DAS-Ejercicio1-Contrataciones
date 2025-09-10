using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private readonly SqlConnection sqlConnection = new SqlConnection();
        private readonly SqlCommand sqlCommand = new SqlCommand();

        private void Connect()
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Contrataciones"]?.ConnectionString;
            sqlConnection.Open();
        }

        private void Disconnect()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public int Write(string spName, SqlParameter[] parameters)
        {
            int rowsAffected;
            Connect();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = spName;

            if (parameters != null)
            {
                sqlCommand.Parameters.AddRange(parameters);
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            else
            {
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }

            sqlCommand.Parameters.Clear();
            Disconnect();

            return rowsAffected;
        }

        public DataTable Read(string spName, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            Connect();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = spName;

            if (parameters != null)
            {
                sqlCommand.Parameters.AddRange(parameters);
            }


            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dataTable);

            Disconnect();
            return dataTable;
        }

        public int Scalar(string spName, SqlParameter[] parameters)
        {
            try
            {
                Connect();
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = spName;

                if (parameters != null)
                    sqlCommand.Parameters.AddRange(parameters);

                object value = sqlCommand.ExecuteScalar();
                return (value == null || value == DBNull.Value) ? 0 : Convert.ToInt32(value);
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                Disconnect();
            }
        }
    }
}
