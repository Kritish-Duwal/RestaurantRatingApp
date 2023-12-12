using System;
using System.Windows.Forms;



namespace RestaurantRatingApp
{
    public partial class Criteria : Form
    {
        public string CriteriaFile = @"..\..\criteria.csv";
        public Criteria()
        {
            InitializeComponent();
        }
        private void addCriteria_Click(object sender, EventArgs e)
        {
            string criteraiName = textBoxCriteriaName.Text;
            AddRecord(criteraiName, CriteriaFile);
        }

        // method for add criteria to csv file
        public void AddRecord(string criteria, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    //file.WriteLine();
                    file.Write(@"" + criteria + "\n"); // add criteria to new line
                }
                MessageBox.Show("Criteria Added");
            }

            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }
        }

        private void buttonBackCriterira_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
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

        private void buttonClearCriteira_Click(object sender, EventArgs e)
        {
            textBoxCriteriaName.Text = "";
        }
    }
}
