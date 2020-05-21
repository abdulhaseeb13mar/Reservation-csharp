using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class addConveyance : Form
    {
        string conveyance;
        ConnectionClass db = new ConnectionClass();
        public addConveyance(string conveyance1)
        {
            InitializeComponent();
            conveyance = conveyance1;
        }

        //--------------------------------------------------------------------------------------
        private void addConveyance_Load(object sender, EventArgs e)
        {
            if(conveyance != "Plane")
            {
                planeNumberBox.Visible = false;
                planeNumberLabel.Visible = false;
            }
            heading.Text = "ADD "+conveyance.ToUpper()+"";
            nameLabel.Text = "" + conveyance + " Name";
            addConveyanceBtn.Text = "Add "+conveyance+"";
            availableCB.Checked = true;
        }

        //--------------------------------------------------------------------------------------
        private bool validator()
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please Enter Name of "+conveyance+"!");
                return false;
            }
            else if (singleFareBox.Text == "0")
            {
                MessageBox.Show("Please Enter the Single Trip Fare");
                return false;
            }
            else if (conveyance == "Plane")
            {
                if (planeNumberBox.Text == "")
                {
                    MessageBox.Show("Please Enter the Plane Number!");
                    return false;
                }
            }
            
            return true;
        }

        private void addConveyanceBtn_Click(object sender, EventArgs e)
        {
            bool isFormValid = validator();
            if ( isFormValid == true && availableCB.Checked == false)
            {
                var proceed = MessageBox.Show("Are you sure this " + conveyance + " is not available", "Alert!", MessageBoxButtons.YesNo);
                if (proceed == DialogResult.No)
                {
                    isFormValid = false;
                }
            }
            if (isFormValid == true)
            {
                    int available;
                    if (availableCB.Checked == true)
                    {
                        available = 1;
                    }
                    else
                    {
                        available = 0;
                    }
                    string sql;
                    if (conveyance != "Plane")
                    {
                        sql = "INSERT INTO " + conveyance + "Detail VALUES('" + available + "' , '" + nameBox.Text + "'," + Convert.ToInt32(singleFareBox.Value) + "," + Convert.ToInt32(returnFareBox.Value) + ")";
                    }
                    else
                    {
                        sql = "INSERT INTO PlaneDetail VALUES('" + available + "' , '" + planeNumberBox.Text + "','" + nameBox.Text + "'," + Convert.ToInt32(singleFareBox.Value) + "," + Convert.ToInt32(returnFareBox.Value) + ")";
                    }
                    bool isInserted = db.inserData(sql);
                    if (isInserted == true)
                    {
                        MessageBox.Show("" + conveyance + " Added Successfully");
                    this.Close();
                    }
                    else
                    {
                        MessageBox.Show("" + conveyance + " is not Added!");
                    }
            }
        }
    }
}
