using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace win_form_test
{
    public partial class Admin_form : Form
    {
        string connectionString = "Data Source=VICTUS-BY-HP-GA\\SQLEXPRESS;Initial Catalog=TA_and_Lab_Demonstrator_Management_System; Integrated Security=True; Encrypt=false";

        public string user_name, user_type;
        public int admin_id;

        public Admin_form()
        {
            InitializeComponent();

            this.user_name = Login_form.instance.user_name;

            this.user_type = Login_form.instance.userType;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select admin_id From admin Where user_id = (Select user_id From Credentials Where username = @user_name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_name", user_name);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    admin_id = Convert.ToInt32(reader["admin_id"]);
                }
                //label8.Text = admin_id.ToString();

                reader.Close();
            }

            this.FormClosing += new FormClosingEventHandler(Admin_form_FormClosing);
        }

        private void Admin_form_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Select u.user_id, a.admin_id, u.name, u.email_address
                                from [User] u
                                Inner Join Admin a on u.user_id = a.user_id
                                where a.admin_id = @admin_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@admin_id", admin_id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label4.Text = reader["user_id"].ToString();
                    label5.Text = reader["admin_id"].ToString();
                    label6.Text = reader["name"].ToString();
                    label7.Text = reader["email_address"].ToString();
                }

                reader.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT [course_type_name] FROM [CourseType]";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbCourseType.Items.Add(reader["course_type_name"].ToString());
                }

                reader.Close();
            }

            // Populate faculty names in combo box
            List<string> facultyNames = GetFacultyNames();
            List<string> departmentNames =GetDepartmentNames();

            cmbStudentDeoartment.Items.AddRange(departmentNames.ToArray());
            cmbFacultyDepartment.Items.AddRange(departmentNames.ToArray());
            cmbDepartment.Items.AddRange(departmentNames.ToArray());
            cmbFaculty.Items.AddRange(facultyNames.ToArray());
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string username = txtAddStudentUsername.Text;
            string password = txtAddStudentPassword.Text;
            string name = txtAddStudentName.Text;
            string email = txtAddStudentEmail.Text;
           // string department = txtAddStudentDepartment.Text;
            string dep= cmbStudentDeoartment.SelectedItem.ToString();
            //int id = int.Parse(txtAddStudentId.Text);
            float gpa = float.Parse(txtAddStudentGPA.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert record into User table
                string query1 = "INSERT INTO [User] (name, email_address) VALUES (@name, @email)";
                SqlCommand command = new SqlCommand(query1, connection);
               int depId= GetDepartmentIdByName(dep);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", name+"nu.edu.pk");
                command.ExecuteNonQuery();

                // Get the newly generated user_id
                string userId = GetUserIdByName(name);


                // Insert record into Credentials table
               string query2 = "INSERT INTO Credentials (username, [password], [user_id]) VALUES (@username, @password, @userId)";
                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@username", username);
                command2.Parameters.AddWithValue("@password", password);
                command2.Parameters.AddWithValue("@userId", userId);
                command2.ExecuteNonQuery();

                // Insert record into Student table
               string  query3 = "INSERT INTO Student (department_id,user_id) VALUES ( @departmentId,@uid)";
                SqlCommand command3 = new SqlCommand(query3, connection);
                command3.Parameters.AddWithValue("@departmentId", depId);
                command3.Parameters.AddWithValue("@uid", userId);
                command3.ExecuteNonQuery();

                // Get the newly generated student_id
                string studentId = GetStudentIdByName(name);

                // Insert record into Transcript table
              string  query4 = "INSERT INTO Transcript (gpa, student_id) VALUES (@gpa, @studentId)";
                SqlCommand command4 = new SqlCommand(query4, connection);
                command4.Parameters.AddWithValue("@gpa", gpa);
                command4.Parameters.AddWithValue("@studentId", studentId);
                command4.ExecuteNonQuery();
            }

            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            string username = txtAddFacultyUsername.Text;
            string password = txtAddFacultyPassword.Text;
            string name = txtAddFacultyName.Text;
            string email = txtAddFacultyEmail.Text;
           // string department = txtAddFacultyDepartment.Text;
            string dep=cmbFacultyDepartment.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert record into User table
                string query = "INSERT INTO [User] (name, email_address) VALUES (@name, @email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();

                // Get the newly generated user_id
                string userId = GetUserIdByName(name);

                // Insert record into Credentials table
                query = "INSERT INTO Credentials (username, [password], [user_id]) VALUES (@username, @password, @userId)";
                command.CommandText = query;
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userId", userId);
                command.ExecuteNonQuery();

                // Insert record into Faculty table
                int depId = GetDepartmentIdByName(dep);
                query = "INSERT INTO Faculty (department_id, [user_id]) VALUES (@departmentId, @uid)";
                command.CommandText = query;
                command.Parameters.AddWithValue("@departmentId", depId);
                command.Parameters.AddWithValue("@uid", userId);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Faculty member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch faculty information along with the courses they teach
                string query = "SELECT u.name AS FacultyName, f.faculty_id AS FacultyID, c.course_name AS CourseName " +
                               "FROM [Faculty] f " +
                               "JOIN [User] u ON f.user_id = u.user_id " +
                               "LEFT JOIN [Course] c ON f.faculty_id = c.faculty_id";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable facultyData = new DataTable();
                adapter.Fill(facultyData);

                // Bind the data to DataGridView
                dataGridViewFaculty.DataSource = facultyData;
            }
        }

        private void btnRefreshStudents_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch student information along with course and GPA details
                string query = "SELECT u.name AS StudentName, d.department_name AS Department, t.gpa AS GPA " +
                               "FROM [Student] s " +
                               "JOIN [User] u ON s.user_id = u.user_id " +
                               "JOIN [Department] d ON s.department_id = d.department_id " +
                               "JOIN [Transcript] t ON s.student_id = t.student_id";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable studentData = new DataTable();
                adapter.Fill(studentData);

                // Bind the data to DataGridView
                dataGridViewStudents.DataSource = studentData;
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text;
            string facultyName = cmbFaculty.SelectedItem.ToString();
            string department = cmbDepartment.SelectedItem.ToString();
            string strength = txtStrength.Text;
            string courseTypeName = cmbCourseType.SelectedItem.ToString();
           
            // Insert course into database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Course (course_name,strength,faculty_id,course_type_id,  department_id) " +
                               "VALUES (@courseName, @strength,@coursetypeId, @facultyId, @departmentId)";
                SqlCommand command = new SqlCommand(query, connection);

                // Get faculty ID based on faculty name
                int facultyId = GetFacultyIdByName(facultyName);

                // Get department ID based on department name
                int departmentId = GetDepartmentIdByName(department);

                // Get course type ID based on course type name
                int courseTypeId = GetCourseTypeIdByName(courseTypeName);

                command.Parameters.AddWithValue("@courseName", courseName);
                command.Parameters.AddWithValue("@departmentId", departmentId);
                command.Parameters.AddWithValue("@strength", strength);
                command.Parameters.AddWithValue("@facultyId", facultyId);
                command.Parameters.AddWithValue("@courseTypeId", courseTypeId);

                try
                {
                   
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetCourseTypeIdByName(string courseTypeName)
        {
            int courseTypeId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [course_type_id] FROM [CourseType] WHERE [course_type_name] = @courseTypeName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@courseTypeName", courseTypeName);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    courseTypeId = Convert.ToInt32(result);
                }
            }
            return courseTypeId;
        }

        private int GetFacultyIdByName(string facultyName)
        {
            int facultyId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [faculty_id] FROM [Faculty] WHERE [user_id] = (SELECT [user_id] FROM [User] WHERE [name] = @facultyName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@facultyName", facultyName);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    facultyId = Convert.ToInt32(result);
                }
            }
            return facultyId;
        }

        private int GetDepartmentIdByName(string departmentName)
        {
            int departmentId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [department_id] FROM [Department] WHERE [department_name] = @departmentName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@departmentName", departmentName);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    departmentId = Convert.ToInt32(result);
                }
            }
            return departmentId;
        }

        private string GetUserIdByName(string name)
        {
            string userId = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [user_id] FROM [User] WHERE [name] = @name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userId = result.ToString();
                }
            }
            return userId;
        }

        private string GetStudentIdByName(string studentName)
        {
            string studentId = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT s.student_id FROM Student s INNER JOIN [User] u ON s.user_id = u.user_id WHERE u.[name] like @StudentName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentName", studentName);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    studentId = result.ToString();
                }
            }
            return studentId;
        }




        private List<string> GetFacultyNames()
        {
            List<string> facultyNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [name] FROM [User] INNER JOIN [Faculty] ON [User].[user_id] = [Faculty].[user_id]";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string facultyName = reader["name"].ToString();
                        facultyNames.Add(facultyName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving faculty names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return facultyNames;
        }

        private List<string> GetDepartmentNames()
        {
            List<string> departmentNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [department_name] FROM [Department]";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string departmentName = reader["department_name"].ToString();
                        departmentNames.Add(departmentName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving department names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return departmentNames;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //move to login form
            Login_form loginForm = new Login_form();
            loginForm.Show();
            this.Hide();


        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblFaculty_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void lblAddStudentName_Click(object sender, EventArgs e)
        {

        }

        private void txtAddStudentUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddStudentEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFacultyDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddFacultyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtAddFacultyEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
