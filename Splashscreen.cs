using System;
using System.Windows.Forms;

namespace RestaurantRatingApp
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                LoginForm loginobj = new LoginForm();
                loginobj.Show();
                this.Hide();
            }
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
