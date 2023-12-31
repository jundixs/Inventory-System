﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys;
using Inventory_System.Database;


namespace Inventory_System
{
    public partial class LoginForm : Form
    {
        DBInventoryEntities1 db;
        UserLogged userLogged;
        UserRepository userRepo;
        public LoginForm()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Register().Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            db = new DBInventoryEntities1();

            var userLogged = userRepo.GetUserByUsername(txtName.Text);

            if (userLogged != null)
            {
                if (userLogged.username.Equals(txtName.Text))
                {

                    // Assigned to a singleton
                    UserLogged.GetInstance().UserAccount = userLogged;

                    new MainForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
                                      
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
