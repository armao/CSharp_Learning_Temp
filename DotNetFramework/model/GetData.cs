using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class GetData
    {
        static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GameConnection"].ConnectionString);
        SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
        SqlDataReader sqlDataReader;

        SqlDataAdapter adapter = new SqlDataAdapter("", sqlConnection);
        DataSet dataSet = new DataSet();
        DataTable dataTable = new DataTable();

        public DataTable TableQuery(string query)
        {
            adapter.SelectCommand.CommandText = query;
            adapter.Fill(dataSet);

            dataTable = dataSet.Tables[0];

            return dataTable;
        }
        public DataTable TableQuery(string query, List<SqlParameter> sqlParameter)
        {
            adapter.SelectCommand.CommandText = query;

            foreach (SqlParameter parameter in sqlParameter)
            {
                adapter.SelectCommand.Parameters.Add(parameter);
            }

            adapter.Fill(dataSet);

            dataTable = dataSet.Tables[0];

            return dataTable;
        }

        public SqlDataReader LoginQuery(string sql, List<SqlParameter> sqlParameters)
        {
            sqlCommand.CommandText = sql;
            foreach (SqlParameter parameter in sqlParameters)
            {
                sqlCommand.Parameters.Add(parameter);
            }
            sqlConnection.Open();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                sqlDataReader.Read();
            }
            catch
            {
                sqlConnection.Close();
            }

            return sqlDataReader;
        }



    }
}
