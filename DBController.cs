using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace BlueTeamProject
{
    internal class DBController
        {
        static string constr;
        static SqlConnection conn;

        public static void Connect()
        {
            constr = @"Data Source=DESKTOP-U3Q7T4N\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine(conn.State);
        }

        public static void insertUser(string username, string password_hash, string security1_hash, string security2_hash, string security3_hash, int isManager)
        {
            Connect();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            sql = "insert into [dbo].[Account](username, password_hash, security1_hash, security2_hash, security3_hash, isManager) values('"+username+"', '"+password_hash+"', '"+security1_hash+"', '"+security2_hash+"', '"+security3_hash+"', "+isManager+")";
            cmd = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public static User getUser(string username)
        {
            Connect();
            SqlCommand cmd;
            SqlDataReader reader;

            string sql;
            User user = new User();
            sql = "Select * from [dbo].[Account] where username like '" + username + "'";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.account_id = reader.GetInt32(0);
                user.username = reader.GetString(5);
                user.password_hash = reader.GetString(1);
                user.security1_hash = reader.GetString(2);
                user.security2_hash = reader.GetString(3);
                user.security3_hash = reader.GetString(4);
                user.isManager = reader.GetInt32(6);
            }
            reader.Close();
            cmd.Dispose();
            conn.Close();
            return user;
        }

        public static void updatePassword(string username, string password_hash)
        {
            Connect();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            sql = "update [dbo].[Account] set password_hash='"+password_hash+"' where username='"+username+"'";
            cmd = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public static void insertItem(string item_name, float item_minimum, float item_units, float unit_price, string manufacturer, string description, byte isManchine)
        {
            Connect();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;

            sql = "insert into [dbo].[Item](item_name, item_minimum, item_units, unit_price, manufacturer, description, isManchine) values('"+item_name+"','"+ item_minimum+"', '"+item_units+"', '"+unit_price+"', '"+manufacturer+"', '"+description+"', "+isManchine+")";
            cmd = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public static Item viewItem(int id)
        {
            Connect();
            SqlCommand cmd;
            SqlDataReader reader;

            string sql;
            Item item = new Item();
            sql = "Select * from [dbo].[Item] where id="+id;
            cmd=new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                item.id = id;    
                item.item_minimum = reader.GetDecimal(1);
                item.item_units = reader.GetDecimal(2);
                item.item_price = reader.GetDecimal(3);
                item.manufacturer = reader.GetString(4);
                item.item_name = reader.GetString(5);
                item.description = reader.GetString(6);
                item.isMachine = reader.GetBoolean(7);
            }
            reader.Close();
            cmd.Dispose();
            conn.Close ();
            return item;
        }

        public static List<Item> viewItems()
        {
            Connect();
            SqlCommand cmd;
            SqlDataReader reader;

            string sql;
            List<Item> items = new List<Item>();
            sql = "Select * from [dbo].[Item]";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                items.Insert(i, new Item());
                items[i].id = reader.GetInt32(0);
                items[i].item_minimum = reader.GetDecimal(1);
                items[i].item_units = reader.GetDecimal(2);
                items[i].item_price = reader.GetDecimal(3);
                items[i].manufacturer = reader.GetString(4);
                items[i].item_name = reader.GetString(5);
                items[i].description = reader.GetString(6);
                items[i].isMachine = reader.GetBoolean(7);
                i++;
            }
            reader.Close();
            cmd.Dispose();
            conn.Close();
            return items;
        }
    }
}