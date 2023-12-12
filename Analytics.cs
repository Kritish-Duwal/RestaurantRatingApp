using System;
using System.Windows.Forms;

namespace RestaurantRatingApp
{
    public partial class Analytics : Form
    {
        string[] cust_txt = System.IO.File.ReadAllLines(@"..\..\customerdata.csv");
        string[] data_col = null;
        bool foodRate = true;
        bool serviceRate = true;
        bool staffRate = true;
        bool hygieneRate = true;
        bool accuracyRate = true;
        bool environmentRate = true;
        bool moneyRate = true;
        bool childRate = true;

        public Analytics()
        {
            InitializeComponent();
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

        private void btnBackAnalytics_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ddlCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCriteria.SelectedIndex == 0)
            {
                foodRatingChart.Show();
                serviceRatingChart.Hide();
                staffRatingChart.Hide();
                hygieneChart.Hide();
                accuracyChart.Hide();
                environmentChart.Hide();
                moneyChart.Hide();
                childChart.Hide();

                if (foodRate == true)
                {
                    int foodRating = 0;
                    int foodRating1 = 0;
                    int foodRating2 = 0;
                    int foodRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 6; i <= 6; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                foodRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                foodRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                foodRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                foodRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    foodRatingChart.Series["Food Rating"].Points.AddXY("1", @foodRating);
                    foodRatingChart.Series["Food Rating"].Points.AddXY("2", @foodRating1);
                    foodRatingChart.Series["Food Rating"].Points.AddXY("3", @foodRating2);
                    foodRatingChart.Series["Food Rating"].Points.AddXY("4", @foodRating3);
                    foodRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 1)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Show();
                staffRatingChart.Hide();
                hygieneChart.Hide();
                accuracyChart.Hide();
                environmentChart.Hide();
                moneyChart.Hide();
                childChart.Hide();

                if (serviceRate == true)
                {
                    int serviceRating = 0;
                    int serviceRating1 = 0;
                    int serviceRating2 = 0;
                    int serviceRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 7; i <= 7; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                serviceRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                serviceRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                serviceRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                serviceRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    serviceRatingChart.Series["Service Rating"].Points.AddXY("1", @serviceRating);
                    serviceRatingChart.Series["Service Rating"].Points.AddXY("2", @serviceRating1);
                    serviceRatingChart.Series["Service Rating"].Points.AddXY("3", @serviceRating2);
                    serviceRatingChart.Series["Service Rating"].Points.AddXY("4", @serviceRating3);
                    serviceRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 2)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Hide();
                staffRatingChart.Show();
                hygieneChart.Hide();
                accuracyChart.Hide();
                environmentChart.Hide();
                moneyChart.Hide();
                childChart.Hide();

                if (staffRate == true)
                {
                    int staffRating = 0;
                    int staffRating1 = 0;
                    int staffRating2 = 0;
                    int staffRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 8; i <= 8; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                staffRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                staffRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                staffRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                staffRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    staffRatingChart.Series["Staff Rating"].Points.AddXY("1", @staffRating);
                    staffRatingChart.Series["Staff Rating"].Points.AddXY("2", @staffRating1);
                    staffRatingChart.Series["Staff Rating"].Points.AddXY("3", @staffRating2);
                    staffRatingChart.Series["Staff Rating"].Points.AddXY("4", @staffRating3);
                    staffRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 3)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Hide();
                staffRatingChart.Hide();
                hygieneChart.Show();
                accuracyChart.Hide();
                environmentChart.Hide();
                moneyChart.Hide();
                childChart.Hide();

                if (hygieneRate == true)
                {
                    int hygieneRating = 0;
                    int hygieneRating1 = 0;
                    int hygieneRating2 = 0;
                    int hygieneRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 9; i <= 9; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                hygieneRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                hygieneRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                hygieneRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                hygieneRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    hygieneChart.Series["Hygiene Rating"].Points.AddXY("1", @hygieneRating);
                    hygieneChart.Series["Hygiene Rating"].Points.AddXY("2", @hygieneRating1);
                    hygieneChart.Series["Hygiene Rating"].Points.AddXY("3", @hygieneRating2);
                    hygieneChart.Series["Hygiene Rating"].Points.AddXY("4", @hygieneRating3);
                    hygieneRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 4)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Hide();
                staffRatingChart.Hide();
                hygieneChart.Hide();
                accuracyChart.Show();
                environmentChart.Hide();
                moneyChart.Hide();
                childChart.Hide();

                if (accuracyRate == true)
                {
                    int accuracyRating = 0;
                    int accuracyRating1 = 0;
                    int accuracyRating2 = 0;
                    int accuracyRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 10; i <= 10; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                accuracyRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                accuracyRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                accuracyRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                accuracyRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    accuracyChart.Series["Order Accuracy"].Points.AddXY("1", @accuracyRating);
                    accuracyChart.Series["Order Accuracy"].Points.AddXY("2", @accuracyRating1);
                    accuracyChart.Series["Order Accuracy"].Points.AddXY("3", @accuracyRating2);
                    accuracyChart.Series["Order Accuracy"].Points.AddXY("4", @accuracyRating3);
                    accuracyRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 5)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Hide();
                staffRatingChart.Hide();
                hygieneChart.Hide();
                accuracyChart.Hide();
                environmentChart.Show();
                moneyChart.Hide();
                childChart.Hide();

                if (environmentRate == true)
                {
                    int environmentRating = 0;
                    int environmentRating1 = 0;
                    int environmentRating2 = 0;
                    int environmentRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 11; i <= 11; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                environmentRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                environmentRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                environmentRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                environmentRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    environmentChart.Series["Restaurant Ambiance"].Points.AddXY("1", @environmentRating);
                    environmentChart.Series["Restaurant Ambiance"].Points.AddXY("2", @environmentRating1);
                    environmentChart.Series["Restaurant Ambiance"].Points.AddXY("3", @environmentRating2);
                    environmentChart.Series["Restaurant Ambiance"].Points.AddXY("4", @environmentRating3);
                    environmentRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 6)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Hide();
                staffRatingChart.Hide();
                hygieneChart.Hide();
                accuracyChart.Hide();
                environmentChart.Hide();
                moneyChart.Show();
                childChart.Hide();

                if (moneyRate == true)
                {
                    int moneyRating = 0;
                    int moneyRating1 = 0;
                    int moneyRating2 = 0;
                    int moneyRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 12; i <= 12; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                moneyRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                moneyRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                moneyRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                moneyRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    moneyChart.Series["Value For Money"].Points.AddXY("1", @moneyRating);
                    moneyChart.Series["Value For Money"].Points.AddXY("2", @moneyRating1);
                    moneyChart.Series["Value For Money"].Points.AddXY("3", @moneyRating2);
                    moneyChart.Series["Value For Money"].Points.AddXY("4", @moneyRating3);
                    moneyRate = false;
                }
            }
            if (ddlCriteria.SelectedIndex == 7)
            {
                foodRatingChart.Hide();
                serviceRatingChart.Hide();
                staffRatingChart.Hide();
                hygieneChart.Hide();
                accuracyChart.Hide();
                environmentChart.Hide();
                moneyChart.Hide();
                childChart.Show();

                if (childRate == true)
                {
                    int childRating = 0;
                    int childRating1 = 0;
                    int childRating2 = 0;
                    int childRating3 = 0;

                    foreach (string text_line in cust_txt)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 13; i <= 13; i++)
                        {
                            //increasing the value in the graph
                            if (data_col[i] == "1")
                            {
                                childRating++;
                            }
                            else if (data_col[i] == "2")
                            {
                                childRating1++;
                            }
                            else if (data_col[i] == "3")
                            {
                                childRating2++;
                            }
                            else if (data_col[i] == "4")
                            {
                                childRating3++;
                            }
                        }
                    }
                    //ploting the data in the graph
                    childChart.Series["Child Friendliness"].Points.AddXY("1", @childRating);
                    childChart.Series["Child Friendliness"].Points.AddXY("2", @childRating1);
                    childChart.Series["Child Friendliness"].Points.AddXY("3", @childRating2);
                    childChart.Series["Child Friendliness"].Points.AddXY("4", @childRating3);
                    childRate = false;
                }
            }
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            foodRatingChart.Hide();
            serviceRatingChart.Hide();
            staffRatingChart.Hide();
            hygieneChart.Hide();
            accuracyChart.Hide();
            environmentChart.Hide();
            moneyChart.Hide();
            childChart.Hide();
        }
    }
}
//