using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.Database;


namespace Inventory_System
{
    public partial class UserModuleForm : Form
    {
        DBInventoryEntities1 db;
        UserModuleForm umf;
        

        public UserModuleForm()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db = new DBInventoryEntities1();
            umf = new UserModuleForm();

            txtUserName.Text = umf.username.ToString();
            txtFullName.Text = umf.fullName.ToString();
            txtUserPass.Text = umf.userPass.ToString();
            txtPhoneNo.Text = umf.phoneNo.ToString();

            db.sp_saveAccount(umf.username, umf.fullname, umf.password, umf.phone);
            db.SaveChanges();
            MessageBox.Show("Registered Successfully!", "", MessageBoxButtons.OK);


        }


        private void UserModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
