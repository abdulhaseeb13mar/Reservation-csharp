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
    public partial class updateConveyance : Form
    {
        string conveyance;
        int conveyanceID;
        ConnectionClass db = new ConnectionClass();
        DataTable dt = new DataTable();
        public updateConveyance(string conveyance1, int ID1)
        {
            InitializeComponent();
            conveyance = conveyance1;
            conveyanceID = ID1;
        }

        //--------------------------------------------------------------------------------------
        private void addConveyance_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM "+conveyance+"Detail WHERE "+conveyance+"ID = "+conveyanceID+"";
            dt = db.selectData(sql);
            if(conveyance == "Plane")
            {
                planeNumberBox.Visible = true;
                planeNumberLabel.Visible = true;
                planeNumberBox.DataBindings.Add("Text", dt, "PlaneNumber");
            }
            else
            {
                planeNumberBox.Visible = false;
                planeNumberLabel.Visible = false;
            }
            heading.Text = "UPDATE "+conveyance.ToUpper()+"";
            nameLabel.Text = "" + conveyance + " Name";
            updateConveyanceBtn.Text = "Update "+conveyance+"";

            nameBox.DataBindings.Add("Text", dt, "" + conveyance + "Name");
            singleFareBox.DataBindings.Add("Text", dt,"SingleFare");
            returnFareBox.DataBindings.Add("Text", dt,"ReturnFare");

            if (dt.Rows[0][1].ToString() == "True")
            {
                availableCB.Checked = true;
            }
            else
            {
                availableCB.Checked = false;
            }
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

        //---------------------------------------------------------------------------
        private void ConveyanceBtn_Click(object sender, EventArgs e)
        {
            bool isFormValid = validator();
            if (isFormValid == true && availableCB.Checked == false)
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
                    sql = "UPDATE "+conveyance+ "Detail SET Available='" + available + "' , " + conveyance + "Name = '"+nameBox.Text+ "' , SingleFare = " + Convert.ToInt32(singleFareBox.Value) + " , ReturnFare = " + Convert.ToInt32(returnFareBox.Value) + " WHERE "+conveyance+"ID = "+conveyanceID+"";
                }
                else
                {
                    sql = "UPDATE PlaneDetail SET Available='" + available + "' , PlaneNumber = '"+planeNumberBox.Text+"' , PlaneName = '"+nameBox.Text+ "' , SingleFare = " + Convert.ToInt32(singleFareBox.Value) + " , ReturnFare = " + Convert.ToInt32(returnFareBox.Value) + " WHERE PlaneID = " + conveyanceID + "";
                }
                bool isUpdated = db.manipulateData(sql);
                if (isUpdated == true)
                {
                    MessageBox.Show("" + conveyance + " Updated Successfully");
                    this.Close();
                    //resetBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("" + conveyance + " is not Updated!");
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            updateConveyance frm1 = new updateConveyance(conveyance, conveyanceID);
            frm1.Show();
            this.Close();
        }
    }
}
