using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Reservations
{
    public partial class updateForm : Form
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "reservationDBlocal.mdf";
        DataTable dt = new DataTable();
        ConnectionClass db = new ConnectionClass();
        string SingleFareGlobal;
        string ReturnFareGlobal;
        int userId;
        string userMot;
        string mot;
        Boolean motFlag = true;
        Boolean journeyFlag = true;


        public updateForm(int id, string mot)
        {
            InitializeComponent();
            userId = id;
            userMot = mot;
        }

        //------------------------------------------------------------------------------------------------
        private void updateForm_Load(object sender, EventArgs e)
        {

            string sql1 = "Select * FROM PersonalDetail WHERE ID="+userId+"";
            string sql2 = "SELECT * FROM "+userMot+ "Passenger WHERE PassengerID=" + userId + "";
            dt = db.selectData(sql1);

            if (dt.Rows[0][2].ToString() == "Male")
            {
                HeadingLabel.Text = "MR. "+dt.Rows[0][1].ToString().ToUpper()+"'S BOOKING";
            }
            else
            {
                HeadingLabel.Text = "MISS " + dt.Rows[0][1].ToString().ToUpper() + "'S BOOKING";
            }

            mot = dt.Rows[0][7].ToString();
            labelID.Text = userId.ToString();
            nameBox.DataBindings.Add("Text", dt, "Name");
            int index = genderBox.FindString(dt.Rows[0][2].ToString());
            genderBox.SelectedIndex = index;
            fatherHusbandBox.DataBindings.Add("Text", dt, "FatherHusbandName");
            cnicLabel.Text = dt.Rows[0][4].ToString();
            phoneBox.DataBindings.Add("Text", dt, "Phone");
            index = cityBox.FindString(dt.Rows[0][8].ToString());
            cityBox.SelectedIndex = index;
            addressBox.DataBindings.Add("Text", dt, "Address");
            index = motBox.FindString(dt.Rows[0][7].ToString());
            motBox.SelectedIndex = index;

            string sql3 = "SELECT * FROM " + motBox.Text + "Detail";
            dt = db.selectData(sql3);
            availableBox.DataSource = dt;
            availableBox.DisplayMember = "" + motBox.Text + "Name";
            availableBox.ValueMember = "" + motBox.Text + "ID";
            
            // For fetching the passenger booking details
            string sql4 = "SELECT x."+motBox.Text+"Name, y.Journey, y.NoOfSeats, y.Fare, y.AmountPaid FROM "+motBox.Text+"Detail x, "+motBox.Text+ "Passenger y WHERE x."+motBox.Text+ "ID = y."+motBox.Text+"ID AND PassengerID = "+userId+"";
            dt = db.selectData(sql4);
            index = availableBox.FindString(dt.Rows[0][0].ToString());
            availableBox.SelectedIndex = index;

            if (dt.Rows[0][1].ToString() == "Single")
            {
                singleRadioButton.Checked = true;
            }
            else if (dt.Rows[0][1].ToString() == "Return")
            {
                returnRadioButton.Checked = true;
            }

            index = noOfSeatsBox.FindString(dt.Rows[0][2].ToString());
            noOfSeatsBox.SelectedIndex = index;

            LabelFare.Text = dt.Rows[0][3].ToString();
            AmountPaidBox.DataBindings.Add("Text", dt, "AmountPaid");

            SingleFareGlobal = fetchFare("SingleFare");
            ReturnFareGlobal = fetchFare("ReturnFare");
        }

        //------------------------------------------------------------------------------------------------
        private void motBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM " + motBox.Text + "Detail";
            dt = db.selectData(sql);
            availableBox.DataSource = dt;
            availableBox.DisplayMember = "" + motBox.Text + "Name";
            availableBox.ValueMember = "" + motBox.Text + "ID";
            SingleFareGlobal = fetchFare("SingleFare");
            ReturnFareGlobal = fetchFare("ReturnFare");
            motFlag = true;
            checkAndUpdateFare();
        }

        //------------------------------------------------------------------------------------------------
        private void returnRadioButton_click(object sender, EventArgs e)
        {
            if (availableBox.Text != "")
            {
                journeyFlag = true;
                checkAndUpdateFare();
            }
        }

        //-----------------------------------------------------------------------------------------------
        private void singleRadioButton_click(object sender, EventArgs e)
        {
            if (availableBox.Text != "")
            {
                journeyFlag = true;
                checkAndUpdateFare();
            }
        }

        //------------------------------------------------------------------------------------------------
        private void noOfSeatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndUpdateFare();
        }

        //------------------------------------------------------------------------------------------------
        private void availableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingleFareGlobal = fetchFare("SingleFare");
            ReturnFareGlobal = fetchFare("ReturnFare");
            checkAndUpdateFare();
        }

        //------------------------------------------------------------------------------------------------
        private string fetchFare(string fare)
        {
            string sql = "SELECT " + fare + " FROM " + motBox.Text + "Detail WHERE " + motBox.Text + "Name = '" + availableBox.Text + "' ";
            int i = db.scalar(sql);
            return i.ToString();
        }

        //------------------------------------------------------------------------------------------------
        private void checkAndUpdateFare()
        {
            if (motFlag == true && journeyFlag == true)
            {
                if (singleRadioButton.Checked == true)
                {
                    LabelFare.Text = (Convert.ToInt32(SingleFareGlobal) * Convert.ToInt32(noOfSeatsBox.Text)).ToString();
                }
                else if (returnRadioButton.Checked == true)
                {
                    LabelFare.Text = (Convert.ToInt32(ReturnFareGlobal) * Convert.ToInt32(noOfSeatsBox.Text)).ToString();
                }
            }
        }

        //------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            updateForm frm1 = new updateForm(userId,userMot);
            frm1.Show();
            this.Close();
        }

        //------------------------------------------------------------------------------------------------
        private bool validator()
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please Enter Name!");
                return false;
            }
            else if (genderBox.Text == "")
            {
                MessageBox.Show("Please Enter Gender");
                return false;
            }
            else if (cnicLabel.Text == "0")
            {
                MessageBox.Show("Please Enter CNIC");
                return false;
            }
            else if (cnicLabel.Text.Length != 13)
            {
                MessageBox.Show("Please Enter Correct CNIC of 13 digits");
                return false;
            }
            else if (phoneBox.Text == "0")
            {
                MessageBox.Show("Please Enter Phone Number");
                return false;
            }
            else if (phoneBox.Text.Length != 10)
            {
                MessageBox.Show("Please Enter Correct Phone Number of 11 digits");
                return false;
            }
            else if (cityBox.Text == "")
            {
                MessageBox.Show("Please Enter City");
                return false;
            }
            else if (motBox.Text == "")
            {
                MessageBox.Show("Please Enter Mode of Travelling");
                return false;
            }
            else if (singleRadioButton.Checked == false && returnRadioButton.Checked == false)
            {
                MessageBox.Show("Please Either Select Single or Return Journey");
                return false;
            }

            return true;
        }

        //------------------------------------------------------------------------------------------------
        private void updateButton_Click(object sender, EventArgs e)
        {
            Boolean isAllSet = true;
            string journey = "Single";
            if (singleRadioButton.Checked == true)
            {
                journey = "Single";
            }
            else if (returnRadioButton.Checked == true)
            {
                journey = "Return";
            }
            Boolean isValidForm = validator();
            if (isValidForm == true)
            {
                if (AmountPaidBox.Text == "0")
                {
                    var proceed = MessageBox.Show("Amount Paid is Rs 0!\n\nAre you sure you want to continue?", "Alert!", MessageBoxButtons.YesNo);
                    if (proceed == DialogResult.No)
                    {
                        isAllSet = false;
                    }
                }
                else if (isAllSet == true)
                {
                    string sql1 = "UPDATE PersonalDetail SET Name = '" + nameBox.Text + "' , Gender = '" + genderBox.Text + "' , FatherHusbandName = '" + fatherHusbandBox.Text + "' , CNIC = '" + cnicLabel.Text + "' , Phone = '" + phoneBox.Text + "' , Address = '" + addressBox.Text + "' , ModeOfTravelling = '" + motBox.Text + "' , City = '" + cityBox.Text + "' WHERE ID = "+userId+"";
                    string sql2 = "UPDATE "+motBox.Text+ "Passenger SET "+motBox.Text+ "ID = "+Convert.ToInt16(availableBox.SelectedValue)+ " , Journey = '"+journey+ "' , NoOfSeats = "+ Convert.ToInt16(noOfSeatsBox.Text)+ " , Fare = "+Convert.ToInt32(LabelFare.Text)+ " , AmountPaid = "+Convert.ToInt32(AmountPaidBox.Text)+ " WHERE PassengerID = "+userId+"";

                    //Transaction start here
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";database=reservationDBlocal;Integrated Security=True;"))
                    {
                        connection.Open();
                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;
                        // Start a local transaction.
                        transaction = connection.BeginTransaction("UpdateTransaction");
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            command.CommandText = sql1;
                            command.ExecuteNonQuery();
                            if (mot != motBox.Text)
                            {
                                command.CommandText = "INSERT INTO " + motBox.Text + "Passenger VALUES(" + userId + "," + Convert.ToInt16(availableBox.SelectedValue) + ",'" + journey + "'," + Convert.ToInt16(noOfSeatsBox.Text) + "," + Convert.ToInt32(LabelFare.Text) + "," + Convert.ToInt32(AmountPaidBox.Text) + ")";
                                command.ExecuteNonQuery();
                                command.CommandText = "DELETE FROM "+mot+"Passenger WHERE PassengerID = "+userId+"";
                                command.ExecuteNonQuery();
                            } else
                            {
                                command.CommandText = sql2;
                                command.ExecuteNonQuery();
                            }
                            
                            // Attempt to commit the transaction.
                            transaction.Commit();
                            MessageBox.Show("Booking successfully Updated!");
                            this.Close();
                        }
                        catch (Exception) // can use Exception to see errors
                        {
                            // Attempt to roll back the transaction.
                            try
                            {
                                transaction.Rollback();
                                MessageBox.Show("Error Occured Booking not Updated!");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Rollback Failed!");
                            }
                        }
                    }
                }
            }
        }

       

        private void AmountPaidBox_ValueChanged(object sender, EventArgs e)
        {
            int remainingFare = Convert.ToInt32(LabelFare.Text) - Convert.ToInt32(AmountPaidBox.Value);
            remainingAmountLabel.Text = remainingFare.ToString();
        }
    }
}
