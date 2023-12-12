using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantRatingApp
{
    public partial class FeedbackForm : Form
    {
        public string CriteriaFile = @"..\..\criteria.csv";
        public string CustomerFile = @"..\..\customerdata.csv";
        public List<Criteria> Criterias;
        public FeedbackForm()
        {
            InitializeComponent();
        }

        public class CriteriaDetail
        {
            public string CriteriaName { get; set; }
        }
        public List<CriteriaDetail> LoadCsvData(string CsvFile)
        {
            var query = from l in File.ReadAllLines(CsvFile)
                        let data = l.Split(',')
                        select new CriteriaDetail
                        {
                            //Id = data[0],
                            CriteriaName = data[0]
                        };

            return query.ToList();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();

            for (int i = 0; i <= feedbackData.Rows.Count - 1; i++)
            {

                string CriteriaValue = "";

                try
                {
                    //criteria;
                    string Excellent;
                    string Average;
                    string Good;
                    string Disatisfied;

                    if (feedbackData.Rows[i].Cells[0].Value != null)
                    {
                        Excellent = feedbackData.Rows[i].Cells[0].Value.ToString(); //True
                        if (Excellent == "True")
                        {
                            CriteriaValue = "1";
                            //Console.WriteLine(CriteriaValue);

                        }
                    }
                    if (feedbackData.Rows[i].Cells[1].Value != null)
                    {

                        Good = feedbackData.Rows[i].Cells[1].Value.ToString(); //true
                        if (Good == "True")
                        {
                            CriteriaValue = "2";
                            // Console.WriteLine(CriteriaValue);

                        }
                    }
                    if (feedbackData.Rows[i].Cells[2].Value != null)
                    {

                        Average = feedbackData.Rows[i].Cells[2].Value.ToString(); //true
                        if (Average == "True")
                        {
                            CriteriaValue = "3";
                            //Console.WriteLine(CriteriaValue);

                        }
                    }
                    if (feedbackData.Rows[i].Cells[3].Value != null)
                    {

                        Disatisfied = feedbackData.Rows[i].Cells[3].Value.ToString(); //true
                        if (Disatisfied == "True")
                        {
                            CriteriaValue = "4";
                            //Console.WriteLine(CriteriaValue);

                        }
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(" " + ex);

                }

                if (i == 0)
                {
                    addRecord(textBoxCustName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxMsg.Text, date, time, CriteriaValue, CustomerFile);
                }
                else
                {
                    addRecord1(CriteriaValue, CustomerFile);
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(CustomerFile, true))
            {
                file.Write(@"" + "\n");
            }

            LoginForm loginobj = new LoginForm();
            loginobj.Show();
            this.Hide();
        }
        // method to add the feedback to customer file
        public void addRecord(string name, string contact, string email, string message, string date, string time, string feedback, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    //file.WriteLine();
                    file.Write(@"" + name + "," + contact + "," + email + "," + message + "," + date + "," + time + "," + feedback + ",");
                }
                MessageBox.Show("Thank Your for your feedback!!", "Successful");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Sorry, an Error Occured", ex);
            }

        }
        public void addRecord1(string feedback, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.Write(feedback + ",");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Sorry, an Error Occured", ex);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
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

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            feedbackData.DataSource = LoadCsvData(CriteriaFile);
            Console.WriteLine("Form data loaded");
            Console.ReadLine();
        }

        private void feedbackData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var loop = false;
            if (loop == false)
            {
                loop = true;

                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        if (i != e.ColumnIndex)
                        {
                            feedbackData.Rows[(e.RowIndex)].Cells[i].Value = false;
                        }

                    }
                    feedbackData.EndEdit();
                }
            }
        }
    }
}



