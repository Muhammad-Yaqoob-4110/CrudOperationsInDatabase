namespace LabTask01
{
    partial class ResultData
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
            this.btnResultData = new System.Windows.Forms.Button();
            this.btnAddaResult = new System.Windows.Forms.Button();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.tbCourse_Name = new System.Windows.Forms.TextBox();
            this.tbMarks = new System.Windows.Forms.TextBox();
            this.tbStudent_ID = new System.Windows.Forms.TextBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCourse_Name = new System.Windows.Forms.Label();
            this.lblStudent_ID = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.tbSection = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.tbSession = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(128, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 50);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnResultData
            // 
            this.btnResultData.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultData.Location = new System.Drawing.Point(12, 7);
            this.btnResultData.Name = "btnResultData";
            this.btnResultData.Size = new System.Drawing.Size(304, 50);
            this.btnResultData.TabIndex = 44;
            this.btnResultData.Text = "Retrieve Result Data";
            this.btnResultData.UseVisualStyleBackColor = true;
            this.btnResultData.Click += new System.EventHandler(this.btnRetrieveCourseData_Click);
            // 
            // btnAddaResult
            // 
            this.btnAddaResult.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddaResult.Location = new System.Drawing.Point(566, 398);
            this.btnAddaResult.Name = "btnAddaResult";
            this.btnAddaResult.Size = new System.Drawing.Size(222, 50);
            this.btnAddaResult.TabIndex = 43;
            this.btnAddaResult.Text = "Add a Result";
            this.btnAddaResult.UseVisualStyleBackColor = true;
            this.btnAddaResult.Click += new System.EventHandler(this.btnAddaCourse_Click);
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(377, 116);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(411, 20);
            this.tbStudentName.TabIndex = 41;
            this.tbStudentName.TextChanged += new System.EventHandler(this.tbStudentName_TextChanged);
            // 
            // tbCourse_Name
            // 
            this.tbCourse_Name.Location = new System.Drawing.Point(377, 159);
            this.tbCourse_Name.Name = "tbCourse_Name";
            this.tbCourse_Name.Size = new System.Drawing.Size(411, 20);
            this.tbCourse_Name.TabIndex = 40;
            this.tbCourse_Name.TextChanged += new System.EventHandler(this.tbTeacherName_TextChanged);
            // 
            // tbMarks
            // 
            this.tbMarks.Location = new System.Drawing.Point(377, 201);
            this.tbMarks.Name = "tbMarks";
            this.tbMarks.Size = new System.Drawing.Size(411, 20);
            this.tbMarks.TabIndex = 39;
            this.tbMarks.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // tbStudent_ID
            // 
            this.tbStudent_ID.Location = new System.Drawing.Point(377, 76);
            this.tbStudent_ID.Name = "tbStudent_ID";
            this.tbStudent_ID.Size = new System.Drawing.Size(411, 20);
            this.tbStudent_ID.TabIndex = 38;
            this.tbStudent_ID.TextChanged += new System.EventHandler(this.tbCourseID_TextChanged);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(134, 191);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(73, 33);
            this.lblMarks.TabIndex = 37;
            this.lblMarks.Text = "Marks";
            this.lblMarks.Click += new System.EventHandler(this.lblSemester_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(134, 106);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(157, 33);
            this.lblStudentName.TabIndex = 35;
            this.lblStudentName.Text = "Student_Name";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblCourse_Name
            // 
            this.lblCourse_Name.AutoSize = true;
            this.lblCourse_Name.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse_Name.Location = new System.Drawing.Point(134, 149);
            this.lblCourse_Name.Name = "lblCourse_Name";
            this.lblCourse_Name.Size = new System.Drawing.Size(143, 33);
            this.lblCourse_Name.TabIndex = 34;
            this.lblCourse_Name.Text = "Course_Name";
            this.lblCourse_Name.Click += new System.EventHandler(this.lblTeacherName_Click);
            // 
            // lblStudent_ID
            // 
            this.lblStudent_ID.AutoSize = true;
            this.lblStudent_ID.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent_ID.Location = new System.Drawing.Point(134, 66);
            this.lblStudent_ID.Name = "lblStudent_ID";
            this.lblStudent_ID.Size = new System.Drawing.Size(122, 33);
            this.lblStudent_ID.TabIndex = 33;
            this.lblStudent_ID.Text = "Student_ID";
            this.lblStudent_ID.Click += new System.EventHandler(this.lblCourseID_Click);
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(377, 243);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(411, 20);
            this.tbGrade.TabIndex = 47;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(134, 233);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(74, 33);
            this.lblGrade.TabIndex = 46;
            this.lblGrade.Text = "Grade";
            // 
            // tbSection
            // 
            this.tbSection.Location = new System.Drawing.Point(377, 284);
            this.tbSection.Name = "tbSection";
            this.tbSection.Size = new System.Drawing.Size(411, 20);
            this.tbSection.TabIndex = 49;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(134, 274);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(86, 33);
            this.lblSection.TabIndex = 48;
            this.lblSection.Text = "Section";
            // 
            // tbSession
            // 
            this.tbSession.Location = new System.Drawing.Point(377, 362);
            this.tbSession.Name = "tbSession";
            this.tbSession.Size = new System.Drawing.Size(411, 20);
            this.tbSession.TabIndex = 51;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(134, 352);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(83, 33);
            this.lblSession.TabIndex = 50;
            this.lblSession.Text = "Session";
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(377, 324);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(411, 20);
            this.tbSemester.TabIndex = 53;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(134, 314);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(104, 33);
            this.lblSemester.TabIndex = 52;
            this.lblSemester.Text = "Semester";
            // 
            // ResultData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.tbSession);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.tbSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnResultData);
            this.Controls.Add(this.btnAddaResult);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbCourse_Name);
            this.Controls.Add(this.tbMarks);
            this.Controls.Add(this.tbStudent_ID);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblCourse_Name);
            this.Controls.Add(this.lblStudent_ID);
            this.Name = "ResultData";
            this.Text = "ResultData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnResultData;
        private System.Windows.Forms.Button btnAddaResult;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TextBox tbCourse_Name;
        private System.Windows.Forms.TextBox tbMarks;
        private System.Windows.Forms.TextBox tbStudent_ID;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblCourse_Name;
        private System.Windows.Forms.Label lblStudent_ID;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox tbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox tbSession;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.Label lblSemester;
    }
}