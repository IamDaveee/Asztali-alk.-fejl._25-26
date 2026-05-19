using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IdopontFogalals
{
    internal class ReservationHelper
    {
        public static List<string> GetUserData(int userId)
        {
            List<string> adatok = new List<string>();
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT idopont.date as datum, idopont.time as idopont, szerelo.name as szereloNeve, szerelo.specialist as spec FROM idopont INNER JOIN szerelo ON idopont.szereloId=szerelo.id WHERE idopont.userId = @userId ORDER BY datum ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adatok.Add($"{Convert.ToDateTime(reader["datum"]).ToString("yyyy-MM-dd")} | {reader["idopont"]} | {reader["szereloNeve"]} | {reader["spec"]}");
                        }
                    }
                }
                return adatok;
            }
        }

        public static void CancelReservation(int userId, int szereloId, string date, string time)
        {
            using (MySqlConnection connection=Database.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM idopont WHERE idopont.userId = @userId AND idopont.szereloId = @szereloId AND idopont.date= @date AND idopont.time = @time";

                using (MySqlCommand cmd=new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@szereloId", szereloId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", time);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
