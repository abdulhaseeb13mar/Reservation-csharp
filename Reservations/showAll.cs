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
    public partial class showAll : Form
    {
        ConnectionClass db = new ConnectionClass();
        DataTable dt = new DataTable();
        public showAll()
        {
            InitializeComponent();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PersonalDetail";
            dt = db.selectData(sql);
            dataGridView1.DataSource = dt;
        }

        private void showAll_Load(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM PersonalDetail";
            dt = db.selectData(sql);
            totalPassengerCounter.Text = dt.Rows[0][0].ToString();
            sql = "SELECT COUNT(*) FROM PersonalDetail WHERE ModeOfTravelling = 'Train'";
            dt = db.selectData(sql);
            trainPassengerCounter.Text = dt.Rows[0][0].ToString();
            sql = "SELECT COUNT(*) FROM PersonalDetail WHERE ModeOfTravelling = 'Bus'";
            dt = db.selectData(sql);
            busPassengerCounter.Text = dt.Rows[0][0].ToString();
            sql = "SELECT COUNT(*) FROM PersonalDetail WHERE ModeOfTravelling = 'Plane'";
            dt = db.selectData(sql);
            planePassengerCounter.Text = dt.Rows[0][0].ToString();
        }
    }
}
