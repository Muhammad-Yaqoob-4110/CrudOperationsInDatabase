namespace LabTask01
{
    partial class CourseData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRetrieveCourseData = new System.Windows.Forms.Button();
            this.btnAddaCourse = new System.Windows.Forms.Button();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.tbCourseID = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(128, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 50);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRetrieveCourseData
            // 
            this.btnRetrieveCourseData.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveCourseData.Location = new System.Drawing.Point(12, 14);
            this.btnRetrieveCourseData.Name = "btnRetrieveCourseData";
            this.btnRetrieveCourseData.Size = new System.Drawing.Size(304, 50);
            this.btnRetrieveCourseData.TabIndex = 30;
            this.btnRetrieveCourseData.Text = "Retrieve Course Data";
            this.btnRetrieveCourseData.UseVisualStyleBackColor = true;
            this.btnRetrieveCourseData.Click += new System.EventHandler(this.btnRetrieveCourseData_Click);
            // 
            // btnAddaCourse
            // 
            this.btnAddaCourse.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddaCourse.Location = new System.Drawing.Point(566, 386);
            this.btnAddaCourse.Name = "btnAddaCourse";
            this.btnAddaCourse.Size = new System.Drawing.Size(222, 50);
            this.btnAddaCourse.TabIndex = 29;
            this.btnAddaCourse.Text = "Add a Course";
            this.btnAddaCourse.UseVisualStyleBackColor = true;
            this.btnAddaCourse.Click += new System.EventHandler(this.btnAddaCourse_Click);
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(377, 163);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(411, 20);
            this.tbCourseName.TabIndex = 28;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(377, 213);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(411, 20);
            this.tbStudentName.TabIndex = 27;
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(377, 269);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(411, 20);
            this.tbTeacherName.TabIndex = 26;
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(377, 321);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(411, 20);
            this.tbSemester.TabIndex = 25;
            // 
            // tbCourseID
            // 
            this.tbCourseID.Location = new System.Drawing.Point(377, 112);
            this.tbCourseID.Name = "tbCourseID";
            this.tbCourseID.Size = new System.Drawing.Size(411, 20);
            this.tbCourseID.TabIndex = 23;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(134, 311);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(104, 33);
            this.lblSemester.TabIndex = 21;
            this.lblSemester.Text = "Semester";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(134, 153);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(143, 33);
            this.lblCourseName.TabIndex = 20;
            this.lblCourseName.Text = "Course_Name";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(134, 203);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(157, 33);
            this.lblStudentName.TabIndex = 19;
            this.lblStudentName.Text = "Student_Name";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(134, 259);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(155, 33);
            this.lblTeacherName.TabIndex = 18;
            this.lblTeacherName.Text = "Teacher_Name";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(134, 102);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(108, 33);
            this.lblCourseID.TabIndex = 17;
            this.lblCourseID.Text = "Course_ID";
            // 
            // CourseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRetrieveCourseData);
            this.Controls.Add(this.btnAddaCourse);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbCourseID);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblCourseID);
            this.Name = "CourseData";
            this.Text = "CourseData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRetrieveCourseData;
        private System.Windows.Forms.Button btnAddaCourse;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.TextBox tbCourseID;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblCourseID;
    }
}