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
    public partial class showAllConveyance : Form
    {
        ConnectionClass db = new ConnectionClass();
        DataTable dt = new DataTable();
        string conveyance;
        string type;
        public showAllConveyance(string conveyance1, string type1)
        {
            InitializeComponent();
            conveyance = conveyance1;
            type = type1;
        }

        private void showAllConveyance_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM " + conveyance + "Detail";
            dt = db.selectData(sql);
            dataGridView1.DataSource = dt;
            if (type == "show")
            {
                Heading.Text = "" + conveyance + " List";
            }
            else if (type == "updateShow")
            {
                Heading.Text = "Double Click to Update the " + conveyance + "";
                Heading.Left = 145;
            }
            else if (type == "deleteShow")
            {
                Heading.Text = "Double Click to Delete the " + conveyance + "";
                Heading.Left = 145;
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (type == "updateShow")
            {
                updateConveyance updateConveyanceObj = new updateConveyance(""+conveyance+"", Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                updateConveyanceObj.ShowDialog();
                this.Close();
            }
            else if (type == "deleteShow")
            {
                var proceed = MessageBox.Show("Are you sure you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[2].Value + "","Alert!", MessageBoxButtons.YesNo);
                if (proceed == DialogResult.Yes)
                {
                    string sql = "SELECT TOP(1) "+conveyance+"ID FROM "+conveyance+"Passenger WHERE " + conveyance + "ID = "+ Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value) + "";
                    dt = db.selectData(sql);
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("You cannot delete this " + conveyance + " untill you delete all the Passengers who are booked for this " + conveyance + "");
                    }
                    else
                    {
                        sql = "DELETE FROM "+conveyance+ "Detail WHERE " + conveyance + "ID = " + Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value) + "";
                        bool isDeleted = db.manipulateData(sql);
                        if (isDeleted == true)
                        {
                            MessageBox.Show("" + conveyance + " Deleted Successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed!");
                        }
                    }
                }
            }
        }
    }
}
