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
    public partial class Insert : Form
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "reservationDBlocal.mdf";
        ConnectionClass db = new ConnectionClass();
        DataTable dt = new DataTable();
        String SingleFareGlobal;
        String ReturnFareGlobal;
        Boolean motFlag=false;
        Boolean journeyFlag=false;

        public Insert()
        {
            InitializeComponent();
            noOfSeatsBox.SelectedIndex = 0;
            cityBox.SelectedIndex = 0;
            this.ActiveControl = nameBox;
        }

        
        private void insertButton_Click(object sender, EventArgs e)
        {
            Boolean isAllSet = true;
            string journey="Single";
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
                if ( AmountPaid.Text == "0" )
                {
                    var proceed = MessageBox.Show("Amount Paid is Rs 0!\n\nAre you sure you want to continue?", "Alert!", MessageBoxButtons.YesNo);
                    if (proceed == DialogResult.No)
                    {
                        isAllSet = false;
                    }
                }
                else if (isAllSet == true)
                {
                    string sql1 = "INSERT into PersonalDetail values('" + nameBox.Text + "','"+genderBox.Text+"','" + fatherHusbandBox.Text + "','" + cnicBox.Text + "','" + phoneBox.Text + "','" + addressBox.Text + "','" + motBox.Text + "','" + cityBox.Text + "')";
                    string sql2 = "SELECT IDENT_CURRENT('PersonalDetail')";
                    // Transaction start here
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";database=reservationDBlocal;Integrated Security=True;"))
                    {
                        connection.Open();
                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;
                        // Start a local transaction.
                        transaction = connection.BeginTransaction("InsertTransaction");
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            command.CommandText = sql1;
                            command.ExecuteNonQuery();
                            command.CommandText = sql2;
                            int currentId = Convert.ToInt32(command.ExecuteScalar());
                            command.CommandText = "INSERT INTO " + motBox.Text + "Passenger VALUES(" + currentId + "," + Convert.ToInt32(availableBox.SelectedValue) + ",'" + journey + "'," + Convert.ToInt32(noOfSeatsBox.Text) + "," + Convert.ToInt32(LabelFare.Text) + "," + Convert.ToInt32(AmountPaid.Text) + ")";
                            command.ExecuteNonQuery();
                            // Attempt to commit the transaction.
                            transaction.Commit();
                            MessageBox.Show("Booking successfully Confirmed!");
                            this.Close();
                        }
                        catch (Exception err) // can use Exception to see errors
                        {
                            // Attempt to roll back the transaction.
                            try
                            {
                                transaction.Rollback();
                                MessageBox.Show(err.ToString());
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Rollback Failed!");
                            }
                        }
                    }
                }
            } 
            
            //this.Close();
        }

        private void motBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = "Available "+ motBox.Text +"";
            string sql = "SELECT * FROM "+ motBox.Text + "Detail WHERE Available='1'";
            dt = db.selectData(sql);
            availableBox.DataSource = dt;
            availableBox.DisplayMember = "" + motBox.Text + "Name";
            availableBox.ValueMember = "" + motBox.Text + "ID";
            SingleFareGlobal = fetchFare("SingleFare");
            ReturnFareGlobal = fetchFare("ReturnFare");
            motFlag = true;
            checkAndUpdateFare();
        }

       
        private void returnRadioButton_click(object sender, EventArgs e)
        {
            if (availableBox.Text != "")
            {
                //LabelFare.Text = ""+ ReturnFareGlobal + "" ;
                journeyFlag = true;
                checkAndUpdateFare();
            }
        }
        private void singleRadioButton_click(object sender, EventArgs e)
        {
            if (availableBox.Text != "")
            {
                //LabelFare.Text = "" + SingleFareGlobal + "";
                journeyFlag = true;
                checkAndUpdateFare();
            }
        }

        private String fetchFare (string fare)
        {
            string sql = "SELECT "+fare+" FROM " + motBox.Text + "Detail WHERE " + motBox.Text + "Name = '" + availableBox.Text + "' ";
            int i = db.scalar(sql);
            return i.ToString();
        }

        
        private void availableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingleFareGlobal = fetchFare("SingleFare");
            ReturnFareGlobal = fetchFare("ReturnFare");
            checkAndUpdateFare();
        }

        private bool validator ()
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
            else if (cnicBox.Text == "0")
            {
                MessageBox.Show("Please Enter CNIC");
                return false;
            }
            else if (cnicBox.Text.Length != 13)
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

        private void checkAndUpdateFare ()
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

        private void noOfSeatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndUpdateFare();
        }
    }
}
