namespace win_form_test
{
    partial class Admin_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Variables for TabControl and TabPages
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        // Variables for Tab 1 (Add Student)
        private System.Windows.Forms.Label lblAddStudentUsername;
        private System.Windows.Forms.TextBox txtAddStudentUsername;
        private System.Windows.Forms.Label lblAddStudentPassword;
        private System.Windows.Forms.TextBox txtAddStudentPassword;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblAddStudentName;
        private System.Windows.Forms.TextBox txtAddStudentName;
        private System.Windows.Forms.Label lblAddStudentGPA;
        private System.Windows.Forms.TextBox txtAddStudentGPA;

        // Variables for Tab 2 (Add Faculty)
        private System.Windows.Forms.Label lblAddFacultyUsername;
        private System.Windows.Forms.TextBox txtAddFacultyUsername;
        private System.Windows.Forms.Label lblAddFacultyPassword;
        private System.Windows.Forms.TextBox txtAddFacultyPassword;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.Label lblAddFacultyName;
        private System.Windows.Forms.TextBox txtAddFacultyName;

        // Variables for Tab 5 (Add Course)
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Button btnAddCourse;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddStudentEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.cmbStudentDeoartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddStudentGPA = new System.Windows.Forms.Label();
            this.txtAddStudentGPA = new System.Windows.Forms.TextBox();
            this.lblAddStudentName = new System.Windows.Forms.Label();
            this.txtAddStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddStudentPassword = new System.Windows.Forms.TextBox();
            this.lblAddStudentPassword = new System.Windows.Forms.Label();
            this.txtAddStudentUsername = new System.Windows.Forms.TextBox();
            this.lblAddStudentUsername = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbCourseType = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddFacultyEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFacultyDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddFacultyName = new System.Windows.Forms.Label();
            this.txtAddFacultyName = new System.Windows.Forms.TextBox();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.txtAddFacultyPassword = new System.Windows.Forms.TextBox();
            this.lblAddFacultyPassword = new System.Windows.Forms.Label();
            this.txtAddFacultyUsername = new System.Windows.Forms.TextBox();
            this.lblAddFacultyUsername = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRefreshStudents = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRefreshFaculty = new System.Windows.Forms.Button();
            this.dataGridViewFaculty = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.label26);
            this.tabPage6.Controls.Add(this.label25);
            this.tabPage6.Controls.Add(this.label24);
            this.tabPage6.Controls.Add(this.label22);
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(582, 310);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Admin Details";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(142, 135);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "User ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(116, 221);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Admin Email:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(130, 163);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Admin ID:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(116, 193);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Admin Name:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(378, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtAddStudentEmail);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.cmbStudentDeoartment);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblAddStudentGPA);
            this.tabPage1.Controls.Add(this.txtAddStudentGPA);
            this.tabPage1.Controls.Add(this.lblAddStudentName);
            this.tabPage1.Controls.Add(this.txtAddStudentName);
            this.tabPage1.Controls.Add(this.btnAddStudent);
            this.tabPage1.Controls.Add(this.txtAddStudentPassword);
            this.tabPage1.Controls.Add(this.lblAddStudentPassword);
            this.tabPage1.Controls.Add(this.txtAddStudentUsername);
            this.tabPage1.Controls.Add(this.lblAddStudentUsername);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(102, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(303, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "TA/LD Management System";
            // 
            // txtAddStudentEmail
            // 
            this.txtAddStudentEmail.Location = new System.Drawing.Point(202, 164);
            this.txtAddStudentEmail.Name = "txtAddStudentEmail";
            this.txtAddStudentEmail.Size = new System.Drawing.Size(203, 20);
            this.txtAddStudentEmail.TabIndex = 19;
            this.txtAddStudentEmail.TextChanged += new System.EventHandler(this.txtAddStudentEmail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email Address:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(451, 26);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "Logout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbStudentDeoartment
            // 
            this.cmbStudentDeoartment.FormattingEnabled = true;
            this.cmbStudentDeoartment.Location = new System.Drawing.Point(202, 197);
            this.cmbStudentDeoartment.Name = "cmbStudentDeoartment";
            this.cmbStudentDeoartment.Size = new System.Drawing.Size(203, 21);
            this.cmbStudentDeoartment.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Department:";
            // 
            // lblAddStudentGPA
            // 
            this.lblAddStudentGPA.AutoSize = true;
            this.lblAddStudentGPA.Location = new System.Drawing.Point(95, 227);
            this.lblAddStudentGPA.Name = "lblAddStudentGPA";
            this.lblAddStudentGPA.Size = new System.Drawing.Size(32, 13);
            this.lblAddStudentGPA.TabIndex = 12;
            this.lblAddStudentGPA.Text = "GPA:";
            // 
            // txtAddStudentGPA
            // 
            this.txtAddStudentGPA.Location = new System.Drawing.Point(202, 224);
            this.txtAddStudentGPA.Name = "txtAddStudentGPA";
            this.txtAddStudentGPA.Size = new System.Drawing.Size(100, 20);
            this.txtAddStudentGPA.TabIndex = 11;
            // 
            // lblAddStudentName
            // 
            this.lblAddStudentName.AutoSize = true;
            this.lblAddStudentName.Location = new System.Drawing.Point(113, 129);
            this.lblAddStudentName.Name = "lblAddStudentName";
            this.lblAddStudentName.Size = new System.Drawing.Size(38, 13);
            this.lblAddStudentName.TabIndex = 8;
            this.lblAddStudentName.Text = "Name:";
            this.lblAddStudentName.Click += new System.EventHandler(this.lblAddStudentName_Click);
            // 
            // txtAddStudentName
            // 
            this.txtAddStudentName.Location = new System.Drawing.Point(202, 126);
            this.txtAddStudentName.Name = "txtAddStudentName";
            this.txtAddStudentName.Size = new System.Drawing.Size(203, 20);
            this.txtAddStudentName.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(259, 273);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddStudentPassword
            // 
            this.txtAddStudentPassword.Location = new System.Drawing.Point(202, 91);
            this.txtAddStudentPassword.Name = "txtAddStudentPassword";
            this.txtAddStudentPassword.PasswordChar = '*';
            this.txtAddStudentPassword.Size = new System.Drawing.Size(203, 20);
            this.txtAddStudentPassword.TabIndex = 3;
            // 
            // lblAddStudentPassword
            // 
            this.lblAddStudentPassword.AutoSize = true;
            this.lblAddStudentPassword.Location = new System.Drawing.Point(95, 94);
            this.lblAddStudentPassword.Name = "lblAddStudentPassword";
            this.lblAddStudentPassword.Size = new System.Drawing.Size(56, 13);
            this.lblAddStudentPassword.TabIndex = 2;
            this.lblAddStudentPassword.Text = "Password:";
            // 
            // txtAddStudentUsername
            // 
            this.txtAddStudentUsername.Location = new System.Drawing.Point(202, 61);
            this.txtAddStudentUsername.Name = "txtAddStudentUsername";
            this.txtAddStudentUsername.Size = new System.Drawing.Size(203, 20);
            this.txtAddStudentUsername.TabIndex = 1;
            this.txtAddStudentUsername.TextChanged += new System.EventHandler(this.txtAddStudentUsername_TextChanged);
            // 
            // lblAddStudentUsername
            // 
            this.lblAddStudentUsername.AutoSize = true;
            this.lblAddStudentUsername.Location = new System.Drawing.Point(95, 64);
            this.lblAddStudentUsername.Name = "lblAddStudentUsername";
            this.lblAddStudentUsername.Size = new System.Drawing.Size(58, 13);
            this.lblAddStudentUsername.TabIndex = 0;
            this.lblAddStudentUsername.Text = "Username:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.cmbDepartment);
            this.tabPage5.Controls.Add(this.cmbCourseType);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.lblCourseName);
            this.tabPage5.Controls.Add(this.txtCourseName);
            this.tabPage5.Controls.Add(this.lblFaculty);
            this.tabPage5.Controls.Add(this.cmbFaculty);
            this.tabPage5.Controls.Add(this.lblDepartment);
            this.tabPage5.Controls.Add(this.lblStrength);
            this.tabPage5.Controls.Add(this.txtStrength);
            this.tabPage5.Controls.Add(this.btnAddCourse);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(582, 310);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Add Course";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(122, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "TA/LD Management System";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(165, 191);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(203, 21);
            this.cmbDepartment.TabIndex = 14;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbCourseType
            // 
            this.cmbCourseType.FormattingEnabled = true;
            this.cmbCourseType.Location = new System.Drawing.Point(165, 153);
            this.cmbCourseType.Name = "cmbCourseType";
            this.cmbCourseType.Size = new System.Drawing.Size(203, 21);
            this.cmbCourseType.TabIndex = 13;
            this.cmbCourseType.SelectedIndexChanged += new System.EventHandler(this.cmbCourseType_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(58, 87);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(165, 84);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(203, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(58, 117);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(44, 13);
            this.lblFaculty.TabIndex = 2;
            this.lblFaculty.Text = "Faculty:";
            this.lblFaculty.Click += new System.EventHandler(this.lblFaculty_Click);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(165, 114);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(203, 21);
            this.cmbFaculty.TabIndex = 3;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(58, 187);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department:";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(58, 221);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(50, 13);
            this.lblStrength.TabIndex = 6;
            this.lblStrength.Text = "Strength:";
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(165, 218);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(203, 20);
            this.txtStrength.TabIndex = 7;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(210, 264);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtAddFacultyEmail);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cmbFacultyDepartment);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblAddFacultyName);
            this.tabPage2.Controls.Add(this.txtAddFacultyName);
            this.tabPage2.Controls.Add(this.btnAddFaculty);
            this.tabPage2.Controls.Add(this.txtAddFacultyPassword);
            this.tabPage2.Controls.Add(this.lblAddFacultyPassword);
            this.tabPage2.Controls.Add(this.txtAddFacultyUsername);
            this.tabPage2.Controls.Add(this.lblAddFacultyUsername);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Faculty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(113, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "TA/LD Management System";
            // 
            // txtAddFacultyEmail
            // 
            this.txtAddFacultyEmail.Location = new System.Drawing.Point(182, 193);
            this.txtAddFacultyEmail.Name = "txtAddFacultyEmail";
            this.txtAddFacultyEmail.Size = new System.Drawing.Size(203, 20);
            this.txtAddFacultyEmail.TabIndex = 27;
            this.txtAddFacultyEmail.TextChanged += new System.EventHandler(this.txtAddFacultyEmail_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Email:";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbFacultyDepartment
            // 
            this.cmbFacultyDepartment.FormattingEnabled = true;
            this.cmbFacultyDepartment.Location = new System.Drawing.Point(182, 225);
            this.cmbFacultyDepartment.Name = "cmbFacultyDepartment";
            this.cmbFacultyDepartment.Size = new System.Drawing.Size(203, 21);
            this.cmbFacultyDepartment.TabIndex = 24;
            this.cmbFacultyDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbFacultyDepartment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Department:";
            // 
            // lblAddFacultyName
            // 
            this.lblAddFacultyName.AutoSize = true;
            this.lblAddFacultyName.Location = new System.Drawing.Point(75, 157);
            this.lblAddFacultyName.Name = "lblAddFacultyName";
            this.lblAddFacultyName.Size = new System.Drawing.Size(38, 13);
            this.lblAddFacultyName.TabIndex = 20;
            this.lblAddFacultyName.Text = "Name:";
            // 
            // txtAddFacultyName
            // 
            this.txtAddFacultyName.Location = new System.Drawing.Point(182, 154);
            this.txtAddFacultyName.Name = "txtAddFacultyName";
            this.txtAddFacultyName.Size = new System.Drawing.Size(203, 20);
            this.txtAddFacultyName.TabIndex = 19;
            this.txtAddFacultyName.TextChanged += new System.EventHandler(this.txtAddFacultyName_TextChanged);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.Location = new System.Drawing.Point(213, 252);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(75, 23);
            this.btnAddFaculty.TabIndex = 16;
            this.btnAddFaculty.Text = "Add Faculty";
            this.btnAddFaculty.UseVisualStyleBackColor = true;
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // txtAddFacultyPassword
            // 
            this.txtAddFacultyPassword.Location = new System.Drawing.Point(182, 114);
            this.txtAddFacultyPassword.Name = "txtAddFacultyPassword";
            this.txtAddFacultyPassword.PasswordChar = '*';
            this.txtAddFacultyPassword.Size = new System.Drawing.Size(203, 20);
            this.txtAddFacultyPassword.TabIndex = 15;
            // 
            // lblAddFacultyPassword
            // 
            this.lblAddFacultyPassword.AutoSize = true;
            this.lblAddFacultyPassword.Location = new System.Drawing.Point(75, 117);
            this.lblAddFacultyPassword.Name = "lblAddFacultyPassword";
            this.lblAddFacultyPassword.Size = new System.Drawing.Size(56, 13);
            this.lblAddFacultyPassword.TabIndex = 14;
            this.lblAddFacultyPassword.Text = "Password:";
            // 
            // txtAddFacultyUsername
            // 
            this.txtAddFacultyUsername.Location = new System.Drawing.Point(182, 84);
            this.txtAddFacultyUsername.Name = "txtAddFacultyUsername";
            this.txtAddFacultyUsername.Size = new System.Drawing.Size(203, 20);
            this.txtAddFacultyUsername.TabIndex = 13;
            // 
            // lblAddFacultyUsername
            // 
            this.lblAddFacultyUsername.AutoSize = true;
            this.lblAddFacultyUsername.Location = new System.Drawing.Point(75, 87);
            this.lblAddFacultyUsername.Name = "lblAddFacultyUsername";
            this.lblAddFacultyUsername.Size = new System.Drawing.Size(58, 13);
            this.lblAddFacultyUsername.TabIndex = 12;
            this.lblAddFacultyUsername.Text = "Username:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btnRefreshStudents);
            this.tabPage3.Controls.Add(this.dataGridViewStudents);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(582, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View all Students ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(136, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(303, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "TA/LD Management System";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRefreshStudents
            // 
            this.btnRefreshStudents.Location = new System.Drawing.Point(6, 8);
            this.btnRefreshStudents.Name = "btnRefreshStudents";
            this.btnRefreshStudents.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshStudents.TabIndex = 1;
            this.btnRefreshStudents.Text = "Refresh";
            this.btnRefreshStudents.UseVisualStyleBackColor = true;
            this.btnRefreshStudents.Click += new System.EventHandler(this.btnRefreshStudents_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(6, 37);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(576, 273);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.btnRefreshFaculty);
            this.tabPage4.Controls.Add(this.dataGridViewFaculty);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View all Faculty";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(127, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(303, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "TA/LD Management System";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRefreshFaculty
            // 
            this.btnRefreshFaculty.Location = new System.Drawing.Point(6, 6);
            this.btnRefreshFaculty.Name = "btnRefreshFaculty";
            this.btnRefreshFaculty.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshFaculty.TabIndex = 3;
            this.btnRefreshFaculty.Text = "Refresh";
            this.btnRefreshFaculty.UseVisualStyleBackColor = true;
            this.btnRefreshFaculty.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewFaculty
            // 
            this.dataGridViewFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculty.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewFaculty.Name = "dataGridViewFaculty";
            this.dataGridViewFaculty.Size = new System.Drawing.Size(576, 273);
            this.dataGridViewFaculty.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "TA/LD Management System";
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 360);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_form";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRefreshStudents;
        private System.Windows.Forms.Button btnRefreshFaculty;
        private System.Windows.Forms.DataGridView dataGridViewFaculty;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudentDeoartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFacultyDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddStudentEmail;
        private System.Windows.Forms.ComboBox cmbCourseType;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddFacultyEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
    }
}
