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
            string cs = ConfigurationManager.ConnectionStrings["Contrataciones"]?.ConnectionString;
            if (string.IsNullOrEmpty(cs))
                throw new InvalidOperationException("Connection string 'Contrataciones' not found.");

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.ConnectionString = cs;
                sqlConnection.Open();
            }
        }

        private void Disconnect()
        {
            if (sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        public int Write(string spName, SqlParameter[] parameters)
        {
            SqlTransaction transaction = null;

            try
            {
                Connect();

                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = spName;

                if (parameters != null)
                    sqlCommand.Parameters.AddRange(parameters);
                
                transaction = sqlConnection.BeginTransaction();
                sqlCommand.Transaction = transaction;

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                
                transaction.Commit();
                return rowsAffected;
            }
            catch (Exception)
            {
                try
                {
                    if (transaction != null)
                        transaction.Rollback();
                }
                catch (Exception) { }

                throw;
            }
            finally
            {
                sqlCommand.Transaction = null;
                sqlCommand.Parameters.Clear();
                Disconnect();
            }
        }

        public DataTable Read(string spName, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                Connect();

                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = spName;

                if (parameters != null)
                    sqlCommand.Parameters.AddRange(parameters);
                
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }

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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                Disconnect();
            }
        }
    }
}
