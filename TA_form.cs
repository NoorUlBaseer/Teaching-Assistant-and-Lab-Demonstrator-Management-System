using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace win_form_test
{
    public partial class TA_form : Form
    {
        private string connectionString = "Data Source=VICTUS-BY-HP-GA\\SQLEXPRESS;Initial Catalog=TA_and_Lab_Demonstrator_Management_System; Integrated Security=True; Encrypt=false";

        public string user_name, user_type;
        public int ta_id = -1, ld_id = -1;

        public TA_form()
        {
            InitializeComponent();

            this.user_name = Login_form.instance.user_name;

            this.user_type = Login_form.instance.userType;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryTA = @"SELECT ta.TA_id
                FROM TeachingAssistant ta
                JOIN Student s ON ta.student_id = s.student_id
                JOIN [User] u ON s.user_id = u.user_id
                JOIN Credentials c ON u.user_id = c.user_id
                WHERE c.username = @user_name";

                string queryLD = @"SELECT ld.LD_id
                FROM LabDemonstrator ld
                JOIN Student s ON ld.student_id = s.student_id
                JOIN [User] u ON s.user_id = u.user_id
                JOIN Credentials c ON u.user_id = c.user_id
                WHERE c.username = @user_name";

                SqlCommand commandTA = new SqlCommand(queryTA, connection);
                commandTA.Parameters.AddWithValue("@user_name", user_name);
                SqlCommand commandLD = new SqlCommand(queryLD, connection);
                commandLD.Parameters.AddWithValue("@user_name", user_name);

                SqlDataReader readerTA = commandTA.ExecuteReader();
                if (readerTA.Read())
                {
                    ta_id = Convert.ToInt32(readerTA["TA_id"]);
                }
                readerTA.Close();

                SqlDataReader readerLD = commandLD.ExecuteReader();
                if (readerLD.Read())
                {
                    ld_id = Convert.ToInt32(readerLD["LD_id"]);
                }
                readerLD.Close();
            }

            this.FormClosing += new FormClosingEventHandler(TA_form_FormClosing);
        }

        private void TA_form_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TA_form_Load(object sender, EventArgs e)
            {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query;
                SqlCommand command;

                // Check if both TA_id and LD_id are not empty
                if (ta_id != -1 && ld_id != -1)
                {
                    // Extract details from TA table for TA_id
                    query = @"SELECT U.user_id, S.student_id, TA.TA_id, U.name, U.email_address, D.department_name
                      FROM TeachingAssistant TA
                      JOIN Student S ON TA.student_id = S.student_id
                      JOIN [User] U ON S.user_id = U.user_id
                      JOIN Faculty F ON S.department_id = F.department_id
                      JOIN Department D ON F.department_id = D.department_id
                      WHERE TA.TA_id = @ta_id";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ta_id", ta_id);

                    // Execute the query and populate the labels
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label3.Text = reader["user_id"].ToString();
                        label4.Text = reader["student_id"].ToString();
                        label5.Text = reader["TA_id"].ToString();
                        label6.Text = ld_id.ToString();
                        label7.Text = reader["name"].ToString();
                        label8.Text = reader["email_address"].ToString();
                        label9.Text = reader["department_name"].ToString();
                    }
                    reader.Close();
                }
                else if (ta_id != -1)
                {
                    // If only TA_id is not empty, extract details from TA table
                    query = @"SELECT U.user_id, S.student_id, TA.TA_id, U.name, U.email_address, D.department_name
                      FROM TeachingAssistant TA
                      JOIN Student S ON TA.student_id = S.student_id
                      JOIN [User] U ON S.user_id = U.user_id
                      JOIN Faculty F ON S.department_id = F.department_id
                      JOIN Department D ON F.department_id = D.department_id
                      WHERE TA.TA_id = @ta_id";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ta_id", ta_id);

                    // Execute the query and populate the labels
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label3.Text = reader["user_id"].ToString();
                        label4.Text = reader["student_id"].ToString();
                        label5.Text = reader["TA_id"].ToString();
                        label6.Text = "Student is Just a TA";
                        label7.Text = reader["name"].ToString();
                        label8.Text = reader["email_address"].ToString();
                        label9.Text = reader["department_name"].ToString();
                    }
                    reader.Close();
                }
                else if (ld_id != -1)
                {
                    // If only LD_id is not empty, extract details from LD table
                    query = @"SELECT U.user_id, S.student_id, LD.LD_id, U.name, U.email_address, D.department_name
                      FROM LabDemonstrator LD
                      JOIN Student S ON LD.student_id = S.student_id
                      JOIN [User] U ON S.user_id = U.user_id
                      JOIN Faculty F ON S.department_id = F.department_id
                      JOIN Department D ON F.department_id = D.department_id
                      WHERE LD.LD_id = @ld_id";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ld_id", ld_id);

                    // Execute the query and populate the labels
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label3.Text = reader["user_id"].ToString();
                        label4.Text = reader["student_id"].ToString();
                        label5.Text = "Student is Just a LD";
                        label6.Text = reader["LD_id"].ToString();
                        label7.Text = reader["name"].ToString();
                        label8.Text = reader["email_address"].ToString();
                        label9.Text = reader["department_name"].ToString();
                    }
                    reader.Close();
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Populate cmbTasks with tasks associated with TA ID
                if (ta_id != -1)
                {
                    string queryTA = @"SELECT task_id FROM Task WHERE TA_id = @ta_id";
                    SqlCommand commandTA = new SqlCommand(queryTA, connection);
                    commandTA.Parameters.AddWithValue("@ta_id", ta_id);
                    SqlDataReader readerTA = commandTA.ExecuteReader();
                    while (readerTA.Read())
                    {
                        cmbTasks.Items.Add(readerTA["task_id"].ToString());
                    }
                    readerTA.Close();
                }

                // Populate cmbTasks with tasks associated with LD ID
                if (ld_id != -1)
                {
                    string queryLD = @"SELECT task_id FROM Task WHERE LD_id = @ld_id";
                    SqlCommand commandLD = new SqlCommand(queryLD, connection);
                    commandLD.Parameters.AddWithValue("@ld_id", ld_id);
                    SqlDataReader readerLD = commandLD.ExecuteReader();
                    while (readerLD.Read())
                    {
                        cmbTasks.Items.Add(readerLD["task_id"].ToString());
                    }
                    readerLD.Close();
                }
            }

        }

        private void btnRefreshTasks_Click(object sender, EventArgs e)
        {
            // Check if both TA and LD IDs are present
            if (ta_id != -1 && ld_id != -1)
            {
                // Fetch tasks for TA
                FetchTasksForTA();

                // Fetch tasks for LD
                FetchTasksForLD();
            }
            else if (ta_id != -1)
            {
                // Fetch tasks for TA only
                FetchTasksForTA();
            }
            else if (ld_id != -1)
            {
                // Fetch tasks for LD only
                FetchTasksForLD();
            }
            else
            {
                MessageBox.Show("User is neither TA nor LD.");
            }
        }

        private void FetchTasksForTA()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Task.*, Course.course_name, U.name AS faculty_name
                connection.Open();
                string query = @"SELECT t.task_id, t.task_type, c.course_id, c.course_name, F.faculty_id, U.name AS faculty_name, 
                t.TA_id, t.LD_id, t.quantity, t.priority_level, t.status, t.deadline
                FROM Task t
                JOIN Course c ON t.course_id = c.course_id
                JOIN Faculty F ON t.faculty_id = F.faculty_id
                JOIN [User] U ON F.user_id = U.user_id
                WHERE t.TA_id = @ta_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ta_id", ta_id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void FetchTasksForLD()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT t.task_id, t.task_type, c.course_id, c.course_name, F.faculty_id, U.name AS faculty_name, 
                t.TA_id, t.LD_id, t.quantity, t.priority_level, t.status, t.deadline
                FROM Task t
                JOIN Course c ON t.course_id = c.course_id
                JOIN Faculty F ON t.faculty_id = F.faculty_id
                JOIN [User] U ON F.user_id = U.user_id
                WHERE t.LD_id = @ld_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ld_id", ld_id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnUpdateProgress_Click(object sender, EventArgs e)
        {
            // Check if a task is selected in the combo box
            if (cmbTasks.SelectedItem != null)
            {
                // Get the selected task ID from the combo box
                int taskId = Convert.ToInt32(cmbTasks.SelectedItem.ToString());

                // Get the progress value from the text box
                string status = txtProgressUpdate.Text;
                //just check if status is not empty and assign it to the status attribute in task table
                if (!string.IsNullOrEmpty(status))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"UPDATE Task SET status = @status WHERE task_id = @task_id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@task_id", taskId);
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the tasks grid
                            btnRefreshTasks.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update task status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a valid progress value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //move to login page
            Login_form loginForm = new Login_form();
            loginForm.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProgressUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
