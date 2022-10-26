using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            ucAdmins1.BringToFront();

        }

        private void btnPropType_Click(object sender, EventArgs e)
        {
            ucPropertyType1.BringToFront();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ucProperties1.BringToFront();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            ucProvince1.BringToFront();
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            ucCities1.BringToFront();
        }

        private void btnSurbubs_Click(object sender, EventArgs e)
        {
            ucSurburbs1.BringToFront();
        }

        private void btnAgencies_Click(object sender, EventArgs e)
        {
            usAgencies1.BringToFront();
        }
      

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ucAgent1.BringToFront();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            ucTenant1.BringToFront();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ucRental1.BringToFront();
        }

        private void btnPropAgent_Click(object sender, EventArgs e)
        {
            ucPropertyAgent1.BringToFront();
        }

        private void btnCities_Click_1(object sender, EventArgs e)
        {
            ucCities1.BringToFront();
        }

        private void btnSurbubs_Click_1(object sender, EventArgs e)
        {
            ucSurburbs1.BringToFront();
        }

        private void btnProvince_Click_1(object sender, EventArgs e)
        {
            ucProvince1.BringToFront();
        }
    }
}
