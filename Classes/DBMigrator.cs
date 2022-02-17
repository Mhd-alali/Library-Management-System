using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Classes
{
    class DbMigrator
    {

        SqlDataReader dataReader;
        DataTable table;
        int rowsEfected;
        string connectionString = "server =.;database =DBAmanos;Integrated Security =false;User ID =sa;password=gamemode;";

        /// <summary>
        /// this function returns the current date of the database
        /// </summary>
        /// <returns>isn't it obvious</returns>
        public DateTime GetDatabaseTime()
        {
            DateTime time = Convert.ToDateTime(SelectString("SELECT GETDATE()"));
            return time;
        }

        public string Execute(string command, List<SqlParameter> parameters)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Count; i++)
                            {
                                sqlCommand.Parameters.Add(parameters[i]);
                            }
                        }
                        rowsEfected = sqlCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return rowsEfected.ToString();
        }

        public string Execute(string command, SqlParameter parameter)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        sqlCommand.Parameters.Add(parameter);
                        rowsEfected = sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return rowsEfected.ToString();
        }

        public async Task<string> ExecuteAsync(string command, List<SqlParameter> parameters)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Count; i++)
                            {
                                sqlCommand.Parameters.Add(parameters[i]);
                            }
                        }
                        rowsEfected = await sqlCommand.ExecuteNonQueryAsync();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DBmigrate");
                Debugger.Break();

            }

            return rowsEfected.ToString();
        }

        public DataTable SelectDataTable(string command)
        {
            table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();
                        dataReader = sqlCommand.ExecuteReader();
                        table.Load(dataReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return table;
        }

        public DataTable SelectDataTable(string command, SqlParameter parameter)
        {
            table = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        cmd.Parameters.Add(parameter);
                        dataReader = cmd.ExecuteReader();
                        table.Load(dataReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return table;
        }

        public DataTable SelectDataTable(string command, List<SqlParameter> parameters)
        {
            table = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Count; i++)
                            {
                                cmd.Parameters.Add(parameters[i]);
                            }

                        }
                        dataReader = cmd.ExecuteReader();
                        table.Load(dataReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return table;
        }

        public async Task<DataTable> SelectDataTableAsync(string command)
        {
            table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();
                        dataReader = await sqlCommand.ExecuteReaderAsync();
                        table.Load(dataReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return table;
        }

        public async Task<DataTable> SelectDataTableAsync(string command, SqlParameter parameter)
        {
            table = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        cmd.Parameters.Add(parameter);
                        dataReader = await cmd.ExecuteReaderAsync();
                        table.Load(dataReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return table;
        }

        public async Task<DataTable> SelectDataTableAsync(string command, List<SqlParameter> parameters)
        {
            table = new DataTable();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(command, cn))
                    {
                        cn.Open();
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Count; i++)
                            {
                                cmd.Parameters.Add(parameters[i]);
                            }

                        }
                        dataReader = await cmd.ExecuteReaderAsync();
                        table.Load(dataReader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return table;
        }

        public string SelectString(string command)
        {
            string result = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();

                        result = sqlCommand.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();

            }
            return result;
        }

        public async Task<string> SelectStringAsync(string command)
        {
            string result = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();

                        result = Convert.ToString(await sqlCommand.ExecuteScalarAsync());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return result;
        }

        public int SelectInt(string command)
        {
            int result = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();

                        result = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return result;
        }

        public async Task<int> selectIntAsync(string commnand)
        {
            int result = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(commnand, connection))
                    {
                        connection.Open();

                        result = Convert.ToInt32(await sqlCommand.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return result;
        }

        public bool SelectBool(string command)
        {
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();

                        result = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return result;
        }

        public async Task<byte[]> SelectDataAsync(string command)
        {
            byte[] result = { };
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                    {
                        connection.Open();
                        result = (byte[])await sqlCommand.ExecuteScalarAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dbmigrate");
                Debugger.Break();
            }
            return result;
        }

    }
}
