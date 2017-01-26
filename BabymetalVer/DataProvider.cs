using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BabymetalVer
{
    public delegate void BabymetalSong(cls_song babymetal);

    class DataProvider
    {
        public static event BabymetalSong babymetal = null;
        static string connectionstring = "Server=localhost;Database=babymetal;Uid=Satan;Pwd=1234;";
        static MySqlConnection m_connection = new MySqlConnection(connectionstring);

        static bool Open()
        {
            m_connection = new MySqlConnection(connectionstring);
            try
            {
                m_connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static bool Close()
        {
            m_connection.Close();
            if (m_connection.State == System.Data.ConnectionState.Closed)
                return true;
            else
                return false;
        }
        #region Update
        public static void UpdateArtikel(cls_song song)
        {
            if (Open())
            {
                string sql = "update tbl_song set Songname = @Songname Songdauer = @Songdauer where id = @id";
                MySqlCommand command = new MySqlCommand(sql, m_connection);

                command.Parameters.Add("@id", MySqlDbType.UInt32).Value = song.ID;
                command.Parameters.Add("@Songname", MySqlDbType.VarChar).Value = song.Songname;
                command.Parameters.Add("@Songdauer", MySqlDbType.DateTime).Value = song.Songdauer;
                command.ExecuteNonQuery();
                Close();
            }
        }
        #endregion
        #region Delete
        public static void DeleteTitel(cls_song song)
        {
            if (Open())
            {
                string sql = "delete from tbl_song where id = @id";
                MySqlCommand command = new MySqlCommand(sql, m_connection);

                command.Parameters.Add("@id", MySqlDbType.UInt32).Value = song.ID;
                command.ExecuteNonQuery();
                Close();
            }
        }
        #endregion
        #region GetAlle
        public static List<cls_song> GetAlleKommentare()
        {
            List<cls_song> songliste = new List<cls_song>();
            if (Open())
            {
                string sql = "Select tbl_song.id, Songname, Songdauer From tbl_song ";
                MySqlCommand command = new MySqlCommand(sql, m_connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cls_song song = new cls_song();
                    song.ID = reader.GetUInt32("ID");
                    song.Songname = reader.GetString("Songname");
                    song.Songdauer = reader.GetDateTime("Songdauer");
                    songliste.Add(song);
                }
                Close();
            }
            else
            {
                throw new Exception("Kann DB nicht öffnen!");
                //return null;
            }
            return songliste;
        }
        #endregion
    }
}
