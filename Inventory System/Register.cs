using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.Database;

namespace Inventory_System
{
    public partial class Register : Form
    {
        DBInventoryEntities1 db;
        UserAccount UA;


        public Register()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db = new DBInventoryEntities1();

            UA = new UserAccount();
            UA.FirstName = txtFname.Text;
            UA.LastName = txtLname.Text;
            UA.Email = txtEmail.Text;
            UA.Password = txtPass.Text;
            UA.username = txtUsername.Text;

            db.sp_createAccount(UA.FirstName, UA.LastName, UA.Password, UA.Email, UA.username);
            db.SaveChanges();
            MessageBox.Show("Registered Successfully!", "", MessageBoxButtons.OK);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
