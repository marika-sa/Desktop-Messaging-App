using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopMessageApp1
{
    public class Data
    {
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public static List<T> GetData<T>(string SQL, CommandType cmdType)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                var objProps = Activator.CreateInstance<T>().GetType().GetProperties();
                var returnList = new List<T>();

                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandTimeout = 30000;

                    try
                    {
                        cnn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        var columns = reader.GetSchemaTable().Rows.Cast<DataRow>().Select(row => row["ColumnName"].ToString().ToLower()).ToList();

                        while (reader.Read())
                        {
                            var thisRow = Activator.CreateInstance<T>();
                            foreach (var prop in objProps)
                            {
                                if (columns.Contains(prop.Name.ToLower()))
                                {
                                    if (reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(thisRow, null, null);
                                    }
                                    else
                                    {
                                        prop.SetValue(thisRow, reader[prop.Name], null);
                                    }
                                }
                            }
                            returnList.Add(thisRow);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        if (cnn.State != ConnectionState.Closed)
                        {
                            cnn.Close();
                        }
                    }
                }
                return returnList;
            }
        }


        public static int ExecuteSqlNonQuery(string sql, CommandType cmdType)
        {
            int num = 0;

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        num = cmd.ExecuteNonQuery();
                    }
                }

                return num;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                return num;
            }
        }

        // Retrieves a string value, returns that value in the first column of the first row from the result set.

        public static string ExecuteSqlScaler(string sql, CommandType cmdType)
        {
            string res = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.CommandTimeout = 30000;

                        cnn.Open();

                        var sqlResult = cmd.ExecuteScalar();

                        res = sqlResult.ToString();
                    }
                }

                return res;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                return res;
            }
        }

    }
}
