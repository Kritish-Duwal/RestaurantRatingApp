using System;
using System.Drawing;
using System.Windows.Forms;


namespace RestaurantRatingApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            Analytics alanytics = new Analytics();
            alanytics.Show();
            this.Hide();

        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCriteria_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCriteria.Height;
            pnlNav.Top = btnCriteria.Top;
            pnlNav.Left = btnCriteria.Left;
            Criteria critobj = new Criteria();
            critobj.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginobj = new LoginForm();
            loginobj.Show();
            this.Hide();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReport.Height;
            pnlNav.Top = btnReport.Top;
            pnlNav.Left = btnReport.Left;
            btnReport.BackColor = Color.FromArgb(46, 51, 73);
            Report report = new Report();
            report.Show();
            this.Hide();
        }
        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
