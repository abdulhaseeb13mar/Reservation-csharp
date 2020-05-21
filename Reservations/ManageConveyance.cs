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
    public partial class ManageConveyance : Form
    {
        public ManageConveyance()
        {
            InitializeComponent();
        }

        private void showAllTrainBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Train","show");
            showAllConveyanceObj.Show();
        }

        private void showAllBusesBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Bus", "show");
            showAllConveyanceObj.Show();
        }

        private void showAllPlanesBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Plane","show");
            showAllConveyanceObj.Show();
        }

        private void addTrainBtn_Click(object sender, EventArgs e)
        {
            addConveyance addConveyanceObj = new addConveyance("Train");
            addConveyanceObj.ShowDialog();
        }

        private void addBusBtn_Click(object sender, EventArgs e)
        {
            addConveyance addConveyanceObj = new addConveyance("Bus");
            addConveyanceObj.ShowDialog();
        }

        private void addPlane_Click(object sender, EventArgs e)
        {
            addConveyance addConveyanceObj = new addConveyance("Plane");
            addConveyanceObj.ShowDialog();
        }

        private void updateTrainBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Train", "updateShow");
            showAllConveyanceObj.ShowDialog();
        }

        private void updateBusBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Bus", "updateShow");
            showAllConveyanceObj.ShowDialog();
        }

        private void updatePlane_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Plane", "updateShow");
            showAllConveyanceObj.ShowDialog();
        }

        private void deleteTrainBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Train", "deleteShow");
            showAllConveyanceObj.ShowDialog();
        }

        private void deleteBusBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Bus", "deleteShow");
            showAllConveyanceObj.ShowDialog();
        }

        private void deletePlaneBtn_Click(object sender, EventArgs e)
        {
            showAllConveyance showAllConveyanceObj = new showAllConveyance("Plane", "deleteShow");
            showAllConveyanceObj.ShowDialog();
        }
    }
}
