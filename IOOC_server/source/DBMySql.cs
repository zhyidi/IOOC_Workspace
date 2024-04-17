using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace IOOC.source
{
    public class DBMySql
    {
        /*
         * 功能：建立连接
         */
        public static MySqlConnection Connection()
        {
            String connStr = "server=127.0.0.1;port=3306;user=root;password=root; database=iooc_hospital;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }

        /*
         * 功能：sql查询，返回结果集；
         */
        //public static MySqlDataReader findValue(String sql)
        //{
        //    MySqlConnection conn = Connection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    MySqlDataReader reader = null;
        //    try
        //    {
        //        reader = cmd.ExecuteReader();

        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    conn.CloseAsync();
        //    return reader;
        //}

        /*
         * 功能：sql查询，返回结果集de字符串(以空格隔开)；
         */
        public static DataTable findValue_data_table(String sql)
        {
            MySqlConnection conn = Connection();
            DataTable dt = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                DataSet ds = new DataSet();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                msda.Fill(ds, "table");
                dt = ds.Tables["table"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.CloseAsync();
            return dt;
        }

        /*
         * 功能：sql查询，返回结果集de字符串(以空格隔开)；
         */
        public static string findValue_string(String sql)
        {
            MySqlConnection conn = Connection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            string ans = "";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        ans = String.Concat(ans, reader[i].ToString(), " ");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.CloseAsync();
            ans = ans.Trim();
            if (ans.Equals(""))
            {
                return "!!!";
            }
            return ans;
        }
        /*
         * 功能：sql查询，返回结果集第一行第一列的元素；
         */
        //public static String findOneValue(String sql)
        //{
        //    MySqlConnection conn = Connection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    object reader = null;
        //    try
        //    {
        //        reader = cmd.ExecuteScalar();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    conn.CloseAsync();
        //    if (reader != null)
        //    {
        //        return reader.ToString();
        //    }
        //    return "!!!";
        //}

        /*
         * 功能：sql更新、删除、插入，不返回；
         */
        public static int Executevoid(String sql)
        {
            MySqlConnection conn = Connection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.CloseAsync();
            return result;
        }

    }

}
