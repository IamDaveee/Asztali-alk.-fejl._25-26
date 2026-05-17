using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IdopontFogalals
{
    internal class Database
    {
        private static string conn = "server=localhost;user=root;password=;database=idopontfoglalas;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(conn);
        }

        /* //Anywhere in the app
         
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                // SQL code here
            }

         */

    }
}
