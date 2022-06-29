using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess.ADO
{
    public class MyStoreDataProvider
    {
        private string? ConnectionString { get; set; }
        public MyStoreDataProvider() { }
        public MyStoreDataProvider(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Direction = direction,
                Value = value
            };
        }

        public IDataReader GetDataReader(string commandText, CommandType commandType, out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader? reader;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;

                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }

                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }

        public bool Delete(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;

                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(param);
                    }

                return command.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Data provider: Delete Method ", ex.InnerException);
            }
        }

        public int Insert(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;

                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Update(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;

                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CloseConnection(SqlConnection? connection) => connection?.Close();
    }
}
