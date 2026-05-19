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

                string query = "SELECT idopont.date as datum, idopont.time as idopont, szerelo.name as szereloNeve FROM idopont INNER JOIN szerelo ON idopont.szereloId=szerelo.id WHERE idopont.userId = @userId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adatok.Add($"{reader["datum"]} | {reader["idopont"]} | {reader["szereloNeve"]}");
                        }
                    }
                }
                return adatok;
            }
        }
    }
}
