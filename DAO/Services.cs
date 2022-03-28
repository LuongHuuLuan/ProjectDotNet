using MySql.Data.MySqlClient;
using ProjectDotNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectDotNet.DAO
{
    public class Services
    {
        public static List<String> getAllHang()
        {
            MySqlConnection conn = Connect.getConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            List<String> result = new List<String>();
            String query = "select * from hangsx";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Connection = conn;
            MySqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                result.Add(data.GetString("TENHANG"));
            }
            conn.Close();
            return result;
        }
        public static List<LaptopInfo> getTop4Product(String hangSX)
        {
            MySqlConnection conn = Connect.getConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            List<LaptopInfo> result = new List<LaptopInfo>();
            String query = "SELECT * FROM thongtinlaptop where HANG = @hangSX LIMIT 4";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Connection = conn;
            command.Parameters.AddWithValue("@hangSX", hangSX);
            MySqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                LaptopInfo model = new LaptopInfo();
                model.MALAPTOP = data.GetString("MALAPTOP");
                model.TENLAPTOP = data.GetString("TENLAPTOP");
                model.HANG = data.GetString("HANG");
                model.GIABAN = data.GetInt32("GIABAN"); ;
                model.SERIES = data.GetString("SERIES");
                model.MAU = data.GetString("MAU");
                model.CPU = data.GetString("CPU");
                model.VGA = data.GetString("VGA");
                model.RAM = data.GetString("RAM");
                model.KICHTHUOCMANHINH = data.GetString("KICHTHUOCMANHINH");
                model.OCUNG = data.GetString("OCUNG");
                model.BANPHIM = data.GetString("BANPHIM");
                model.PIN = data.GetString("PIN");
                model.KHOILUONG = data.GetString("KHOILUONG");
                model.LINKHINH1 = data.GetString("LINKHINH1");
                model.LINKHINH2 = data.GetString("LINKHINH2");
                model.LINKHINH3 = data.GetString("LINKHINH3");
                model.LINKHINH4 = data.GetString("LINKHINH4");
                model.LINKHINH5 = data.GetString("LINKHINH5");
                result.Add(model);
            }
            conn.Close();
            return result;

        }
    }
}