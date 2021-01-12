using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagnumAuditorium.myclass;
using MySql.Data.MySqlClient;


namespace MagnumAuditorium
{
   

    public partial class Facilities : Form
    {
        FacilitiesCRUD crud = new FacilitiesCRUD();
        public Facilities()
        {
            InitializeComponent();
            ReadFacilities();
        }

        private void btnFacilityAdd_Click(object sender, EventArgs e)
        {
            AddFacilities();
            ReadFacilities();
        }

        private void btnFacilityEdit_Click(object sender, EventArgs e)
        {
            EditFacilities();
            ReadFacilities();
        }

        private void btnFacilityDelete_Click(object sender, EventArgs e)
        {
            DeleteFacilities();
            ReadFacilities();
        }

        //READ
        public void ReadFacilities()
        {
            FacilitiesView.DataSource = null;
            crud.Read(); 
            FacilitiesView.DataSource = crud.FacilitiesDT;
        }

        //Create
        public void AddFacilities()
        {
            crud.FacilityName = txtFacilityName.Text;
            crud.FacilityType = txtFacilityType.Text;
            crud.Create();

           
            txtFacilityName.Clear();
            txtFacilityType.Clear();
        }

        //Edit
        public void EditFacilities()
        {
            crud.FacilityName = txtFacilityNameEdit.Text;
            crud.FacilityType = txtFacilityTypeEdit.Text;
            crud.FacilityID = lblFacilityID.Text;
            crud.Update();

           
            txtFacilityNameEdit.Clear();
            txtFacilityTypeEdit.Clear();
            lblFacilityID.Text = "";
        }

        //Delete
        public void DeleteFacilities()
        {
            crud.FacilityID = lblFacilityID.Text;
            crud.Delete();

            
            txtFacilityNameEdit.Clear();
            txtFacilityTypeEdit.Clear();
            lblFacilityID.Text = "";
        }

        private void FacilitiesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get Data
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (FacilitiesView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lblFacilityID.Text = (FacilitiesView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtFacilityNameEdit.Text = (FacilitiesView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtFacilityTypeEdit.Text = (FacilitiesView.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
            }

            catch
            {
                MessageBox.Show("Don't click on the header!");
            }
        }

        private void Facilities_Load(object sender, EventArgs e)
        {

        }

        private void txtFacilityType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFacilityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFacilityTypeEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFacilityNameEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblFacilityID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
