using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantRatingApp
{
    public partial class usersignin : Form
    {
      //  SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=User;Integrated Security=True");

        public usersignin()
        {
            InitializeComponent();
        }
   
        private void signin_Click(object sender, EventArgs e)
            
        {
            string username = textBoxusername.Text;
            string password = textboxpassword.Text;

            // Assuming your connection string and SQL query to retrieve user data from the database
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=User;Integrated Security=True");
            string selectQuery = "SELECT COUNT(*) FROM userdetails WHERE username = @username AND password = @password";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        FeedbackForm formFeed = new FeedbackForm();
                        formFeed.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginobj = new LoginForm();
            loginobj.Show();
            this.Hide();
        }
    }
}
