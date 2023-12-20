using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        { 
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }
    }
}
