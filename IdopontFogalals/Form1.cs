using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IdopontFogalals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = "server=localhost;user=root;password=;database=centrum;";

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM gazda ORDER BY id ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        textBox1.Text += (reader["nev"] + " " + reader["id"] + "\r\n");
                    }
                }
            }
            */
        }
    }
}
