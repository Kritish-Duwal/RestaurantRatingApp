using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantRatingApp
{
        public partial class usersignup : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=User;Integrated Security=True");

        public usersignup()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textboxpassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO userdetails (username, password) VALUES (@Username, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Created");
                            usersignin usersignin = new usersignin();
                            usersignin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create the account.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginobj = new LoginForm();
            loginobj.Show();
            this.Hide();
        }
    }
}
