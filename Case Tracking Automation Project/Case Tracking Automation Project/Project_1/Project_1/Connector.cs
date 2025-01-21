using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_1
{
    public class DatabaseConnect
    {
        private readonly string host = "localhost";
        private readonly int port = 3306;
        private readonly string dbName = "project_1";
        private readonly string userName = "root";
        private readonly string password = "123456";
        public MySqlConnection myCon;
        private MySqlCommand myCmd;

        public DatabaseConnect()
        {
            Connecting();
        }

        public void Close()
        {
            try
            {
                myCon.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error while closing connection: " + e);
            }

            Console.WriteLine("Database connection closed");
        }

        public void Connecting()
        {
            string connectionString = $"Server={host};Port={port};Database={dbName};Uid={userName};Pwd={password};";
            myCon = new MySqlConnection(connectionString);
            try
            {
                myCon.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error while connecting to database: " + e);
            }
        }

        public DataTable Baglanti(string sorgu)
        {

            Connecting();
            DataTable dt = new DataTable();
            try
            {
                myCmd = new MySqlCommand(sorgu, myCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(myCmd);
                adapter.Fill(dt);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error executing query: " + e);
            }
            return dt;
        }

        public void Ekle(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = myCon;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while inserting data: " + e);
            }
        }


        public object ExecuteScalar(string sorgu)
        {
            object result = null;
            try
            {
                myCmd = new MySqlCommand(sorgu, myCon);
                result = myCmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error executing query: " + e);
            }
            return result;
        }


        public void Sil(string sorgu)
        {
            try
            {
                myCmd = new MySqlCommand(sorgu, myCon);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while deleting data: " + e);
            }
        }
        public void Guncelle(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = myCon;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Veri güncelleme hatası: " + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
