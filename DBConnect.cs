using System;
using System.Data.SqlClient;

namespace BlueTeamProject
{
    internal class DBConnect
        {
        static string constr;
        static SqlConnection conn;

        public static void Connect()
        {
            constr = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Database;Integrated Security=True;Pooling=False;Connect Timeout=30";
            conn = new SqlConnection(constr);
            conn.Open();
        }

        public static void Close()
        {
            conn.Close();
        }
    }
}
