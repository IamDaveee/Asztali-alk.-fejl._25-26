using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IdopontFogalals
{
    internal class SzereloHelper
    {

        public static List<string> GetSpecials()
        {
            List<string> spec = new List<string>();
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT specialist FROM szerelo";
                using (MySqlCommand cmd=new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string specialist = reader.GetString("specialist");
                            spec.Add(specialist);
                        }
                    }
                }
            }
            return spec;
        }

        public static List<string> GetMechanic(string spec)
        {
            List<string> mechanic = new List<string>();
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT name FROM szerelo WHERE specialist = @spec";
                using (MySqlCommand cmd=new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@spec", spec);
                    using (MySqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString("name");
                            mechanic.Add(name);
                        }
                    }
                }
            }
            return mechanic;
        }

        public static int getMechanicId(string name)
        {
            using (MySqlConnection connect=Database.GetConnection())
            {
                connect.Open();
                string query = "SELECT id FROM szerelo WHERE name = @name";

                using (MySqlCommand cmd=new MySqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    int mechanicId = Convert.ToInt32(cmd.ExecuteScalar());
                    return mechanicId;
                }
            }
        }

        public static void IdopontFoglalas(int userId, int szereloId, string date, string time)
        {
            using (MySqlConnection connect=Database.GetConnection())
            {
                connect.Open();

                string query = "INSERT INTO `idopont` (`userId`, `szereloId`, `date`, `time`) VALUES (@userId, @szereloId, @date, @time)";

                using (MySqlCommand cmd=new MySqlCommand(query, connect))
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
