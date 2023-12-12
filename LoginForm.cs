using System;
using System.Windows.Forms;


namespace RestaurantRatingApp
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                MessageBox.Show("Login success");
                Dashboard dashboard = new Dashboard();


                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username and password!", "Alert");
            }

        }
        private void Feedback_Click(object sender, EventArgs e)
        {
            FeedbackForm formFeed = new FeedbackForm();
            formFeed.Show();
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            usersignin usersignin = new usersignin();
            usersignin.Show();
            this.Hide();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            usersignup usersignup = new usersignup();
            usersignup.Show();
            this.Hide();
        }
    }
}
