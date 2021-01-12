using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnumAuditorium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Hide();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reservations());
            sidePanel.Show();
            sidePanel.Height = btnReservations.Height;
            sidePanel.Top = btnReservations.Top;
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Facilities());
            sidePanel.Show();
            sidePanel.Height = btnFacilities.Height;
            sidePanel.Top = btnFacilities.Top;
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Resources());
            sidePanel.Show();
            sidePanel.Height = btnResources.Height;
            sidePanel.Top = btnResources.Top;
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Partners());
            sidePanel.Show();
            sidePanel.Height = btnPartners.Height;
            sidePanel.Top = btnPartners.Top;
        }
    }

 
}
