namespace win_form_test
{
    partial class Faculty_form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewTAs = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtAssignTaskDueDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssignTaskStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssignTaskPriority = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssignTaskQuantity = new System.Windows.Forms.TextBox();
            this.txtAssignTaskType = new System.Windows.Forms.TextBox();
            this.cbmAssignTAFaculty = new System.Windows.Forms.ComboBox();
            this.cbmAssignTAName = new System.Windows.Forms.ComboBox();
            this.cbmAssignTACourse = new System.Windows.Forms.ComboBox();
            this.btnAssignTA = new System.Windows.Forms.Button();
            this.lblAssignTACourse = new System.Windows.Forms.Label();
            this.lblAssignTAName = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.btnRemoveTA = new System.Windows.Forms.Button();
            this.txtRemoveTA = new System.Windows.Forms.TextBox();
            this.lblRemoveTAName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbAddTAStudent = new System.Windows.Forms.ComboBox();
            this.cmbAddTACourse = new System.Windows.Forms.ComboBox();
            this.btnAddTA = new System.Windows.Forms.Button();
            this.lblAddTACourse = new System.Windows.Forms.Label();
            this.lblAddTAName = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Project_Test = new win_form_test.DB_Project_Test();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbAddLDStudent = new System.Windows.Forms.ComboBox();
            this.cmbAddLDCourse = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRemoveLD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtAssignTaskDueDateLD = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAssignTaskStatusLD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAssignTaskPriorityLD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAssignTaskQuantityLD = new System.Windows.Forms.TextBox();
            this.txtAssignTaskTypeLD = new System.Windows.Forms.TextBox();
            this.cbmAssignFacultyLD = new System.Windows.Forms.ComboBox();
            this.cbmAssignLDName = new System.Windows.Forms.ComboBox();
            this.cbmAssignLDCourse = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.courseTableAdapter = new win_form_test.DB_Project_TestTableAdapters.CourseTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new win_form_test.DB_Project_TestTableAdapters.StudentTableAdapter();
            this.dBProjectTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new win_form_test.DB_Project_TestTableAdapters.UserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Project_Test)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.button16);
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Controls.Add(this.btnViewTAs);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(827, 320);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "View TAs";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(732, 8);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 38;
            this.button16.Text = "Logout";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 281);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnViewTAs
            // 
            this.btnViewTAs.Location = new System.Drawing.Point(3, 3);
            this.btnViewTAs.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTAs.Name = "btnViewTAs";
            this.btnViewTAs.Size = new System.Drawing.Size(136, 32);
            this.btnViewTAs.TabIndex = 0;
            this.btnViewTAs.Text = "View TAs";
            this.btnViewTAs.UseVisualStyleBackColor = true;
            this.btnViewTAs.Click += new System.EventHandler(this.btnViewTAs_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.dtAssignTaskDueDate);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtAssignTaskStatus);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.txtAssignTaskPriority);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.txtAssignTaskQuantity);
            this.tabPage5.Controls.Add(this.txtAssignTaskType);
            this.tabPage5.Controls.Add(this.cbmAssignTAFaculty);
            this.tabPage5.Controls.Add(this.cbmAssignTAName);
            this.tabPage5.Controls.Add(this.cbmAssignTACourse);
            this.tabPage5.Controls.Add(this.btnAssignTA);
            this.tabPage5.Controls.Add(this.lblAssignTACourse);
            this.tabPage5.Controls.Add(this.lblAssignTAName);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(827, 320);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Assign TA Task";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(496, 18);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 39;
            this.button14.Text = "Logout";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(328, 28);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 29);
            this.button8.TabIndex = 37;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.refreshTA_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(23, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Due Date:";
            // 
            // dtAssignTaskDueDate
            // 
            this.dtAssignTaskDueDate.Location = new System.Drawing.Point(105, 240);
            this.dtAssignTaskDueDate.Name = "dtAssignTaskDueDate";
            this.dtAssignTaskDueDate.Size = new System.Drawing.Size(195, 20);
            this.dtAssignTaskDueDate.TabIndex = 17;
            this.dtAssignTaskDueDate.ValueChanged += new System.EventHandler(this.dtAssignTaskDueDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(22, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status";
            // 
            // txtAssignTaskStatus
            // 
            this.txtAssignTaskStatus.Location = new System.Drawing.Point(105, 214);
            this.txtAssignTaskStatus.Name = "txtAssignTaskStatus";
            this.txtAssignTaskStatus.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskStatus.TabIndex = 15;
            this.txtAssignTaskStatus.TextChanged += new System.EventHandler(this.txtAssignTaskStatus_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Priority";
            // 
            // txtAssignTaskPriority
            // 
            this.txtAssignTaskPriority.Location = new System.Drawing.Point(105, 188);
            this.txtAssignTaskPriority.Name = "txtAssignTaskPriority";
            this.txtAssignTaskPriority.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskPriority.TabIndex = 13;
            this.txtAssignTaskPriority.TextChanged += new System.EventHandler(this.txtAssignTaskPriority_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Task Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Task Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Faculty:";
            // 
            // txtAssignTaskQuantity
            // 
            this.txtAssignTaskQuantity.Location = new System.Drawing.Point(105, 162);
            this.txtAssignTaskQuantity.Name = "txtAssignTaskQuantity";
            this.txtAssignTaskQuantity.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskQuantity.TabIndex = 9;
            this.txtAssignTaskQuantity.TextChanged += new System.EventHandler(this.txtAssignTaskQuantity_TextChanged);
            // 
            // txtAssignTaskType
            // 
            this.txtAssignTaskType.Location = new System.Drawing.Point(105, 136);
            this.txtAssignTaskType.Name = "txtAssignTaskType";
            this.txtAssignTaskType.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskType.TabIndex = 8;
            this.txtAssignTaskType.TextChanged += new System.EventHandler(this.txtAssignTaskType_TextChanged);
            // 
            // cbmAssignTAFaculty
            // 
            this.cbmAssignTAFaculty.FormattingEnabled = true;
            this.cbmAssignTAFaculty.Location = new System.Drawing.Point(105, 109);
            this.cbmAssignTAFaculty.Name = "cbmAssignTAFaculty";
            this.cbmAssignTAFaculty.Size = new System.Drawing.Size(195, 21);
            this.cbmAssignTAFaculty.TabIndex = 7;
            this.cbmAssignTAFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbAssignTAFaculty_SelectedIndexChanged);
            // 
            // cbmAssignTAName
            // 
            this.cbmAssignTAName.FormattingEnabled = true;
            this.cbmAssignTAName.Location = new System.Drawing.Point(105, 55);
            this.cbmAssignTAName.Name = "cbmAssignTAName";
            this.cbmAssignTAName.Size = new System.Drawing.Size(195, 21);
            this.cbmAssignTAName.TabIndex = 6;
            this.cbmAssignTAName.SelectedIndexChanged += new System.EventHandler(this.cbmAssignTAName_SelectedIndexChanged);
            // 
            // cbmAssignTACourse
            // 
            this.cbmAssignTACourse.FormattingEnabled = true;
            this.cbmAssignTACourse.Location = new System.Drawing.Point(105, 28);
            this.cbmAssignTACourse.Name = "cbmAssignTACourse";
            this.cbmAssignTACourse.Size = new System.Drawing.Size(195, 21);
            this.cbmAssignTACourse.TabIndex = 5;
            this.cbmAssignTACourse.SelectedIndexChanged += new System.EventHandler(this.cbmAssignTACourse_SelectedIndexChanged);
            // 
            // btnAssignTA
            // 
            this.btnAssignTA.Location = new System.Drawing.Point(148, 275);
            this.btnAssignTA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTA.Name = "btnAssignTA";
            this.btnAssignTA.Size = new System.Drawing.Size(74, 29);
            this.btnAssignTA.TabIndex = 4;
            this.btnAssignTA.Text = "Assign TA";
            this.btnAssignTA.UseVisualStyleBackColor = true;
            this.btnAssignTA.Click += new System.EventHandler(this.btnAssignTA_Click);
            // 
            // lblAssignTACourse
            // 
            this.lblAssignTACourse.AutoSize = true;
            this.lblAssignTACourse.Location = new System.Drawing.Point(22, 28);
            this.lblAssignTACourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignTACourse.Name = "lblAssignTACourse";
            this.lblAssignTACourse.Size = new System.Drawing.Size(71, 13);
            this.lblAssignTACourse.TabIndex = 0;
            this.lblAssignTACourse.Text = "Course Name";
            // 
            // lblAssignTAName
            // 
            this.lblAssignTAName.AutoSize = true;
            this.lblAssignTAName.Location = new System.Drawing.Point(22, 55);
            this.lblAssignTAName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignTAName.Name = "lblAssignTAName";
            this.lblAssignTAName.Size = new System.Drawing.Size(55, 13);
            this.lblAssignTAName.TabIndex = 2;
            this.lblAssignTAName.Text = "TA Name:";
            this.lblAssignTAName.Click += new System.EventHandler(this.lblAssignTAName_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.btnRemoveTA);
            this.tabPage4.Controls.Add(this.txtRemoveTA);
            this.tabPage4.Controls.Add(this.lblRemoveTAName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(827, 320);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Remove TA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(340, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Logout";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnRemoveTA
            // 
            this.btnRemoveTA.Location = new System.Drawing.Point(105, 122);
            this.btnRemoveTA.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveTA.Name = "btnRemoveTA";
            this.btnRemoveTA.Size = new System.Drawing.Size(74, 29);
            this.btnRemoveTA.TabIndex = 2;
            this.btnRemoveTA.Text = "Remove TA";
            this.btnRemoveTA.UseVisualStyleBackColor = true;
            this.btnRemoveTA.Click += new System.EventHandler(this.btnRemoveTA_Click);
            // 
            // txtRemoveTA
            // 
            this.txtRemoveTA.Location = new System.Drawing.Point(105, 81);
            this.txtRemoveTA.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveTA.Name = "txtRemoveTA";
            this.txtRemoveTA.Size = new System.Drawing.Size(151, 20);
            this.txtRemoveTA.TabIndex = 1;
            this.txtRemoveTA.TextChanged += new System.EventHandler(this.txtRemoveTA_TextChanged);
            // 
            // lblRemoveTAName
            // 
            this.lblRemoveTAName.AutoSize = true;
            this.lblRemoveTAName.Location = new System.Drawing.Point(58, 84);
            this.lblRemoveTAName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveTAName.Name = "lblRemoveTAName";
            this.lblRemoveTAName.Size = new System.Drawing.Size(35, 13);
            this.lblRemoveTAName.TabIndex = 0;
            this.lblRemoveTAName.Text = "TA ID";
            this.lblRemoveTAName.Click += new System.EventHandler(this.lblRemoveTAName_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.cmbAddTAStudent);
            this.tabPage3.Controls.Add(this.cmbAddTACourse);
            this.tabPage3.Controls.Add(this.btnAddTA);
            this.tabPage3.Controls.Add(this.lblAddTACourse);
            this.tabPage3.Controls.Add(this.lblAddTAName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(827, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add TA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(388, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Logout";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.TA_referesh_button_Click);
            // 
            // cmbAddTAStudent
            // 
            this.cmbAddTAStudent.FormattingEnabled = true;
            this.cmbAddTAStudent.Location = new System.Drawing.Point(105, 98);
            this.cmbAddTAStudent.Name = "cmbAddTAStudent";
            this.cmbAddTAStudent.Size = new System.Drawing.Size(151, 21);
            this.cmbAddTAStudent.TabIndex = 6;
            this.cmbAddTAStudent.SelectedIndexChanged += new System.EventHandler(this.cmbAddTAStudent_SelectedIndexChanged);
            // 
            // cmbAddTACourse
            // 
            this.cmbAddTACourse.FormattingEnabled = true;
            this.cmbAddTACourse.Location = new System.Drawing.Point(105, 46);
            this.cmbAddTACourse.Name = "cmbAddTACourse";
            this.cmbAddTACourse.Size = new System.Drawing.Size(151, 21);
            this.cmbAddTACourse.TabIndex = 5;
            this.cmbAddTACourse.SelectedIndexChanged += new System.EventHandler(this.cmbAddTACourse_SelectedIndexChanged);
            // 
            // btnAddTA
            // 
            this.btnAddTA.Location = new System.Drawing.Point(105, 162);
            this.btnAddTA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTA.Name = "btnAddTA";
            this.btnAddTA.Size = new System.Drawing.Size(74, 29);
            this.btnAddTA.TabIndex = 4;
            this.btnAddTA.Text = "Add TA";
            this.btnAddTA.UseVisualStyleBackColor = true;
            this.btnAddTA.Click += new System.EventHandler(this.btnAddTA_Click);
            // 
            // lblAddTACourse
            // 
            this.lblAddTACourse.AutoSize = true;
            this.lblAddTACourse.Location = new System.Drawing.Point(22, 49);
            this.lblAddTACourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTACourse.Name = "lblAddTACourse";
            this.lblAddTACourse.Size = new System.Drawing.Size(71, 13);
            this.lblAddTACourse.TabIndex = 0;
            this.lblAddTACourse.Text = "Course Name";
            // 
            // lblAddTAName
            // 
            this.lblAddTAName.AutoSize = true;
            this.lblAddTAName.Location = new System.Drawing.Point(22, 98);
            this.lblAddTAName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTAName.Name = "lblAddTAName";
            this.lblAddTAName.Size = new System.Drawing.Size(75, 13);
            this.lblAddTAName.TabIndex = 2;
            this.lblAddTAName.Text = "Student Name";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dB_Project_Test;
            // 
            // dB_Project_Test
            // 
            this.dB_Project_Test.DataSetName = "DB_Project_Test";
            this.dB_Project_Test.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label36);
            this.tabPage9.Controls.Add(this.button9);
            this.tabPage9.Controls.Add(this.label32);
            this.tabPage9.Controls.Add(this.label31);
            this.tabPage9.Controls.Add(this.label30);
            this.tabPage9.Controls.Add(this.label29);
            this.tabPage9.Controls.Add(this.label28);
            this.tabPage9.Controls.Add(this.label27);
            this.tabPage9.Controls.Add(this.label26);
            this.tabPage9.Controls.Add(this.label25);
            this.tabPage9.Controls.Add(this.label24);
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(827, 320);
            this.tabPage9.TabIndex = 10;
            this.tabPage9.Text = "Faculty Details";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(225, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Logout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(121, 168);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 13);
            this.label32.TabIndex = 10;
            this.label32.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(121, 143);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "label31";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(121, 115);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "label30";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(118, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "label29";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(118, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "label28";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 168);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Faculty Department:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(67, 57);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "User ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 143);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Faculty Email:";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(55, 85);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Faculty ID:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 115);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Faculty Name:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmbAddLDStudent);
            this.tabPage1.Controls.Add(this.cmbAddLDCourse);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 320);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Add LD";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(371, 23);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "Logout";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 29);
            this.button5.TabIndex = 18;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.LD_referesh_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add LD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddLD_Click);
            // 
            // cmbAddLDStudent
            // 
            this.cmbAddLDStudent.FormattingEnabled = true;
            this.cmbAddLDStudent.Location = new System.Drawing.Point(111, 118);
            this.cmbAddLDStudent.Name = "cmbAddLDStudent";
            this.cmbAddLDStudent.Size = new System.Drawing.Size(151, 21);
            this.cmbAddLDStudent.TabIndex = 14;
            this.cmbAddLDStudent.SelectedIndexChanged += new System.EventHandler(this.cmbAddLDStudent_SelectedIndexChanged);
            // 
            // cmbAddLDCourse
            // 
            this.cmbAddLDCourse.FormattingEnabled = true;
            this.cmbAddLDCourse.Location = new System.Drawing.Point(111, 66);
            this.cmbAddLDCourse.Name = "cmbAddLDCourse";
            this.cmbAddLDCourse.Size = new System.Drawing.Size(151, 21);
            this.cmbAddLDCourse.TabIndex = 13;
            this.cmbAddLDCourse.SelectedIndexChanged += new System.EventHandler(this.cmbAddLDCourse_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Course Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Student Name";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Controls.Add(this.button13);
            this.tabPage7.Controls.Add(this.button3);
            this.tabPage7.Controls.Add(this.txtRemoveLD);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(827, 320);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "Remove LD";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(323, 17);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "Logout";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Remove LD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnRemoveLD_Click);
            // 
            // txtRemoveLD
            // 
            this.txtRemoveLD.Location = new System.Drawing.Point(119, 83);
            this.txtRemoveLD.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoveLD.Name = "txtRemoveLD";
            this.txtRemoveLD.Size = new System.Drawing.Size(151, 20);
            this.txtRemoveLD.TabIndex = 5;
            this.txtRemoveLD.TextChanged += new System.EventHandler(this.txtRemoveLD_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "LD ID";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label10);
            this.tabPage8.Controls.Add(this.button15);
            this.tabPage8.Controls.Add(this.button7);
            this.tabPage8.Controls.Add(this.label9);
            this.tabPage8.Controls.Add(this.dtAssignTaskDueDateLD);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.txtAssignTaskStatusLD);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.txtAssignTaskPriorityLD);
            this.tabPage8.Controls.Add(this.label17);
            this.tabPage8.Controls.Add(this.label18);
            this.tabPage8.Controls.Add(this.label19);
            this.tabPage8.Controls.Add(this.txtAssignTaskQuantityLD);
            this.tabPage8.Controls.Add(this.txtAssignTaskTypeLD);
            this.tabPage8.Controls.Add(this.cbmAssignFacultyLD);
            this.tabPage8.Controls.Add(this.cbmAssignLDName);
            this.tabPage8.Controls.Add(this.cbmAssignLDCourse);
            this.tabPage8.Controls.Add(this.button6);
            this.tabPage8.Controls.Add(this.label20);
            this.tabPage8.Controls.Add(this.label21);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage8.Size = new System.Drawing.Size(827, 320);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "Assign LD Task ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(454, 13);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 37;
            this.button15.Text = "Logout";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(333, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 29);
            this.button7.TabIndex = 36;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.refreshLD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(35, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Due Date:";
            // 
            // dtAssignTaskDueDateLD
            // 
            this.dtAssignTaskDueDateLD.Location = new System.Drawing.Point(117, 235);
            this.dtAssignTaskDueDateLD.Name = "dtAssignTaskDueDateLD";
            this.dtAssignTaskDueDateLD.Size = new System.Drawing.Size(195, 20);
            this.dtAssignTaskDueDateLD.TabIndex = 34;
            this.dtAssignTaskDueDateLD.ValueChanged += new System.EventHandler(this.dtAssignTaskDueDateLD_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Location = new System.Drawing.Point(34, 212);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Status";
            // 
            // txtAssignTaskStatusLD
            // 
            this.txtAssignTaskStatusLD.Location = new System.Drawing.Point(117, 209);
            this.txtAssignTaskStatusLD.Name = "txtAssignTaskStatusLD";
            this.txtAssignTaskStatusLD.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskStatusLD.TabIndex = 32;
            this.txtAssignTaskStatusLD.TextChanged += new System.EventHandler(this.txtAssignTaskStatusLD_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 190);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Priority";
            // 
            // txtAssignTaskPriorityLD
            // 
            this.txtAssignTaskPriorityLD.Location = new System.Drawing.Point(117, 183);
            this.txtAssignTaskPriorityLD.Name = "txtAssignTaskPriorityLD";
            this.txtAssignTaskPriorityLD.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskPriorityLD.TabIndex = 30;
            this.txtAssignTaskPriorityLD.TextChanged += new System.EventHandler(this.txtAssignTaskPriorityLD_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Task Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 134);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Task Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 107);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Faculty";
            // 
            // txtAssignTaskQuantityLD
            // 
            this.txtAssignTaskQuantityLD.Location = new System.Drawing.Point(117, 157);
            this.txtAssignTaskQuantityLD.Name = "txtAssignTaskQuantityLD";
            this.txtAssignTaskQuantityLD.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskQuantityLD.TabIndex = 26;
            this.txtAssignTaskQuantityLD.TextChanged += new System.EventHandler(this.txtAssignTaskQuantityLD_TextChanged);
            // 
            // txtAssignTaskTypeLD
            // 
            this.txtAssignTaskTypeLD.Location = new System.Drawing.Point(117, 131);
            this.txtAssignTaskTypeLD.Name = "txtAssignTaskTypeLD";
            this.txtAssignTaskTypeLD.Size = new System.Drawing.Size(195, 20);
            this.txtAssignTaskTypeLD.TabIndex = 25;
            this.txtAssignTaskTypeLD.TextChanged += new System.EventHandler(this.txtAssignTaskTypeLD_TextChanged_1);
            // 
            // cbmAssignFacultyLD
            // 
            this.cbmAssignFacultyLD.FormattingEnabled = true;
            this.cbmAssignFacultyLD.Location = new System.Drawing.Point(117, 104);
            this.cbmAssignFacultyLD.Name = "cbmAssignFacultyLD";
            this.cbmAssignFacultyLD.Size = new System.Drawing.Size(195, 21);
            this.cbmAssignFacultyLD.TabIndex = 24;
            this.cbmAssignFacultyLD.SelectedIndexChanged += new System.EventHandler(this.cbmAssignFacultyLD_SelectedIndexChanged_1);
            // 
            // cbmAssignLDName
            // 
            this.cbmAssignLDName.FormattingEnabled = true;
            this.cbmAssignLDName.Location = new System.Drawing.Point(117, 50);
            this.cbmAssignLDName.Name = "cbmAssignLDName";
            this.cbmAssignLDName.Size = new System.Drawing.Size(195, 21);
            this.cbmAssignLDName.TabIndex = 23;
            this.cbmAssignLDName.SelectedIndexChanged += new System.EventHandler(this.cbmAssignLDName_SelectedIndexChanged_2);
            // 
            // cbmAssignLDCourse
            // 
            this.cbmAssignLDCourse.FormattingEnabled = true;
            this.cbmAssignLDCourse.Location = new System.Drawing.Point(117, 23);
            this.cbmAssignLDCourse.Name = "cbmAssignLDCourse";
            this.cbmAssignLDCourse.Size = new System.Drawing.Size(195, 21);
            this.cbmAssignLDCourse.TabIndex = 22;
            this.cbmAssignLDCourse.SelectedIndexChanged += new System.EventHandler(this.cbmAssignLDCourse_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(160, 270);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 29);
            this.button6.TabIndex = 21;
            this.button6.Text = "Assign LD";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnAssignLD_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Course Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 50);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "LD Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 320);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "View LDs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(732, 7);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 38;
            this.button17.Text = "Logout";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "View LDs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnViewLDs_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(804, 281);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dB_Project_Test;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dBProjectTestBindingSource
            // 
            this.dBProjectTestBindingSource.DataSource = this.dB_Project_Test;
            this.dBProjectTestBindingSource.Position = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dB_Project_Test;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "TA/LD Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "TA/LD Management System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "TA/LD Management System";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(442, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "TA/LD Management System";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(374, 117);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(303, 25);
            this.label23.TabIndex = 14;
            this.label23.Text = "TA/LD Management System";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(382, 126);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(303, 25);
            this.label33.TabIndex = 14;
            this.label33.Text = "TA/LD Management System";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(395, 118);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(303, 25);
            this.label34.TabIndex = 20;
            this.label34.Text = "TA/LD Management System";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(383, 127);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(303, 25);
            this.label35.TabIndex = 14;
            this.label35.Text = "TA/LD Management System";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(444, 131);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(303, 25);
            this.label36.TabIndex = 14;
            this.label36.Text = "TA/LD Management System";
            // 
            // Faculty_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Faculty_form";
            this.Text = "Faculty Dashboard";
            this.Load += new System.EventHandler(this.Faculty_form_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Project_Test)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewTAs;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnAssignTA;
        private System.Windows.Forms.Label lblAssignTACourse;
        private System.Windows.Forms.Label lblAssignTAName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtRemoveTA;
        private System.Windows.Forms.Label lblRemoveTAName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddTA;
        private System.Windows.Forms.Label lblAddTACourse;
        private System.Windows.Forms.Label lblAddTAName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cmbAddTACourse;
        private DB_Project_Test dB_Project_Test;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DB_Project_TestTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ComboBox cmbAddTAStudent;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DB_Project_TestTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource dBProjectTestBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DB_Project_TestTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ComboBox cbmAssignTACourse;
        private System.Windows.Forms.ComboBox cbmAssignTAFaculty;
        private System.Windows.Forms.ComboBox cbmAssignTAName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssignTaskQuantity;
        private System.Windows.Forms.TextBox txtAssignTaskType;
        private System.Windows.Forms.TextBox txtAssignTaskPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtAssignTaskDueDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssignTaskStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbAddLDStudent;
        private System.Windows.Forms.ComboBox cmbAddLDCourse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRemoveLD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoveTA;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtAssignTaskDueDateLD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAssignTaskStatusLD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAssignTaskPriorityLD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAssignTaskQuantityLD;
        private System.Windows.Forms.TextBox txtAssignTaskTypeLD;
        private System.Windows.Forms.ComboBox cbmAssignFacultyLD;
        private System.Windows.Forms.ComboBox cbmAssignLDName;
        private System.Windows.Forms.ComboBox cbmAssignLDCourse;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}

