/*// WelcomeForm.Designer.cs
namespace win_form_test
{
    partial class Dashboard_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTA;
        private System.Windows.Forms.Button btnFaculty;

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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTA = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(125, 58);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(342, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Please select your role:";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(149, 128);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(104, 37);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTA
            // 
            this.btnTA.Location = new System.Drawing.Point(276, 128);
            this.btnTA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTA.Name = "btnTA";
            this.btnTA.Size = new System.Drawing.Size(104, 37);
            this.btnTA.TabIndex = 2;
            this.btnTA.Text = "TA";
            this.btnTA.UseVisualStyleBackColor = true;
            this.btnTA.Click += new System.EventHandler(this.btnTA_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.Location = new System.Drawing.Point(404, 128);
            this.btnFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(104, 37);
            this.btnFaculty.TabIndex = 3;
            this.btnFaculty.Text = "Faculty";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // Dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 206);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnTA);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard_form";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_form_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
*/