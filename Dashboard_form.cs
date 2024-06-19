/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_form_test
{
    public partial class Dashboard_form : Form
    {
      
        public Dashboard_form()
        {
            InitializeComponent();
        }

        private void Dashboard_form_Load(object sender, EventArgs e)
        {

        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Open the Admin login form
         *//*  Admin_form adminLoginForm = new Admin_form();
            adminLoginForm.ShowDialog();*//*
         Login_form login = new Login_form();
            login.user = "admin";
            login.Show();
            
        }

        private void btnTA_Click(object sender, EventArgs e)
        {
            // Open the TA login form
            *//* TA_form taLoginForm = new TA_form();
            taLoginForm.ShowDialog();*//*
            Login_form login = new Login_form();
            login.user = "TA";
            login.Show();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            // Open the Faculty login form
            *//*  Faculty_form facultyLoginForm = new Faculty_form();
              facultyLoginForm.ShowDialog();*//*
            Login_form login = new Login_form();
            login.user = "faculty";
            login.Show();
        }

        private void Dashboard_form_Load_1(object sender, EventArgs e)
        {

        }
    }
}
*/