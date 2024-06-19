using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace win_form_test {
    public partial class Faculty_form : Form {
        private string connectionString = "Data Source=VICTUS-BY-HP-GA\\SQLEXPRESS;Initial Catalog=TA_and_Lab_Demonstrator_Management_System; Integrated Security=True; Encrypt=false";
        
        public string user_name, user_type;
        public int faculty_id;

        public Faculty_form() { //initializer
            InitializeComponent();

            this.user_name = Login_form.instance.user_name;

            this.user_type = Login_form.instance.userType;

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string query = "Select faculty_id From Faculty Where user_id = (Select user_id From Credentials Where username = @user_name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@user_name", user_name);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    faculty_id = Convert.ToInt32(reader["faculty_id"]);
                }
                //label2.Text = faculty_id.ToString();

                reader.Close();
            }

            this.FormClosing += new FormClosingEventHandler(Faculty_form_FormClosing);
        }

        private void Faculty_form_FormClosing(object sender, FormClosingEventArgs e) { //close form
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

        private void Faculty_form_Load(object sender, EventArgs e) { //load form
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT u.user_id, f.faculty_id, u.name, u.email_address, d.department_name
                FROM [User] u
                INNER JOIN Faculty f ON u.user_id = f.user_id
                INNER JOIN Department d ON f.department_id = d.department_id
                WHERE f.faculty_id = @faculty_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@faculty_id", faculty_id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label28.Text = reader["user_id"].ToString();
                    label29.Text = reader["faculty_id"].ToString();
                    label30.Text = reader["name"].ToString();
                    label31.Text = reader["email_address"].ToString();
                    label32.Text = reader["department_name"].ToString();
                }

                reader.Close();
            }

            PopulateStudentsTAComboBox();
            PopulateStudentsLDComboBox();

            PopulateAddTACoursesComboBox();  
            PopulateAddLDCourseComboBox();

            PopulateAssignTACoursesComboBox();
            PopulateAssignLDCourseComboBox();

            PopulateAssignTAFacultyComboBox();
            PopulateAssigLDFacultyComboBox();

            PopulateTAsComboBox();
            PopulateLDsComboBox();
        }

        private void PopulateStudentsTAComboBox() { //populate students TA combo box
            try {
                List<string> studentnames = GetNonTAStudentnames();
                cmbAddTAStudent.Items.AddRange(studentnames.ToArray());
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while populating students combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetNonTAStudentnames()
        { //get student names
            List<string> studentnames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT u.name 
                FROM [User] u 
                INNER JOIN Student s ON s.user_id = u.user_id 
                LEFT JOIN TeachingAssistant ta ON ta.student_id = s.student_id 
                WHERE ta.TA_id IS NULL";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    studentnames.Add(name);
                }

                reader.Close();
            }

            return studentnames;
        }

        private void PopulateStudentsLDComboBox() { //populate students LD combo box
            try
            {
                List<string> ldNames = GetNonLDStudentnames();
                cmbAddLDStudent.Items.AddRange(ldNames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating Lab Demonstrators combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetNonLDStudentnames()
        { //get student names
            List<string> studentnames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT u.name 
                FROM [User] u 
                INNER JOIN Student s ON s.user_id = u.user_id 
                LEFT JOIN LabDemonstrator ld ON s.student_id = ld.student_id 
                WHERE ld.LD_id IS NULL";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    studentnames.Add(name);
                }

                reader.Close();
            }

            return studentnames;
        }

        private void PopulateAddTACoursesComboBox()
        {
            try
            {
                List<string> courseName = GetCourseNames();

                cmbAddTACourse.Items.AddRange(courseName.ToArray());
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating courses combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAddLDCourseComboBox() { 
            try
            {
                List<string> courseNames = GetCourseNames(); // You'll need to implement this function

                // Assuming you have a ComboBox named cmbDepartments
                cmbAddLDCourse.Items.AddRange(courseNames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating departments combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAssignTACoursesComboBox()
        {
            try
            {
                List<string> courseNames = GetCourseNames(); // You'll need to implement this function

                // Assuming you have a ComboBox named cmbDepartments
                cbmAssignTACourse.Items.AddRange(courseNames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating departments combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAssignLDCourseComboBox()
        {
            try
            {
                List<string> courseNames = GetCourseNames(); // You'll need to implement this function

                // Assuming you have a ComboBox named cmbDepartments
                cbmAssignLDCourse.Items.AddRange(courseNames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating departments combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetCourseNames() { //get course names
            List<string> courseNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string query = "Select course_name From Course Where faculty_id = @faculty_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@faculty_id", faculty_id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    string courseName = reader["course_name"].ToString();
                    courseNames.Add(courseName);
                }

                reader.Close();
            }

            return courseNames;
        }

        private void btnAddTA_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = cmbAddTACourse.SelectedItem.ToString();
                string studentName = cmbAddTAStudent.SelectedItem.ToString();

                string courseId = GetCourseIdByName(courseName);
                string studentId = GetStudentIdByName(studentName);

                if (!string.IsNullOrEmpty(courseId) && !string.IsNullOrEmpty(studentId))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO TeachingAssistant (course_id, student_id) VALUES (@CourseId, @StudentId)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("TA added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add TA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve course ID or student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLD_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = cmbAddLDCourse.SelectedItem.ToString();
                string studentName = cmbAddLDStudent.SelectedItem.ToString();

                string courseId = GetCourseIdByName(courseName);
                string studentId = GetStudentIdByName(studentName);

                if (!string.IsNullOrEmpty(courseId) && !string.IsNullOrEmpty(studentId))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO LabDemonstrator (course_id, student_id) VALUES (@CourseId, @StudentId)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CourseId", courseId);
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Lab Demonstrator added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Lab Demonstrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve course ID or student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveTA_Click(object sender, EventArgs e)
        {
            try
            {

                string userId = txtRemoveTA.Text;

                if (userId != null)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM TeachingAssistant WHERE TA_id = @UserId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserId", userId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("TA removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove TA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID not found for the selected TA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveLD_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = txtRemoveLD.Text;

                if (!string.IsNullOrEmpty(userId))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM LabDemonstrator WHERE LD_id = @UserId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserId", userId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Lab Demonstrator removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove Lab Demonstrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID not found for the selected Lab Demonstrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTAsComboBox() { //populate TAs combo box
            try {
                List<string> taUsernames = GetTANames();
                cbmAssignTAName.Items.AddRange(taUsernames.ToArray());
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while populating TAs combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateLDsComboBox() { //populate LDs combo box
            try {
                List<string> ldNames = GetLDNames();
                cbmAssignLDName.Items.AddRange(ldNames.ToArray());

            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while populating LDs combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAssignTAFacultyComboBox()
        {
            try
            {
                List<string> facultyUsernames = GetFacultyNames();
                cbmAssignTAFaculty.Items.AddRange(facultyUsernames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating faculty combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAssigLDFacultyComboBox()
        {
            try
            {
                List<string> facultyUsernames = GetFacultyNames();
                cbmAssignFacultyLD.Items.AddRange(facultyUsernames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating faculty combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCourseIdByName(string courseName)
        {
            string courseId = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select course_id from Course where course_name like @CourseName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseName", courseName);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    courseId = result.ToString();
                }
            }
            return courseId;
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

        private void btnAssignTA_Click(object sender, EventArgs e)
        {
            try
            {   
                // Get inputs from the form
                string courseName = cbmAssignTACourse.SelectedItem.ToString();
                string TAName = cbmAssignTAName.SelectedItem.ToString();
                string facultyName = cbmAssignTAFaculty.SelectedItem.ToString();
                string taskType = txtAssignTaskType.Text;
                int quantity = int.Parse(txtAssignTaskQuantity.Text);
                string priority = txtAssignTaskPriority.Text;
                string status = txtAssignTaskStatus.Text;
                DateTime deadline = dtAssignTaskDueDate.Value;
            
                string formattedDeadline = deadline.ToString("yyyy-MM-dd");
          
                // Get IDs using helper functions
                string courseId = GetCourseId(courseName).ToString();
                string TAId = GetTAIdFromName(TAName).ToString();
                string facultyId = GetFacultyIdFromName(facultyName).ToString();

                // Insert into Task table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Task (task_type, quantity, priority_level, status, deadline, course_id, faculty_id, TA_id)
                             VALUES (@TaskType, @Quantity, @Priority, @Status, @Deadline, @CourseId, @FacultyId, @TAId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TaskType", taskType);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Deadline", formattedDeadline);
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@FacultyId", facultyId);
                    command.Parameters.AddWithValue("@TAId", TAId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssignLD_Click(object sender, EventArgs e) {
            try
            {
                // Get inputs from the form
                string courseName = cbmAssignLDCourse.SelectedItem.ToString();
                string LDName = cbmAssignLDName.SelectedItem.ToString();
                string facultyName = cbmAssignFacultyLD.SelectedItem.ToString();
                string taskType = txtAssignTaskTypeLD.Text;
                int quantity = int.Parse(txtAssignTaskQuantityLD.Text);
                string priority = txtAssignTaskPriorityLD.Text;
                string status = txtAssignTaskStatusLD.Text;
                DateTime deadline = dtAssignTaskDueDateLD.Value;

                string formattedDeadline = deadline.ToString("yyyy-MM-dd");

                // Get IDs using helper functions
                string courseId = GetCourseId(courseName).ToString();
                string LDId = GetLDIdFromName(LDName).ToString();
                string facultyId = GetFacultyIdFromName(facultyName).ToString();

                // Insert into Task table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Task (task_type, quantity, priority_level, status, deadline, course_id, faculty_id,LD_id)
                             VALUES (@TaskType, @Quantity, @Priority, @Status, @Deadline, @CourseId, @FacultyId, @LDId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TaskType", taskType);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Deadline", formattedDeadline);
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@FacultyId", facultyId);
                    command.Parameters.AddWithValue("@LDId", LDId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to get course id from course name
        private int GetCourseId(string courseName)
        {
            int courseId = -1; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT course_id FROM Course WHERE course_name = @CourseName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseName", courseName);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    courseId = Convert.ToInt32(result);
                }
            }

            return courseId;
        }
        private int GetFacultyIdFromName(string facultyName)
        {
            int facultyId = -1; // Default value if faculty not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT f.faculty_id
                        FROM Faculty f
                        INNER JOIN [User] u ON f.user_id = u.user_id
                        WHERE u.name = @FacultyName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FacultyName", facultyName);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    facultyId = Convert.ToInt32(result);
                }
            }

            return facultyId;
        }

        private int GetTAIdFromName(string TAName)
        {
            int TAId = -1; // Default value if TA not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ta.TA_id
                        FROM TeachingAssistant ta
                        INNER JOIN Student s ON ta.student_id = s.student_id
                        INNER JOIN [User] u ON s.user_id = u.user_id
                        WHERE u.name = @TAName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TAName", TAName);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    TAId = Convert.ToInt32(result);
                }
            }

            return TAId;
        }

        private int GetLDIdFromName(string LDName)
        {
            int LDId = -1; // Default value if LD not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ld.LD_id
                        FROM LabDemonstrator ld
                        INNER JOIN Student s ON ld.student_id = s.student_id
                        INNER JOIN [User] u ON s.user_id = u.user_id
                        WHERE u.name = @LDName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LDName", LDName);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    LDId = Convert.ToInt32(result);
                }
            }

            return LDId;
        }

        private void btnViewTAs_Click(object sender, EventArgs e) {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    string query = @"Select ta.TA_id As TA_ID, s.student_id AS Student_ID, u_TA.name As TA_Name, 
                    u_TA.email_address AS Email_Address, c.course_id AS Course_ID, c.course_name As Course_Name, 
                    u_faculty.name As Faculty_Name
                    From TeachingAssistant ta
                    Inner Join Student s ON ta.student_id = s.student_id
                    Inner Join Course c ON ta.course_id = c.course_id
                    Inner Join Faculty f ON c.faculty_id = f.faculty_id
                    Inner Join [User] u_TA ON s.user_id = u_TA.user_id
                    Inner Join [User] u_faculty ON f.user_id = u_faculty.user_id
                    WHERE f.faculty_id = @faculty_id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@faculty_id", faculty_id);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewLDs_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"Select ld.LD_id As LD_ID, s.student_id AS Student_ID, u_TA.name As TA_Name, 
                    u_TA.email_address AS Email_Address, c.course_id AS Course_ID, c.course_name As Course_Name, 
                    u_faculty.name As Faculty_Name
                    From LabDemonstrator ld
                    Inner Join Student s ON ld.student_id = s.student_id
                    Inner Join Course c ON ld.course_id = c.course_id
                    Inner Join Faculty f ON c.faculty_id = f.faculty_id
                    Inner Join [User] u_TA ON s.user_id = u_TA.user_id
                    Inner Join [User] u_faculty ON f.user_id = u_faculty.user_id
                    WHERE f.faculty_id = @faculty_id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@faculty_id", faculty_id);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAddTAStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<string> GetTANames()
        {
            List<string> taNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Select ta.TA_id As TA_ID, s.student_id AS Student_ID, u_TA.name As TA_Name, 
                    u_TA.email_address AS Email_Address, c.course_id AS Course_ID, c.course_name As Course_Name, 
                    u_faculty.name As Faculty_Name
                    From TeachingAssistant ta
                    Inner Join Student s ON ta.student_id = s.student_id
                    Inner Join Course c ON ta.course_id = c.course_id
                    Inner Join Faculty f ON c.faculty_id = f.faculty_id
                    Inner Join [User] u_TA ON s.user_id = u_TA.user_id
                    Inner Join [User] u_faculty ON f.user_id = u_faculty.user_id
                    WHERE f.faculty_id = @faculty_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@faculty_id", faculty_id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string taName = reader["TA_Name"].ToString(); // Use the correct alias here
                    taNames.Add(taName);
                }

                reader.Close();
            }

            return taNames;
        }

        private List<string> GetLDNames()
        {
            List<string> ldNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Select ld.LD_id As LD_ID, s.student_id AS Student_ID, u_TA.name As TA_Name, 
                    u_TA.email_address AS Email_Address, c.course_id AS Course_ID, c.course_name As Course_Name, 
                    u_faculty.name As Faculty_Name
                    From LabDemonstrator ld
                    Inner Join Student s ON ld.student_id = s.student_id
                    Inner Join Course c ON ld.course_id = c.course_id
                    Inner Join Faculty f ON c.faculty_id = f.faculty_id
                    Inner Join [User] u_TA ON s.user_id = u_TA.user_id
                    Inner Join [User] u_faculty ON f.user_id = u_faculty.user_id
                    WHERE f.faculty_id = @faculty_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@faculty_id", faculty_id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ldName = reader["TA_Name"].ToString(); // Use the correct alias here
                    ldNames.Add(ldName);
                }

                reader.Close();
            }

            return ldNames;
        }


        private List<string> GetFacultyNames()
        {
            List<string> facultyNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT u.name 
                FROM Faculty f 
                INNER JOIN [User] u ON f.user_id = u.user_id
                Where f.faculty_id = @faculty_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@faculty_id", faculty_id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string facultyName = reader["name"].ToString();
                    facultyNames.Add(facultyName);
                }

                reader.Close();
            }

            return facultyNames;
        }


        private void lblAssignTAName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbAddTACourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmAssignTACourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmAssignTAName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRemoveTA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRemoveTAName_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbAddLDCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAddLDStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRemoveLD_TextChanged(object sender, EventArgs e)
        {

        }

        private void TA_referesh_button_Click(object sender, EventArgs e) {
            // Clear the existing items in the combo box
            cmbAddTAStudent.Items.Clear();

            // Populate the combo box again
            PopulateStudentsTAComboBox();
        }

        private void LD_referesh_button_Click(object sender, EventArgs e) {
            // Clear the existing items in the combo box
            cmbAddLDStudent.Items.Clear();

            // Populate the combo box again
            PopulateStudentsLDComboBox();
        }

        private void cbmAssignLDName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmAssignLDCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmAssignLDFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignLDTaskStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtAssignLDDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbAssignLDFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmAssignFacultyLD_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskTypeLD_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskQuantityLD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskPriorityLD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignTaskStatusLD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtAssignTaskDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtAssignTaskDueDateLD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbmAssignLDName_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void refreshLD_Click(object sender, EventArgs e)
        {
            //refresh the cbmAssignLDCourse, cbmAssignLDName, cbmAssignLDFaculty combo boxes
            cbmAssignLDCourse.Items.Clear();
            cbmAssignLDName.Items.Clear();
            cbmAssignFacultyLD.Items.Clear();

            PopulateAssignLDCourseComboBox();
            PopulateLDsComboBox();
            PopulateAssigLDFacultyComboBox();
        }

        private void refreshTA_Click(object sender, EventArgs e)
        {
            //refresh the cbmAssignTACourse, cbmAssignTAName, cbmAssignTAFaculty combo boxes
            cbmAssignTACourse.Items.Clear();
            cbmAssignTAName.Items.Clear();
            cbmAssignTAFaculty.Items.Clear();
            
            PopulateAssignTACoursesComboBox();
            PopulateTAsComboBox();
            PopulateAssignTAFacultyComboBox();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //move to the login form
            Login_form loginForm = new Login_form();
            loginForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAssignTAFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
