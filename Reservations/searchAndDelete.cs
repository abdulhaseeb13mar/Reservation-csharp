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
    public partial class searchAndDelete : Form
    {
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "reservationDBlocal.mdf";
        ConnectionClass db = new ConnectionClass();
        DataTable dt = new DataTable();
        int currentBox;

        public searchAndDelete()
        {
            InitializeComponent();
            idGroupBox.Enabled = false;
            nameGroupBox.Enabled = false;
            numberGroupBox.Enabled = false;
            cnicGroupBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idBox.Text != "" || nameBox.Text != "" || phoneBox.Text != "" || cnicBox.Text != "")
            {
                String searchQuery = "";
                String columnName = "";
                switch (currentBox)
                {
                    case 1:
                        searchQuery = idBox.Text;
                        columnName = "ID";
                        break;
                    case 2:
                        searchQuery = nameBox.Text;
                        columnName = "Name";
                        break;
                    case 3:
                        searchQuery = phoneBox.Text;
                        columnName = "Phone";
                        break;
                    case 4:
                        searchQuery = cnicBox.Text;
                        columnName = "CNIC";
                        break;
                    default:
                        break;
                }
                String sql = "SELECT * FROM PersonalDetail WHERE " + columnName + " LIKE '%" + searchQuery + "%'";
                dt = db.selectData(sql);
                dataGridView1.DataSource = dt;
            }
        }

        private void disableBox (int currentBox)
        {
            switch (currentBox)
            {
                case 1:
                    idBox.Clear();
                    idGroupBox.Enabled = false;
                    break;
                case 2:
                    nameBox.Clear();
                    nameGroupBox.Enabled = false;
                    break;
                case 3:
                    phoneBox.Clear();
                    numberGroupBox.Enabled = false;
                    break;
                case 4:
                    cnicBox.Clear();
                    cnicGroupBox.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void idSearchRadioButton_Click(object sender, EventArgs e)
        {
            disableBox(currentBox);
            idGroupBox.Enabled = true;
            this.ActiveControl = idBox;
            currentBox = 1;
        }

        private void nameSearchRadioButton_Click(object sender, EventArgs e)
        {
            disableBox(currentBox);
            nameGroupBox.Enabled = true;
            this.ActiveControl = nameBox;
            currentBox = 2;
        }

        private void numberSearchRadioButton_Click(object sender, EventArgs e)
        {
            disableBox(currentBox);
            numberGroupBox.Enabled = true;
            this.ActiveControl = phoneBox;
            currentBox = 3;
        }

        private void cnicSearchRadioButton_Click(object sender, EventArgs e)
        {
            disableBox(currentBox);
            cnicGroupBox.Enabled = true;
            this.ActiveControl = cnicBox;
            currentBox = 4;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var proceed = MessageBox.Show("Are you sure you want to delete "+ dataGridView1.Rows[e.RowIndex].Cells[1].Value + "'s Booking ", "Alert!", MessageBoxButtons.YesNo);
            if (proceed == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";database=reservationDBlocal;Integrated Security=True;"))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction transaction;
                    // Start a local transaction.
                    transaction = connection.BeginTransaction("DeleteTransaction");
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        
                        command.CommandText = "DELETE FROM " + dataGridView1.Rows[e.RowIndex].Cells[7].Value + "Passenger WHERE PassengerID = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value) + "";
                        command.ExecuteNonQuery();
                        command.CommandText = "DELETE FROM PersonalDetail WHERE ID = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value) + "";
                        command.ExecuteNonQuery();



                        // Attempt to commit the transaction.
                        transaction.Commit();
                        MessageBox.Show("Booking successfully Deleted!");
                        button1_Click(sender,e);
                    }
                    catch (Exception) // can use Exception to see errors
                    {
                        // Attempt to roll back the transaction.
                        try
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error Occured Booking not Deleted!");
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
}
