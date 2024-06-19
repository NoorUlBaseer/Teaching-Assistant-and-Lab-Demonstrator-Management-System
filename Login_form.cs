using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace win_form_test
{
    public partial class Login_form : Form
    {
        public static Login_form instance;
        public string user_name, userType;

        string connectionString= "Data Source=VICTUS-BY-HP-GA\\SQLEXPRESS;Initial Catalog=TA_and_Lab_Demonstrator_Management_System; Integrated Security=True; Encrypt=false";
        public Login_form()
        {
            InitializeComponent();
            instance = this;

            // Handle KeyPress event for text boxes
            txtUsername.KeyPress += TxtUsername_KeyPress;
            txtPassword.KeyPress += TxtPassword_KeyPress;

            this.FormClosing += new FormClosingEventHandler(Login_Form_FormClosing);
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        { //close form
            // Confirm with the user before closing the application
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close the application
                Environment.Exit(0);
            }
            else
            {
                // Cancel the form closing event
                e.Cancel = true;
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            user_name = username;

            if (ValidateUser(username, password))
            {
                userType = GetUserType(username); // Fetch user type from the database

                switch (userType)
                {
                    case "admin":
                        Admin_form adminForm = new Admin_form();
                        adminForm.Show();
                        this.Hide();
                        break;

                    case "faculty":
                        Faculty_form facultyForm = new Faculty_form();
                        facultyForm.Show();
                        this.Hide();
                        break;

                    case "TA":
                        TA_form taForm = new TA_form();
                        taForm.Show();
                        this.Hide();
                        break;

                    case "LD":
                        TA_form ldForm = new TA_form();
                        ldForm.Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Invalid user type.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string username, string password)
        {
            return username == "admin" && password == "password";
        }

        private bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [Credentials] WHERE  CAST (username AS varchar)= @username AND CAST (password AS varchar) = @password"; 
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); 
                connection.Open();
                int count = (int)command.ExecuteScalar();
                isValid = count > 0;
            }
            return isValid;
        }
        private string GetUserType(string username)
        {
            string userType = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetUserType", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.Add("@userType", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                userType = command.Parameters["@userType"].Value.ToString();
            }
            return userType;
        }




        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
