using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BaltbetWCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        #region Подключение к БД
        SqlConnection conn;
        SqlCommand comm;
        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDB()
        {
            connStringBuilder = new SqlConnectionStringBuilder();

            connStringBuilder.DataSource = @"LKPC\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "Baltbet";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;
            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }
        public Service1()
        {
            ConnectToDB();
        }
        #endregion

        // Запрос игроков из БД
        public List<Players> GetPlayers()
        {
            List<Players> TablePlayers = new List<Players>();
            try
            {
                comm.CommandText = "SELECT * FROM PlayersDB";
                comm.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader sqlData = comm.ExecuteReader();
                while (sqlData.Read())
                {
                    Players player = new Players();
                    player.Id = Convert.ToInt32(sqlData["id"]);
                    player.Surname = sqlData["Surname"].ToString();
                    player.Name = sqlData["Name"].ToString();
                    player.Patronymic = sqlData["Patronymic"].ToString();
                    player.Birth = sqlData["Birth"].ToString();
                    player.Balance = Convert.ToDouble(sqlData["Balance"]);
                    TablePlayers.Add(player);
                }
                return TablePlayers;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null) conn.Close();
            }

        }
        
        // Запрос ставок из БД
        public List<Bets> GetBets(string Command_Text)
        {
            List<Bets> BetsFromDB = new List<Bets>();
            
            try
            {                
                comm.CommandText = Command_Text;                
                comm.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader sqlData = comm.ExecuteReader();

                while (sqlData.Read())
                {
                    Bets row = new Bets();
                    row.Id = Convert.ToInt32(sqlData["Id"]);
                    row.IdClient = Convert.ToInt32(sqlData["IdClien"]);
                    row.Date = sqlData["Date"].ToString();
                    row.Summ = Convert.ToDouble(sqlData["Summ"]);
                    row.Ratio = Convert.ToDouble(sqlData["Ratio"]);
                    row.Result = Convert.ToInt32(sqlData["Result"]);
                    row.Prise = Convert.ToDouble(sqlData["Prise"]);
                    BetsFromDB.Add(row);
                }

                return BetsFromDB;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null) conn.Close();
            }

        }

        // Загрузка ставки в БД
        public int LoadBet(Bets bet)
        {
            try
            {
                comm.CommandText = "INSERT INTO BetsDB VALUES " +
                    "(@IdClien, " +
                    "@Date, " +
                    "@Summ, " +
                    "@Ratio, " +
                    "@Result, " +
                    "@Prise)";
                comm.Parameters.AddWithValue("IdClien", bet.IdClient);
                comm.Parameters.AddWithValue("Date", bet.Date);
                comm.Parameters.AddWithValue("Summ", bet.Summ);
                comm.Parameters.AddWithValue("Ratio", bet.Ratio);
                comm.Parameters.AddWithValue("Result", bet.Result);
                comm.Parameters.AddWithValue("Prise", bet.Prise);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();                              
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        // Коррекция баланса
        public void UpdateBalance(Players player)
        {
            try
            {
                comm.CommandText = "UPDATE PlayersDB SET Balance = @Balance WHERE Id = @Id";
                comm.Parameters.AddWithValue("Balance", player.Balance);
                comm.Parameters.AddWithValue("Id", player.Id);

                comm.CommandType = CommandType.Text;
                conn.Open();

                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
