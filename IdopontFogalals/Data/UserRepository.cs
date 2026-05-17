using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IdopontFogalals
{
    internal class UserRepository
    {
        public bool UsernameExists(string username)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool EmailExists(string email)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool MobileExists(string mobile)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE mobile = @mobile";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mobile", mobile);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public void RegisterUser(string username, string email, string mobile, string password)
        {
            string passwordHash = PasswordHasher.HashPassword(password);

            MessageBox.Show(
                "REGISTER DEBUG" +
                "\nPassword: [" + password + "]" +
                "\nPassword length: " + password.Length +
                "\nHash: " + passwordHash +
                "\nHash length: " + passwordHash.Length +
                "\nVerify immediately: " + PasswordHasher.VerifyPassword(password, passwordHash)
            );

            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO users (username, password, mobile, email)
                    VALUES (@username, @passwordHash, @mobile, @email)
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@mobile", mobile);
                    command.Parameters.AddWithValue("@email", email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public User GetUserByUsernameOrEmail(string loginText)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT id, username, password, mobile, email
                    FROM users
                    WHERE username = @loginText OR email = @loginText
                    LIMIT 1
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@loginText", loginText);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User();

                            user.id = Convert.ToInt32(reader["id"]);
                            user.username = reader["username"].ToString();
                            user.passwordHash = reader["password"].ToString();
                            user.mobile = reader["mobile"].ToString();
                            user.email = reader["email"].ToString();

                            return user;
                        }
                    }
                }
            }

            return null;
        }

        public User Login(string loginText, string password)
        {
            User user = GetUserByUsernameOrEmail(loginText);

            if (user == null)
            {
                MessageBox.Show("Debug: user not found");
                return null;
            }

            bool passwordCorrect = PasswordHasher.VerifyPassword(password, user.passwordHash);

            MessageBox.Show(
                "LOGIN DEBUG" +
                "\nLogin text: [" + loginText + "]" +
                "\nEntered password: [" + password + "]" +
                "\nEntered password length: " + password.Length +
                "\nFound user ID: " + user.id +
                "\nFound username: [" + user.username + "]" +
                "\nFound email: [" + user.email + "]" +
                "\nStored hash: " + user.passwordHash +
                "\nStored hash length: " + user.passwordHash.Length +
                "\nPassword correct: " + passwordCorrect
            );

            if (passwordCorrect==false)
            {
                MessageBox.Show("Debug: password incorrect");
                return null;
            }

            return user;
        }
    }
}
